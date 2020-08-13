using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
// ReSharper disable HeapView.ObjectAllocation.Possible

namespace Yagl.Gl.Generator
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Gl.Generator.\n");

            LoadSpec();
            ParseSpec();
            SaveResults();
        }
        
        private static XDocument _xml;
        
        private static readonly StringBuilder Result = new StringBuilder();
        
        private static void LoadSpec()
        {
            Console.Write("Loading the spec... ");
            _xml = XDocument.Load(@"../../../../Specs/gl.xml");
            Console.WriteLine("OK");
        }

        private static void ParseSpec()
        {
            Console.Write("Parsing the spec... ");
            if (_xml.Root == null) return;
            ProcessSection(_xml.Root);
            Console.WriteLine("OK");
        }

        private static void SaveResults()
        {
            var result = new StringBuilder();
            result.AppendLine("// ReSharper disable UnusedMember.Global");
            result.AppendLine("// ReSharper disable InconsistentNaming");
            result.AppendLine("// ReSharper disable UnusedParameter.Global");
            result.AppendLine("// ReSharper disable IdentifierTypo");
            result.AppendLine("// ReSharper disable CommentTypo");
            result.AppendLine("using System;");
            result.AppendLine();
            result.AppendLine("namespace Yagl.Graphics");
            result.AppendLine("{");
            result.AppendLine("    public static partial class Gl");
            result.AppendLine("    {");
            result.Append(Result);
            result.AppendLine("    }");
            result.AppendLine("}");
            File.WriteAllText(@"../../../../Gl/Gl.Gen.cs", result.ToString());
        }

        private static void Out(string text = "")
        {
            Result.AppendLine($"        {text}");
        }

        private static void ProcessSection(XContainer section)
        {
            foreach (var element in section.Elements())
            {
                if (element.Name == "comment")
                    ProcessComment(element);
                else if (element.Name == "types")
                    ProcessTypes(element);
                else if (element.Name == "groups")
                    ProcessGroups(element);
                else if (element.Name == "enums")
                    ProcessEnum(element);
                else if (element.Name == "commands")
                    ProcessCommands(element);
                else
                    Console.WriteLine($"Section '{element.Name}' could not be parsed.");
            }
        }

        // ReSharper disable once UnusedParameter.Local
        private static void ProcessComment(XElement element)
        {
            // do nothing.
        }

        private static void ProcessTypes(XContainer types)
        {
            // Out("#region Types");
            // Out();
            foreach (var type in types.Elements())
                 ProcessType(type);
            // Out();
            // Out("#endregion");
            // Out();
        }

        // ReSharper disable once UnusedParameter.Local
        private static void ProcessType(XElement type)
        {
            // Do nothing.
            //Out($"// {type.Value}");
        }
        
        private static void ProcessGroups(XContainer element)
        {
            //Out("#region Constants");
            //Out();
            foreach (var el in element.Elements())
                ProcessGroup(el);
            //Out();
            //Out("#endregion");
            //Out();
        }

        // ReSharper disable once UnusedParameter.Local
        private static void ProcessGroup(XElement element)
        {
            //Out($"// {element.Attribute("name")?.Value}. {element.Attribute("comment")?.Value}");
        }
        
        private static void ProcessEnum(XElement element)
        {
            var name = element.Attribute("group")?.Value;
            var comment = element.Attribute("comment")?.Value;
            var type = element.Attribute("type")?.Value;
            comment = ProcessComment(comment);
            Out($"// {name}. {comment}");
            foreach (var el in element.Elements())
                ProcessEnumItem(el, type);
            Out();
        }

        private static string ProcessComment(string comment)
        {
            comment = comment?.Replace("Khronos bug ", "Khronos error #");
            comment = comment?.Replace("(bug ", "(error #");
            comment = comment?.Replace(", bug ", ", error #");
            comment = comment?.Replace("public bug ", "public error #");
            return comment;
        }

        private static void ProcessEnumItem(XElement element, string type)
        {
            if (element.Name == "enum")
            {
                var name = element.Attribute("name")?.Value.Trim() ?? "";
                if (name.StartsWith("GL_") && (name[3] < '0' || name[3] > '9'))
                    name = name.Substring(3);
                var value = element.Attribute("value")?.Value.Trim();
                var api = element.Attribute("api")?.Value.Trim();
                if (!(string.IsNullOrWhiteSpace(api) || api == "gl")) return;
                if (string.IsNullOrWhiteSpace(type) || type == "bitmask")
                    type = TryDetermineType(value);
                type = ConvertType(type, "int");
                Out($"public const {type} {name} = {value};");
                CheckAttributes(element, new[] {"name", "value", "group", "comment", "alias", "type", "api"});
            }
            else if (element.Name == "unused")
            {
                var start = element.Attribute("start")?.Value;
                var end = element.Attribute("end")?.Value;
                var comment = element.Attribute("comment")?.Value;
                comment = ProcessComment(comment);
                Out($"// Unused {start}{(end != null ? ".." + end : "")}. {comment}");
            }
            else
                Out($"// '{element.Name}' could not be parsed.");
        }
        
        private static void ProcessCommands(XElement element)
        {
            foreach (var el in element.Elements())
                ProcessCommand(el);
        }

        private static void ProcessCommand(XElement element)
        {
            if (element.Name != "command")
            {
                Out($"Couldn't parse '{element.Name}' inside Commands section.");
                return;
            }
            var comment = element.Attribute("comment")?.Value;
            var name = element.Element("proto")?.Element("name")?.Value;
            var rType = element.Element("proto")?.Element("ptype")?.Value
                       ?? (element.Element("proto")?.Value.StartsWith("void") == true ? "void" : "");
            rType = ConvertType(rType);
            var typeGroup = element.Element("proto")?.Attribute("group")?.Value;
            if (!string.IsNullOrWhiteSpace(typeGroup))
                rType = $"{rType} /*{typeGroup}*/";
            if (!string.IsNullOrWhiteSpace(comment))
                Out($"// {comment}");
            var parameters = new List<string>();
            foreach (var param in element.Elements("param"))
            {
                var pName = param.Element("name")?.Value;
                var pType = param.Element("ptype")?.Value;
                var pTypeGroup = param.Attribute("group")?.Value;
                pName = MakeParamNameSafe(pName);
                pType = ConvertType(pType);
                if (string.IsNullOrWhiteSpace(pType))
                    pType = ExtractParamType(param.Value);
                if (param.ToString().Contains("*<name"))
                    pType = $"{pType}*";
                pType = ProcessArraysAndPointers(pType);
                parameters.Add($"{pType} {(!string.IsNullOrWhiteSpace(pTypeGroup) ? "/*" + pTypeGroup + "*/ " : "")}{pName}");
            }
            Out($"public static {rType} {name}({(string.Join(", ", parameters))}) {{ {(rType == "void" ? "" : "return default;")} }}");
        }

        private static string ProcessArraysAndPointers(string pType)
        {
            if (pType == "void*")
                pType = "IntPtr";
            if (pType == "char*")
                pType = "string";
            if (pType == "struct _cl_context*")
                pType = "IntPtr";
            if (pType == "struct _cl_event*")
                pType = "IntPtr";
            var arrays = new[]
            {
                "bool*", 
                "sbyte*", "byte*", "short*", "ushort*", "int*", "uint*", "long*", "ulong*", "float*", "double*",
                "IntPtr*"
            };
            if (arrays.Contains(pType))
                pType = pType.Replace("*", "[]");
            return pType;
        }

        private static string ExtractParamType(string value)
        {
            if (value.Contains("void "))
                return "void";
            return "";
        }

        private static string TryDetermineType(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return "";
            if (ULongValueRegex.IsMatch(value)) return "ulong";
            if (UIntValueRegex.IsMatch(value)) return "uint";
            if (UShortValueRegex.IsMatch(value)) return "ushort";
            if (UByteValueRegex.IsMatch(value)) return "byte";
            return "int";
        }
        private static readonly Regex ULongValueRegex = new Regex(@"^0x[0-9a-fA-F]{16}$");
        private static readonly Regex UIntValueRegex = new Regex(@"^0x[0-9a-fA-F]{8}$");
        private static readonly Regex UShortValueRegex = new Regex(@"^0x[0-9a-fA-F]{4}$");
        private static readonly Regex UByteValueRegex = new Regex(@"^0x[0-9a-fA-F]{2}$");

        private static string ConvertType(string type, string deflt = "")
        {
            if (string.IsNullOrWhiteSpace(type)) return deflt;
            var result = type;
            switch (type)
            {
                case "bitmask":
                    result = "uint";
                    break;
                case "GLboolean":
                    result = "bool";
                    break;
                case "GLbyte":
                    result = "sbyte";
                    break;
                case "GLchar":
                case "GLcharARB":
                    result = "char";
                    break;
                case "GLubyte":
                    result = "byte";
                    break;
                case "GLshort":
                    result = "short";
                    break;
                case "GLushort":
                    result = "ushort";
                    break;
                case "GLint":
                    result = "int";
                    break;
                case "GLclampx":
                    result = "int /*GLclampx*/";
                    break;
                case "GLuint":
                case "GLenum":
                case "GLbitfield":
                    result = "uint";
                    break;
                case "GLfixed":
                    result = "int";
                    break;
                case "GLint64":
                case "GLint64EXT":
                    result = "long";
                    break;
                case "GLuint64":
                case "GLuint64EXT":
                    result = "ulong";
                    break;
                case "GLsizei":
                    result = "uint";
                    break;
                case "GLhandleARB":
                case "GLintptr":
                case "GLintptrARB":
                case "GLsizeiptr":
                case "GLsizeiptrARB":
                case "GLsync":
                    result = "IntPtr";
                    break;
                case "GLhalf":
                case "GLhalfARB":
                case "GLhalfNV":
                    result = "ushort";
                    break;
                case "GLfloat":
                case "GLclampf":
                    result = "float";
                    break;
                case "GLdouble":
                case "GLclampd":
                    result = "double";
                    break;
                case "GLvdpauSurfaceNV":
                    result = "IntPtr";
                    break;
                case "GLVULKANPROCNV":
                    result = "IntPtr /*GLVULKANPROCNV*/";
                    break;
                case "GLeglClientBufferEXT":
                    result = "IntPtr /*GLeglClientBufferEXT*/";
                    break;
                case "GLDEBUGPROC":
                case "GLDEBUGPROCARB":
                case "GLDEBUGPROCKHR":
                case "GLDEBUGPROCAMD":
                    result = "IntPtr /*GLDEBUGPROC*/";
                    break;
                case "GLeglImageOES":
                    result = "IntPtr /*GLeglImageOES*/";
                    break;
            }
            return result;
        }

        private static string MakeParamNameSafe(string param)
        {
            switch (param)
            {
                case "ref": param = "refVal";
                    break;
                case "params": param = "parameters";
                    break;
                case "string": param = "str";
                    break;
                case "event": param = "evnt";
                    break;
                case "object": param = "obj";
                    break;
                case "base": param = "basis";
                    break;
                case "in": param = "inp";
                    break;
            }
            return param;
        }

        private static void CheckAttributes(XElement element, string[] exclude)
        {
            var unusedAttributes = element.Attributes()
                .Where(a => !exclude.Contains(a.Name.LocalName))
                .ToArray();
            if (unusedAttributes.Length > 0)
                Out($"Attributes not processed: {string.Join<XAttribute>(", ", unusedAttributes)}");
        }
        
    }
}
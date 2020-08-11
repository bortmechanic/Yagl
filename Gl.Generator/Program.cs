using System;
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
                else
                    Out($"// Section '{element.Name}' could not be parsed.");
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
            Out($"// {name}. {comment}");
            foreach (var el in element.Elements())
                ProcessEnumItem(el, type);
            Out();
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
                type = ConvertType(type);
                Out($"public const {type} {name} = {value};");
                CheckAttributes(element, new[] {"name", "value", "group", "comment", "alias", "type", "api"});
            }
            else if (element.Name == "unused")
            {
                var start = element.Attribute("start")?.Value;
                var end = element.Attribute("end")?.Value;
                var comment = element.Attribute("comment")?.Value;
                Out($"// Unused {start}{(end != null ? ".." + end : "")}. {comment}");
            }
            else
                Out($"// '{element.Name}' could not be parsed.");
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

        private static string ConvertType(string type)
        {
            if (string.IsNullOrWhiteSpace(type)) return "int";
            type = type.Replace("bitmask", "uint");
            return type;
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
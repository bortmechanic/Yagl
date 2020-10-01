/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System;
using System.Linq;
using System.Text;
using Yagl.GL.Generator.Spec;
using Yagl.GL.Generator.Utilities;

namespace Yagl.GL.Generator.Bindings
{
    public static class Commands
    {
        public static void ProcessCommand(StringBuilder file, string name, Specification spec)
        {
            var command = spec.Commands
                .FirstOrDefault(c => c.Name == name);
            
            if (command == null)
            {
                Log.Error($"Couldn't process command '{name}'.");
                return;
            }

            name = GetCommandName(command);
            var type = GetCommandType(command);
            var parameters = command.Params.Select(GetParamDeclaration).ToArray();
            var declaration = $"        public static /*{type.Item1}*/ {type.Item2} {name}({string.Join(", ", parameters.Select(p => $"/*{p.Item1}*/ {p.Item2} {p.Item3}"))}) => {name}Ptr?.Invoke({string.Join(", ", parameters.Select(p => $"{(p.Item2.StartsWith("ref ") ? "ref " : "")}{p.Item3}"))}){(type.Item2 != "void" ? " ?? default" : "")}; delegate /*{type.Item1}*/ {type.Item2} {name}Del({string.Join(", ", parameters.Select(p => $"/*{p.Item1}*/ {p.Item2} {p.Item3}"))}); static {name}Del {name}Ptr;";
            file.AppendLine(declaration);

            if (!parameters.Any(p => p.Item2.Contains("[]"))) return;
            var unsafeDeclaration = $"        public static unsafe /*{type.Item1}*/ {type.Item2} {name}({string.Join(", ", parameters.Select(p => $"/*{p.Item1}*/ {p.Item2.Replace("[]", "*")} {p.Item3}"))}) => {name}UnsafePtr?.Invoke({string.Join(", ", parameters.Select(p => $"{(p.Item2.StartsWith("ref ") ? "ref " : "")}{p.Item3}"))}){(type.Item2 != "void" ? " ?? default" : "")}; unsafe delegate /*{type.Item1}*/ {type.Item2} {name}UnsafeDel({string.Join(", ", parameters.Select(p => $"/*{p.Item1}*/ {p.Item2.Replace("[]", "*")} {p.Item3}"))}); static {name}UnsafeDel {name}UnsafePtr;";
            file.AppendLine(unsafeDeclaration);
        }

        private static string GetCommandName(Command command)
        {
            return RemoveGlPrefix(command.Name);
        }

        private static Tuple<string, string> GetCommandType(Command command)
        {
            var typeDeclaration = command.Proto.Replace(command.Name, "").Trim();
            typeDeclaration = ProcessTypeDeclaration(typeDeclaration);
            var type = TypeMapper.GetType(typeDeclaration);
            return new Tuple<string, string>(typeDeclaration, type.Type);
        }

        private static string ProcessTypeDeclaration(string typeDeclaration)
        {
            if (typeDeclaration == "void")
                typeDeclaration = "GLvoid";
            return typeDeclaration;
        }
        
        private static string RemoveGlPrefix(string name)
        {
            if (name.StartsWith("gl") && (name[2] < '0' || name[2] > '9'))
                name = name.Substring(2);
            return name;
        }
        
        private static Tuple<string, string, string> GetParamDeclaration(Param param)
        {
            var typeDeclaration = param.Declaration
                .Substring(0, param.Declaration.Length - param.Name.Length).Trim();
            var type = TypeMapper.GetType(PreprocessParamDeclaration(typeDeclaration));
            var name = NormalizeParamName(param.Name);
            return new Tuple<string, string, string>(typeDeclaration, type.Type, name);
        }

        private static string PreprocessParamDeclaration(string declaration)
        {
            return declaration;
        }

        private static string NormalizeParamName(string name)
        {
            if (name == "params")
                return "parameters";
            if (name == "ref")
                return "reference";
            if (name == "base")
                return "basis";
            return name;
        }

        public static void ProcessLoader(StringBuilder file, string originalName, Specification spec)
        {
            var command = spec.Commands.FirstOrDefault(c => c.Name == originalName);
            var name = GetCommandName(command);
            file.AppendLine($"            {name}Ptr = LoadProcByName<{name}Del>(\"{originalName}\", getProcAddress);");
            var parameters = command?.Params.Select(GetParamDeclaration).ToArray();
            if (!parameters?.Any(p => p.Item2.Contains("[]")) == true) return;
            file.AppendLine($"            {name}UnsafePtr = LoadProcByName<{name}UnsafeDel>(\"{name}\", getProcAddress);");
        }
    }
}
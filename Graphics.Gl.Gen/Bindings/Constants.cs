/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System;
using System.Linq;
using System.Text;
using Yagl.Gl.Generator.Spec;
using Yagl.Gl.Generator.Utilities;

namespace Yagl.Gl.Generator.Bindings
{
    public static class Constants
    {
        public static void ProcessEnum(StringBuilder file, string name, Specification spec)
        {
            var constant = spec.Enums.SelectMany(e => e)
                .FirstOrDefault(ei => ei.Name == name);
            
            if (constant == null)
            {
                Log.Error($"Couldn't process enum '{name}'.");
                return;
            }

            PreProcessConstant(constant);

            var type = GetConstantType(constant);
            name = RemoveGlPrefix(constant.Name);

            file.AppendLine($"        public const {type} {name} = {constant.Value};");
        }

        private static string GetConstantType(EnumItem constant)
        {
            var type = constant.Type;
            if (string.IsNullOrWhiteSpace(type))
                type = constant.Enum.Type;
            if (string.IsNullOrWhiteSpace(type))
                type = TryDetermineType(constant);
            var mt = TypeMapper.GetType(type);
            return $"/*{mt.Name}*/ {mt.Type}";
        }
        
        private static string TryDetermineType(EnumItem constant)
        {
            // if (string.IsNullOrWhiteSpace(value)) return "";
            // if (ULongValueRegex.IsMatch(value)) return "Glulong";
            // if (UIntValueRegex.IsMatch(value)) return "Gluint";
            // if (UShortValueRegex.IsMatch(value)) return "Glushort";
            // if (UByteValueRegex.IsMatch(value)) return "Glubyte";
            return "GLenum";
        }
        // private static readonly Regex ULongValueRegex = new Regex(@"^0x[0-9a-fA-F]{16}$");
        // private static readonly Regex UIntValueRegex = new Regex(@"^0x[0-9a-fA-F]{8}$");
        // private static readonly Regex UShortValueRegex = new Regex(@"^0x[0-9a-fA-F]{4}$");
        // private static readonly Regex UByteValueRegex = new Regex(@"^0x[0-9a-fA-F]{2}$");

        private static string RemoveGlPrefix(string name)
        {
            if (name.StartsWith("GL_") && (name[3] < '0' || name[3] > '9'))
                name = name.Substring(3);
            return name;
        }

        private static void PreProcessConstant(EnumItem constant)
        {
            if (new[] {"GL_TRUE", "GL_FALSE"}.Contains(constant.Name))
                constant.Type = "GLubyte";
        }
    }
}
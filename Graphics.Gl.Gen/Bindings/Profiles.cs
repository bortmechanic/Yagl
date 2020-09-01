/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Yagl.Gl.Generator.Spec;
using Yagl.Gl.Generator.Utilities;

namespace Yagl.Gl.Generator.Bindings
{
    public class Profiles : List<ProfileMembers>
    {
        public static void Process(Specification spec)
        {
            foreach (var feature in spec.Features.Take(1))
            {
                ProcessFeature(feature, spec);
            }
        }

        private static void ProcessFeature(Feature feature, Specification spec)
        {
            var version = $"{(feature.Name.StartsWith("GL_ES") ? "ES." : feature.Name.StartsWith("GL_SC") ? "SC." : "")}{feature.Number}";
            var filename = $"Gl.{version}.cs";
            Log.Info($"Processing {filename}");
            var file = new StringBuilder();
            
            file.AppendLine("/*");
            file.AppendLine(" This source file is a part of the project YAGL.");
            file.AppendLine(" Copyright (c) 2020 Pavel Melnikov.");
            file.AppendLine(" Distributed under the MIT License (http://opensource.org/licenses/MIT).");
            file.AppendLine(" See LICENSE.txt for the full license text.");
            file.AppendLine("*/");
            file.AppendLine();
            
            file.AppendLine("// ReSharper disable UnusedMember.Global");
            file.AppendLine("// ReSharper disable InconsistentNaming");
            file.AppendLine("// ReSharper disable IdentifierTypo");
            file.AppendLine("// ReSharper disable StringLiteralTypo");
            file.AppendLine("// ReSharper disable ArrangeTypeMemberModifiers");
            file.AppendLine("// ReSharper disable ConstantNullCoalescingCondition");
            file.AppendLine();

            file.AppendLine("using System;");
            file.AppendLine();
            
            file.AppendLine("namespace Yagl.Graphics");
            file.AppendLine("{");
            file.AppendLine("    public static partial class Gl");
            file.AppendLine("    {");
            file.AppendLine();
            foreach (var require in feature.Requires)
            {
                ProcessRequire(file, require, spec);
            }
            file.AppendLine();
            
            file.AppendLine($"        private static void Init_GL_{version.Replace(".", "_")}(Func<string,IntPtr> getProcAddress)");
            file.AppendLine("        {");
            foreach (var require in feature.Requires)
            {
                ProcessLoaders(file, require, spec);
            }
            file.AppendLine("        }");
            file.AppendLine();

            file.AppendLine("    }");
            file.AppendLine("}");
            
            File.WriteAllText($"../../../../Graphics.Gl/{filename}", file.ToString());
            Log.Info($"DONE {filename}");
        }

        public static void ProcessRequire(StringBuilder file, Require require, Specification spec)
        {
            var types = require.Where(r => r.Type == RequireItemType.Type).ToArray();
            foreach (var item in types)
                ProcessType(file, item.Name, spec);
            if (types.Any())
                file.AppendLine();
            
            var enums = require.Where(r => r.Type == RequireItemType.Enum).ToArray();
            foreach (var item in enums)
                Constants.ProcessEnum(file, item.Name, spec);
            if (enums.Any())
                file.AppendLine();

            var commands = require.Where(r => r.Type == RequireItemType.Command).ToArray();
            foreach (var item in commands)
                Commands.ProcessCommand(file, item.Name, spec);
        }

        private static void ProcessType(StringBuilder file, string name, Specification spec)
        {
            var type = spec.Types.FirstOrDefault(t => t.Name == name);
            if (type == null)
            {
                Log.Error($"Couldn't process type '{name}'.");
                return;
            }

            file.AppendLine($"        // {type.Declaration}");
        }
        
        private static void ProcessLoaders(StringBuilder file, Require require, Specification spec)
        {
            var commands = require.Where(r => r.Type == RequireItemType.Command).ToArray();
            foreach (var item in commands)
                Commands.ProcessLoader(file, item.Name, spec);
        }
    }
}
/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Yagl.GL.Generator.Utilities;

namespace Yagl.GL.Generator.Spec
{
    public class Command
    {
        public string Proto { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Group { get; set; }
        public string Comment { get; set; }
        public string Alias { get; set; }
        public string VecEquiv { get; set; }
        public Glx Glx { get; set; }
        
        public List<Param> Params { get; set; } = new List<Param>();

        public void Parse(XElement element)
        {
            Name = element.Element("proto")?.Element("name")?.Value.Trim();
            Type = element.Element("proto")?.Element("ptype")?.Value.Trim();
            Group = element.Element("proto")?.Attribute("group")?.Value.Trim();
            element.Element("proto")?.Attribute("group")?.Remove();
            Proto = element.Element("proto")?.ToString(SaveOptions.DisableFormatting)
                .Replace("<proto>", "").Replace("</proto>", "")
                .Replace("<ptype>", "").Replace("</ptype>", " ")
                .Replace("<name>", "").Replace("</name>", "")
                .RemoveDuplicatedWhitespaces()
                .Trim();
            Comment = element.Attribute("comment")?.Value;
            Alias = element.Element("alias")?.Value;
            VecEquiv = element.Element("vecequiv")?.Value;
            Glx = Glx.Parse(element.Element("glx"));

            foreach (var el in element.Elements("param"))
                Params.Add(Param.Parse(el));

            Log.Debug($"  {Proto}({string.Join(", ", Params.Select(p => p.Declaration))});");
        }

        
    }
}
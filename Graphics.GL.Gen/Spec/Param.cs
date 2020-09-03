/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System.Xml.Linq;
using Yagl.GL.Generator.Utilities;

namespace Yagl.GL.Generator.Spec
{
    public class Param
    {
        public string Declaration { get; set; }
        public string Group { get; set; }
        public string Len { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        
        public static Param Parse(XElement element)
        {
            var param = new Param();
            param.Group = element.Attribute("group")?.Value.Trim();
            param.Len = element.Attribute("len")?.Value.Trim();
            param.Type = element.Element("ptype")?.Value.Trim();
            param.Name = element.Element("name")?.Value.Trim();
            element.Attribute("group")?.Remove();
            element.Attribute("len")?.Remove();
            param.Declaration = element.ToString(SaveOptions.DisableFormatting)
                .Replace("<param>", "").Replace("</param>", "")
                .Replace("<ptype>", "").Replace("</ptype>", " ")
                .Replace("<name>", "").Replace("</name>", "")
                .RemoveDuplicatedWhitespaces()
                .Trim();
            return param;
        }
    }
}
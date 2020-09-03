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
    public class Type
    {
        public string Name { get; set; }
        public string Declaration { get; set; }
        public string Requires { get; set; }
        public string Comment { get; set; }
        public string Api { get; set; }

        public static Type Parse(XElement element)
        {
            var type = new Type();
            type.Name = $"{element.Attribute("name")?.Value}{element.Element("name")?.Value}";
            type.Declaration = element.Value;
            type.Requires = element.Attribute("requires")?.Value;
            type.Comment = element.Attribute("comment")?.Value;
            type.Api = element.Attribute("api")?.Value;
            Log.Debug($"  {(!string.IsNullOrWhiteSpace(type.Api) ? type.Api + "." : "")}{(!string.IsNullOrWhiteSpace(type.Name) ? type.Name : "<none>")} | {type.Declaration}{(!string.IsNullOrWhiteSpace(type.Requires) ? " | Requires: " + type.Requires : "")}{(!string.IsNullOrWhiteSpace(type.Comment) ? " // " + type.Comment : "")}");
            return type;
        }
    }
}
/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System.Xml.Linq;
using Yagl.Gl.Generator.Utilities;

namespace Yagl.Gl.Generator.Spec
{
    public class EnumItem
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public string Api { get; set; }
        public string Alias { get; set; }
        public string Comment { get; set; }
        public string Group { get; set; }

        public static EnumItem Parse(XElement element)
        {
            var item = new EnumItem();
            item.Name = element.Attribute("name")?.Value;
            item.Type = element.Attribute("type")?.Value;
            item.Value = element.Attribute("value")?.Value;
            item.Api = element.Attribute("api")?.Value;
            item.Alias = element.Attribute("alias")?.Value;
            item.Comment = element.Attribute("comment")?.Value;
            item.Group = element.Attribute("group")?.Value;
            Log.Info($"    {item.Name ?? "<none>"}{(!string.IsNullOrWhiteSpace(item.Type) ? "[" + item.Type + "]" : "")} = {item.Value}; // Group: {item.Group ?? "<none>"}. {(!string.IsNullOrWhiteSpace(item.Api) ? "API: " + item.Api + ". " : "")}{item.Comment}{(!string.IsNullOrWhiteSpace(item.Alias) ? "Alias of " + item.Alias : "")}");
            return item;
        }
    }
}
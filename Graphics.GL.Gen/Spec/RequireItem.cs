/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable MemberCanBePrivate.Global

using System.Xml.Linq;
using Yagl.GL.Generator.Utilities;

namespace Yagl.GL.Generator.Spec
{
    public class RequireItem
    {
        public RequireItemType Type { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }

        public static RequireItem Parse(XElement element)
        {
            var item = new RequireItem();
            if (element.Name == "type")
                item.Type = RequireItemType.Type;
            else if (element.Name == "enum")
                item.Type = RequireItemType.Enum;
            else if (element.Name == "command")
                item.Type = RequireItemType.Command;
            else
                Log.Error($"Couldn't parse element '{element.Name}'.");
            
            item.Name = element.Attribute("name")?.Value;
            item.Comment = element.Attribute("comment")?.Value;
            
            Log.Debug($"      {item.Type.ToString().ToUpper()} | {item.Name ?? "<none>"} {(!string.IsNullOrWhiteSpace(item.Comment) ? "// " + item.Comment : "")}");
            return item;
        }
    }
}
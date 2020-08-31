/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable MemberCanBePrivate.Global

using System.Xml.Linq;
using Yagl.Gl.Generator.Utilities;

namespace Yagl.Gl.Generator.Spec
{
    public class FeatureItem
    {
        public FeatureItemType Type { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }

        public static FeatureItem Parse(XElement element)
        {
            var item = new FeatureItem();
            if (element.Name == "type")
                item.Type = FeatureItemType.Type;
            else if (element.Name == "enum")
                item.Type = FeatureItemType.Enum;
            else if (element.Name == "command")
                item.Type = FeatureItemType.Command;
            else
                Log.Error($"Couldn't parse element '{element.Name}'.");
            
            item.Name = element.Attribute("name")?.Value;
            item.Comment = element.Attribute("comment")?.Value;
            
            Log.Debug($"      {item.Type.ToString().ToUpper()} | {item.Name ?? "<none>"} {(!string.IsNullOrWhiteSpace(item.Comment) ? "// " + item.Comment : "")}");
            return item;
        }
    }
}
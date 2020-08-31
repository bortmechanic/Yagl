/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

using System.Collections.Generic;
using System.Xml.Linq;
using Yagl.Gl.Generator.Utilities;

namespace Yagl.Gl.Generator.Spec
{
    public class Enum : List<EnumItem>
    {
        public string Group { get; set; }
        public string Namespace { get; set; }
        public string Type { get; set; }
        public string Vendor { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Comment { get; set; }

        public void Parse(XElement element)
        {
            Group = element.Attribute("group")?.Value;
            Namespace = element.Attribute("namespace")?.Value;
            Type = element.Attribute("type")?.Value;
            Vendor = element.Attribute("vendor")?.Value;
            Comment = element.Attribute("comment")?.Value;
            Start = element.Attribute("start")?.Value;
            End = element.Attribute("end")?.Value;
            Log.Debug($"  {Namespace ?? "<none>"} | {Group ?? "<none>"} | {Type ?? "<none>"} | Vendor: {Vendor ?? "ALL"} {(!string.IsNullOrWhiteSpace(Comment) ? " // " + Comment : "")}");
            
            foreach (var el in element.Elements())
            {
                if (el.Name == "enum")
                {
                    var item = EnumItem.Parse(el, this);
                    if (item != null)
                        Add(item);
                }
                else if (el.Name == "unused")
                {
                    // skip 'unused' element(s).
                }
                else
                    Log.Error($"  Couldn't parse element '{el.Name}'.");
            }
            Log.Debug();
        }
    }
}
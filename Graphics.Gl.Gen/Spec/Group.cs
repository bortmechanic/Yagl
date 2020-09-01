/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System.Collections.Generic;
using System.Xml.Linq;
using Yagl.Gl.Generator.Utilities;

namespace Yagl.Gl.Generator.Spec
{
    public class Group : List<GroupItem>
    {
        public string Name { get; set; }
        public string Comment { get; set; }

        public void Parse(XElement element)
        {
            Name = element.Attribute("name")?.Value;
            Comment = element.Attribute("comment")?.Value;
            Log.Debug($"  {Name} // {Comment}");
            foreach (var el in element.Elements())
            {
                if (el.Name == "enum")
                {
                    var item = GroupItem.Parse(el);
                    if (item != null)
                        Add(item);
                }
                else
                    Log.Error($"  Couldn't parse element '{el.Name}'.");
            }
            Log.Debug();
        }
    }
}
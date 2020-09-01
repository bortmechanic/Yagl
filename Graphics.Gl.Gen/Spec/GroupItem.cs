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
    public class GroupItem
    {
        public string Name { get; set; }
        public string Comment { get; set; }

        public static GroupItem Parse(XElement element)
        {
            var item = new GroupItem();
            item.Name = element.Attribute("name")?.Value;
            item.Comment = element.Attribute("comment")?.Value;
            Log.Debug($"    {item.Name ?? "<none>"}");
            return item;
        }
    }
}
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
    public class Type
    {
        public string Name { get; set; }
        public string Declaration { get; set; }
        public string Requires { get; set; }

        public static Type Parse(XElement element)
        {
            var type = new Type();
            type.Name = element.Element("name")?.Value;
            type.Declaration = element.Value;
            type.Requires = element.Attribute("requires")?.Value;
            Log.Debug($"  {type.Name ?? "<none>"} | {type.Declaration} | Requires: {type.Requires}");
            return type;
        }
    }
}
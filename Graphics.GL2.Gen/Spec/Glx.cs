/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

using System.Xml.Linq;

namespace Yagl.Gl.Generator.Spec
{
    public class Glx
    {
        public string Type { get; private set; }
        public string OpCode { get; private set; }
        public string Name { get; private set; }
        public string Comment { get; private set; }

        public static Glx Parse(XElement element)
        {
            if (element == null) return null;
            var glx = new Glx();
            glx.Type = element.Attribute("type")?.Value.Trim();
            glx.OpCode = element.Attribute("opcode")?.Value.Trim();
            glx.Name = element.Attribute("name")?.Value.Trim();
            glx.Comment = element.Attribute("comment")?.Value.Trim();
            return glx;
        }
    }
}
/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable CollectionNeverQueried.Global

using System.Xml.Linq;
using Yagl.Gl.Generator.Utilities;

namespace Yagl.Gl.Generator.Spec
{
    public class Extension
    {
        public string Name { get; set; }
        public string Supported { get; set; }
        public string Protect { get; set; }
        public string Comment { get; set; }
        
        public Requires Requires { get; set; } = new Requires();

        public void Parse(XElement element)
        {
            Name = element.Attribute("name")?.Value.Trim();
            Supported = element.Attribute("supported")?.Value.Trim();
            Protect = element.Attribute("protect")?.Value.Trim();
            Comment = element.Attribute("comment")?.Value.Trim();
            Log.Info($"  {Name}{(!string.IsNullOrWhiteSpace(Supported) ? " | Supported: " + Supported : "")}{(!string.IsNullOrWhiteSpace(Protect) ? " | Protect: " + Protect : "")}{(!string.IsNullOrWhiteSpace(Comment) ? " // " + Comment : "")}");

            foreach (var el in element.Elements())
            {
                var require = Require.Parse(el);
                if (require.Type == RequireType.Remove)
                    Log.Error("      Remove element found in extension.");
                Requires.Add(require);
            }

            Log.Info("  DONE.");
            Log.Info();
        }

        
    }
}
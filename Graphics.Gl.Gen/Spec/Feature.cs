/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

using System.Xml.Linq;
using Yagl.Gl.Generator.Utilities;
// ReSharper disable CollectionNeverQueried.Global

namespace Yagl.Gl.Generator.Spec
{
    public class Feature
    {
        public string Api { get; set; }
        public string Name { get; set; }
        public string Protect { get; set; }
        public string Number { get; set; }
        public string Comment { get; set; }
        
        public FeatureRequires Requires { get; set; } = new FeatureRequires();

        public void Parse(XElement element)
        {
            Api = element.Attribute("api")?.Value.Trim();
            Name = element.Attribute("name")?.Value.Trim();
            Protect = element.Attribute("protect")?.Value.Trim();
            Number = element.Attribute("number")?.Value.Trim();
            Comment = element.Attribute("comment")?.Value.Trim();
            Log.Info($"  {Api} | {Name} | {Number}{(!string.IsNullOrWhiteSpace(Comment) ? " // " + Comment : "")}");

            foreach (var el in element.Elements())
                Requires.Add(FeatureRequire.Parse(el));
            
            Log.Info("  DONE.");
            Log.Info();
        }

        
    }
}
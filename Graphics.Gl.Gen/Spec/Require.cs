/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable MemberCanBePrivate.Global

using System.Collections.Generic;
using System.Xml.Linq;
using Yagl.Gl.Generator.Utilities;

namespace Yagl.Gl.Generator.Spec
{
    public class Require : List<FeatureItem>
    {
        public string Profile { get; set; }
        public RequireType Type { get; set; }
        
        public static Require Parse(XElement element)
        {
            var require = new Require();
            require.Profile = element.Attribute("profile")?.Value.Trim();
            if (element.Name == "require")
                require.Type = RequireType.Require;
            else if (element.Name == "remove")
                require.Type = RequireType.Remove;

            Log.Info($"    {require.Type.ToString().ToUpper()}.{(!string.IsNullOrWhiteSpace(require.Profile) ? " Profile: " + require.Profile : "")}");
            
            if (require.Type == RequireType.Require || require.Type == RequireType.Remove)
                foreach (var el in element.Elements())
                    require.Add(FeatureItem.Parse(el));
            else
                Log.Error($"    Couldn't parse element {element.Name}.");

            Log.Info($"    DONE.");
            return require;
        }
    }
}
/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System.Collections.Generic;
using System.Xml.Linq;
using Yagl.GL.Generator.Utilities;

namespace Yagl.GL.Generator.Spec
{
    public class Features : List<Feature>
    {

        public void Parse(XElement element)
        {
            Log.Info("FEATURES.");
            Log.Info();

            foreach (var el in element.Elements())
            {
                if (el.Name == "feature")
                {
                    var feature = new Feature();
                    feature.Parse(el);
                    Add(feature);
                }
                else
                    Log.Error($"  Couldn't parse element '{el.Name}'.");
            }
            
            Log.Info("DONE.");
            Log.Info();
        }
    }
}
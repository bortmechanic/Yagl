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
    public class Types : List<Type>
    {
        public void Parse(XElement element)
        {
            Log.Info("TYPES.");

            foreach (var el in element.Elements())
            {
                if (el.Name == "type")
                {
                    var type = Type.Parse(el);
                    if (type != null)
                        Add(type);
                }
                else
                    Log.Error($"  Couldn't parse element '{el.Name}'.");
            }
            
            Log.Info("DONE.");
            Log.Info();
        }
    }
}
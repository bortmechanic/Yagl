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
    public class Extensions : List<Extension>
    {

        public void Parse(XElement element)
        {
            Log.Info("EXTENSIONS.");
            Log.Info();

            foreach (var el in element.Elements())
            {
                if (el.Name == "extension")
                {
                    var extension = new Extension();
                    extension.Parse(el);
                    Add(extension);
                }
                else
                    Log.Error($"  Couldn't parse element '{el.Name}'.");
                    
            }
            
            Log.Info("DONE.");
            Log.Info();
        }
    }
}
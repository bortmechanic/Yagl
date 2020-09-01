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
    public class Commands : List<Command>
    {
        public string Namespace { get; set; }
        
        public void Parse(XElement element)
        {
            Namespace= element.Attribute("namespace")?.Value.Trim();
            
            Log.Info($"COMMANDS {Namespace}.");

            foreach (var el in element.Elements())
            {
                if (el.Name == "command")
                {
                    var command = new Command();
                    command.Parse(el);
                    Add(command);
                }
                else
                    Log.Error($"  Couldn't parse element '{el.Name}'.");
            }
            
            Log.Info("DONE.");
            Log.Info();
        }
    }
}
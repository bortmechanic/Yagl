/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

using System;
using System.Xml.Linq;
using Yagl.Gl.Generator.Utilities;

namespace Yagl.Gl.Generator.Spec
{
    public class Specification
    {
        public Comments Comments { get; } = new Comments();
        public Types Types { get; } = new Types();
        public Groups Groups { get; } = new Groups();

        public static Specification Parse(string filename)
        {
            Log.Info("Loading Specification.");
            var xml = XDocument.Load(filename);
            Log.Info("DONE.");
            Log.Info();
            
            var spec = new Specification();
            
            if (xml.Root == null)
                throw new InvalidOperationException();
            
            foreach (var element in xml.Root.Elements())
            {
                switch (element.Name.LocalName)
                {
                    case "comment":
                        spec.Comments.Parse(element);
                        break;
                    case "types":
                        spec.Types.Parse(element);
                        break;
                    case "groups":
                        spec.Groups.Parse(element);
                        break;
                    default:
                        Log.Error($"'{element.Name}' section couldn't be parsed.");
                        break;
                }
            }

            return spec;
        }
    }
}
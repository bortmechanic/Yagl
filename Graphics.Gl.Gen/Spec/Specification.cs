/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

using System;
using System.Linq;
using System.Xml.Linq;
using Yagl.Gl.Generator.Utilities;

namespace Yagl.Gl.Generator.Spec
{
    public class Specification
    {
        public Comments Comments { get; } = new Comments();
        public Types Types { get; } = new Types();
        public Groups Groups { get; } = new Groups();
        public Enums Enums { get; } = new Enums();
        public Commands Commands { get; } = new Commands();
        public Features Features { get; } = new Features();

        public static Specification Parse(string filename)
        {
            Log.Info("Loading Specification.");
            var xml = XDocument.Load(filename);
            Log.Info("DONE.");
            Log.Info();
            
            var spec = new Specification();
            
            if (xml.Root == null)
                throw new InvalidOperationException();
            var registry = OrganizeXml(xml.Root);
            
            foreach (var element in registry.Elements())
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
                    case "enumgroups":
                        spec.Enums.Parse(element);
                        break;
                    case "commands":
                        spec.Commands.Parse(element);
                        break;
                    case "features":
                        spec.Features.Parse(element);
                        break;
                    default:
                        Log.Error($"'{element.Name}' section couldn't be parsed.");
                        break;
                }
            }

            return spec;
        }

        private static XElement OrganizeXml(XElement registry)
        {
            var enumGroups = new XElement("enumgroups");
            registry.Add(enumGroups);
            foreach (var enums in registry.Elements("enums").ToArray())
            {
                enums.Remove();
                enumGroups.Add(enums);
            }
            foreach (var commands in registry.Elements("commands").ToArray())
            {
                commands.Remove();
                registry.Add(commands);
            }
            var features = new XElement("features");
            registry.Add(features);
            foreach (var feature in registry.Elements("feature").ToArray())
            {
                feature.Remove();
                features.Add(feature);
            }
            foreach (var extensions in registry.Elements("extensions").ToArray())
            {
                extensions.Remove();
                registry.Add(extensions);
            }
            return registry;
        }
    }
}
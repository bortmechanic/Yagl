/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System.Linq;
using Yagl.Gl.Generator.Spec;

namespace Yagl.Gl.Generator.Bindings
{
    public static class PreProcessing
    {
        private static Spec.Commands Commands;
        public static void PreprocessCommands(Spec.Commands commands)
        {
            Commands = commands;
            
            var getString = Get("glGetString");
            getString.Type = getString.Type.Replace("GLubyte", "GLchar");
            getString.Proto = getString.Proto.Replace("GLubyte", "GLchar");
        }
        
        private static Command Get(string name) => Commands.FirstOrDefault(c => c.Name == name);
    }
}
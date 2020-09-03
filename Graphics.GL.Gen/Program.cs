/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System;
using System.IO;
using Yagl.GL.Generator.Bindings;
using Yagl.GL.Generator.Spec;
using Yagl.GL.Generator.Utilities;

namespace Yagl.GL.Generator
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("YAGL OpenGL Bindings Generator.");
            Console.WriteLine("Copyright (c) 2020 Pavel Melnikov.");
            Console.WriteLine();
            Log.SetVerbosity(true);

            const string filename = @"../../../../Specs/gl.xml";
            if (!File.Exists(filename))
            {
                Log.Error("File 'gl.xml' couldn't be found. ");
                Log.Info("OpenGL specification is not distributed with YAGL.");
                Log.Info("To avoid this error pls download OpenGL specification (file 'gl.xml')");
                Log.Info("from the Khronos public registry and place to the Specs folder inside the Solution folder.");
                return;
            }

            var spec = Specification.Parse(filename);
            Log.Info("Specification parsing COMPLETED.");

            PreProcessing.PreprocessCommands(spec.Commands);
            
            TypeMapper.Init();
            TypeMapper.Check(spec);
            
            Profiles.Process(spec);
        }
        
    }
}
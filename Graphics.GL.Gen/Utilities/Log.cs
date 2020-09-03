/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System;

namespace Yagl.GL.Generator.Utilities
{
    public static class Log
    {
        private static bool _verbose;
        
        public static void SetVerbosity(bool verbose)
        {
            _verbose = verbose;
        }
        
        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
        }
        
        public static void Info(string message = null)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(message);
        }
        
        public static void Debug(string message = null)
        {
            if (!_verbose) return;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(message);
        }
    }
}
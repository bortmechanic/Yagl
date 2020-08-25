/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable UnusedMember.Global

using System.Collections.Generic;
using System.Linq;

namespace Yagl.Graphics.Imaging
{
    public static class FormatRegistry
    {
        private static readonly List<IFormat> Formats = new List<IFormat>();
        
        public static void Register(IFormat format)
        {
            Formats.Add(format);
        }

        public static void Clear()
        {
            Formats.Clear();
        }
        
        internal static IFormat FindFormat(string filename)
        {
            return Formats.FirstOrDefault(f => f.CanProcess(filename));
        }
    }
}
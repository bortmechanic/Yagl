/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Yagl.Graphics.Imaging
{
    public static class ImageFormats
    {
        private static readonly List<IImageFormat> Formats = new List<IImageFormat>();
        
        public static void Register(IImageFormat format)
        {
            Formats.Add(format);
        }

        public static Image Load(string filename)
        {
            var format = Formats.FirstOrDefault(f => f.CanLoad(filename));
            if (format == null)
                throw new NotSupportedException($"Image format of the file '{filename}' is not supported.");
            using (var stream = File.OpenRead(filename))
                return format.Load(stream);
        }
        
        
    }
}
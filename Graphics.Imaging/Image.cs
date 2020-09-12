/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable UnusedMember.Global

using System;
using System.IO;

namespace Yagl.Graphics.Imaging
{
    public class Image
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public PixelFormatDescriptor PixelFormatDescriptor { get; set; }
        public byte[] Data { get; set; }

        public static Image Load(string filename)
        {
            var format = FormatRegistry.FindFormat(filename);
            if (format == null)
                throw new NotSupportedException($"Image format of the file '{filename}' is not supported.");
            using var stream = File.OpenRead(filename);
            return format.Load(stream);
        }

        public void Save(string filename)
        {
            var format = FormatRegistry.FindFormat(filename);
            if (format == null)
                throw new NotSupportedException($"No suitable encoder found to save the image '{filename}'.");
            using var stream = File.OpenWrite(filename);
            format.Save(this, stream);
        }
    }
}
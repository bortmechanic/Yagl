/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable UnusedMember.Global

namespace Yagl.Graphics.Imaging
{
    public class Image
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public PixelFormatDescriptor PixelFormatDescriptor { get; set; }
        public byte[] BitMap { get; set; }

        public static Image Load(string filename)
        {
            return ImageFormats.Load(filename);
        }

        public void Save(string filename, bool allowAdaptation)
        {
            ImageFormats.Save(this, filename, allowAdaptation);
        }
    }
}
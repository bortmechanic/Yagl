/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedType.Global

using System;
using System.Globalization;
using System.IO;

namespace Yagl.Graphics.Imaging.Formats
{
    public class Bmp : IFormat
    {
        private class Color
        {
            public byte Red;
            public byte Green;
            public byte Blue;
            public byte Reserved;
        }

        public bool CanProcess(string filename)
        {
            if (filename?.EndsWith(".bmp", true, CultureInfo.InvariantCulture) == true)
                return true;
            return false;
        }

        public Image Load(Stream stream)
        {
            var reader = new BinaryReader(stream);
                                                                
            // Bitmap File Header.
            var signature = reader.ReadUInt16();         // BMP file signature. Must be 'BM'.
            if (signature != 0x4D42)
                throw new BadImageFormatException();
            /*var fileSize =*/ reader.ReadUInt32();             // File size in bytes.
            /*var reserved =*/ reader.ReadUInt32();             // Unused (=0).
            /*var dataOffset =*/ reader.ReadUInt32();           // Offset from beginning of file to the beginning of the bitmap data.
                                                            
            // Bitmap Info Header.
            var headerSize = reader.ReadUInt32();          // Size of InfoHeader =40.
            if (headerSize != 40)
                throw new BadImageFormatException();
            var width = reader.ReadUInt32();               // Horizontal width of bitmap in pixels.
            var height = reader.ReadUInt32();              // Vertical height of bitmap in pixels.
            /*var planes =*/ reader.ReadUInt16();               // Number of Planes (=1).
            var bitsPerPixel = reader.ReadUInt16();      // Bits per Pixel used to store pixel color.
            /*var compression =*/ reader.ReadUInt32();          // Type of Compression.
            /*var compressedImageSize =*/ reader.ReadUInt32();  // (compressed) Size of Image. It is valid to set this =0 if Compression = 0.
            /*var xPixelsPerM =*/ reader.ReadUInt32();          // Horizontal resolution: Pixels/meter.
            /*var yPixelsPerM =*/ reader.ReadUInt32();          // Vertical resolution: Pixels/meter.
            var colorsUsed = reader.ReadUInt32();          // Number of actually used colors. For a 8-bit / pixel bitmap this will be 100h or 256.
            /*var importantColors =*/ reader.ReadUInt32();      // Number of important colors. 0 = all.
            if (bitsPerPixel != 24)
                throw new NotSupportedException("Only TrueColor (24 bit RGB) BMP images are supported.");
            if (colorsUsed == 0)
                colorsUsed = (uint)2 << (bitsPerPixel - 1);

            // Color Table.
            if (bitsPerPixel <= 8)
            {
                var colorTable = new Color[colorsUsed];
                for (var i = 0; i < colorsUsed; i++)
                    colorTable[i] = new Color { Red = reader.ReadByte(), Green = reader.ReadByte(), Blue = reader.ReadByte(), Reserved = reader.ReadByte() };
            }

            // Pixel Data.
            var rowSizeInBits = width * bitsPerPixel;
            var rowSize = rowSizeInBits / 8;
            if (rowSizeInBits % 8 > 0)
                rowSize++;
            if (rowSize % 4 > 0)
                rowSize += 4 - rowSize % 4;
            var pixelData = reader.ReadBytes((int)(rowSize * height));

            // Create Image based on the bitmap info.
            var image = new Image
            {
                Width = (int) width,
                Height = (int) height,
                PixelFormatDescriptor = new PixelFormatDescriptor
                {
                    Channels = new[]
                    {
                        new PixelFormatDescriptor.Channel
                            {NumberOfBits = 8, Type = PixelFormatDescriptor.ChannelType.Blue},
                        new PixelFormatDescriptor.Channel
                            {NumberOfBits = 8, Type = PixelFormatDescriptor.ChannelType.Green},
                        new PixelFormatDescriptor.Channel
                            {NumberOfBits = 8, Type = PixelFormatDescriptor.ChannelType.Red}
                    },
                    RowPadding = (int) rowSize * 8 - (int) rowSizeInBits
                },
                BitMap = pixelData
            };
            
            return image;
        }

        public void Save(Image image, Stream stream)
        {
            throw new NotSupportedException("Saving BMP images is not supported at this time.");
        }
    }
}
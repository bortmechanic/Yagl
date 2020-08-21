/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable UnusedType.Global

using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;

namespace Yagl.Graphics.Imaging
{
    public class FormatPng : IFormat
    {
        public bool CanProcess(string filename)
        {
            return filename?.EndsWith(".png", true, CultureInfo.InvariantCulture) == true;
        }

        public Image Load(Stream stream)
        {
            using var reader = new BinaryReader(stream);
            var signature = Msb(reader.ReadUInt64());    // PNG file signature.
            if (signature != 0x_8950_4E47_0D0A_1A0A)    // 137 80 78 71 13 10 26 10.
                throw new BadImageFormatException();
            
            using var compressedData = new MemoryStream();

            uint width = 0;
            uint height = 0;
            byte bitDepth = 0;
            byte colorType = 0;
            var endOfFile = false;
            while (!endOfFile)
            {
                try
                {
                    var length = Msb(reader.ReadUInt32());  // Number of bytes in the chunk’s data field.
                    var type = Msb(reader.ReadUInt32());  // Chunk type code.
                    
                    switch (type)
                    {
                        // IHDR
                        case 0x49484452:
                            ReadHeader(reader, out width, out height, out bitDepth, out colorType);
                            break;
                        // IDAT
                        case 0x49444154:
                            compressedData.Write(reader.ReadBytes((int) length), 0, (int)length);
                            break;
                        // IEND
                        case 0x49454E44:
                            endOfFile = true;
                            break;
                        // Unknown
                        default:
                            reader.ReadBytes((int) length);
                            break;
                    }

                    /*var crc = */ Msb(reader.ReadUInt32());  // CRC.
                    
                }
                catch (EndOfStreamException)
                {
                    throw new BadImageFormatException();
                }
            }
            
            var numberOfChannels = 1 + (colorType & 0b_0000_0010) + ((colorType & 0b_0000_0100) >> 2);
            var bitsPerChannel = bitDepth;
            var bitsPerPixel = bitsPerChannel * numberOfChannels;
            var bytesPerPixelRounded = (bitsPerPixel - 1) / 8 + 1; 
            var rowSizeBits = (int)width * bitsPerPixel;
            var rowSize = rowSizeBits / 8;
            if (rowSizeBits % 8 > 0) rowSize++;
            if (colorType == 3 || bitsPerChannel != 8)
                throw new NotSupportedException("PNG with color formats other than L8 or RGB_24 or RGBA_32 are not supported.");
            var outRowSize = rowSize % 4 > 0 ? rowSize + 4 - rowSize % 4 : rowSize;

            var bitMap = new byte[outRowSize * height];
            var rowBuffer = new byte[rowSize+1];  // +1 is for a filter byte.
            var previousRowBuffer = new byte[rowSize + 1];
            compressedData.Seek(2, SeekOrigin.Begin);  // 2 is for skipping the first two bytes of the Zlib container.
            var deflateStream = new DeflateStream(compressedData, CompressionMode.Decompress);
            for (var i = 0; i < height; i++)
            {
                var bytesRead = deflateStream.Read(rowBuffer, 0, rowSize + 1);
                if (bytesRead != rowSize + 1)
                    throw new InvalidOperationException("Can't read enough bytes.");
                var filter = rowBuffer[0];
                if (filter == 1)  // Sub.
                    ApplySubFilterDecoding(rowBuffer, bytesPerPixelRounded);
                if (filter == 2)  // Up.
                    ApplyUpFilterDecoding(rowBuffer, previousRowBuffer);
                if (filter == 3)
                    ApplyAverageFilterDecoding(rowBuffer, previousRowBuffer, bytesPerPixelRounded);
                if (filter == 4)
                    ApplyPaethFilterDecoding(rowBuffer, previousRowBuffer, bytesPerPixelRounded);
                Array.Copy(rowBuffer, 1, bitMap, (height - i - 1) * outRowSize, rowSize);
                Console.Write($"{filter.ToString()} ");
                var temp = rowBuffer;
                rowBuffer = previousRowBuffer;
                previousRowBuffer = temp;
            }

            var image = new Image
            {
                Width = (int) width,
                Height = (int) height,
                PixelFormatDescriptor = new PixelFormatDescriptor
                    {Channels = new PixelFormatDescriptor.Channel[numberOfChannels]},
                BitMap = bitMap
            };
            if (numberOfChannels == 1)
            {
                image.PixelFormatDescriptor.Channels[0] = new PixelFormatDescriptor.Channel
                    {NumberOfBits = bitsPerChannel, Type = PixelFormatDescriptor.ChannelType.Luminosity};
            }
            else if (numberOfChannels == 2)
            {
                image.PixelFormatDescriptor.Channels[0] = new PixelFormatDescriptor.Channel
                    {NumberOfBits = bitsPerChannel, Type = PixelFormatDescriptor.ChannelType.Luminosity};
                image.PixelFormatDescriptor.Channels[1] = new PixelFormatDescriptor.Channel
                    {NumberOfBits = bitsPerChannel, Type = PixelFormatDescriptor.ChannelType.Alpha};
            }
            else if (numberOfChannels == 3)
            {
                image.PixelFormatDescriptor.Channels[0] = new PixelFormatDescriptor.Channel
                    {NumberOfBits = bitsPerChannel, Type = PixelFormatDescriptor.ChannelType.Red};
                image.PixelFormatDescriptor.Channels[1] = new PixelFormatDescriptor.Channel
                    {NumberOfBits = bitsPerChannel, Type = PixelFormatDescriptor.ChannelType.Green};
                image.PixelFormatDescriptor.Channels[2] = new PixelFormatDescriptor.Channel
                    {NumberOfBits = bitsPerChannel, Type = PixelFormatDescriptor.ChannelType.Blue};
            }
            else if (numberOfChannels == 4)
            {
                image.PixelFormatDescriptor.Channels[0] = new PixelFormatDescriptor.Channel
                    {NumberOfBits = bitsPerChannel, Type = PixelFormatDescriptor.ChannelType.Red};
                image.PixelFormatDescriptor.Channels[1] = new PixelFormatDescriptor.Channel
                    {NumberOfBits = bitsPerChannel, Type = PixelFormatDescriptor.ChannelType.Green};
                image.PixelFormatDescriptor.Channels[2] = new PixelFormatDescriptor.Channel
                    {NumberOfBits = bitsPerChannel, Type = PixelFormatDescriptor.ChannelType.Blue};
                image.PixelFormatDescriptor.Channels[3] = new PixelFormatDescriptor.Channel
                    {NumberOfBits = bitsPerChannel, Type = PixelFormatDescriptor.ChannelType.Alpha};
            }

            return image;
        }

        private static void ReadHeader(BinaryReader reader, out uint width, out uint height, out byte bitDepth,
            out byte colorType)
        {
            width = Msb(reader.ReadUInt32());
            height = Msb(reader.ReadUInt32());
            bitDepth = reader.ReadByte();
            colorType = reader.ReadByte();
            var compressionMethod = reader.ReadByte();
            var filterMethod = reader.ReadByte();
            var interlaceMethod = reader.ReadByte();
            if (compressionMethod != 0)
                throw new NotSupportedException("Compression method used in this PNG file is not supported.");
            if (filterMethod != 0)
                throw new NotSupportedException("Filter method used in this PNG file is not supported.");
            if (interlaceMethod != 0)
                throw new NotSupportedException("Interlaced PNG images are not supported at this time.");
        }

        private static void ApplySubFilterDecoding(byte[] row, int bytesPerPixel)
        {
            for (var i = bytesPerPixel + 1; i < row.Length; i++)
                row[i] = (byte)(row[i] + row[i - bytesPerPixel]);
        }
        
        private static void ApplyUpFilterDecoding(byte[] curRow, byte[] prevRow)
        {
            for (var i = 1; i < curRow.Length; i++)
                curRow[i] = (byte)(curRow[i] + prevRow[i]);
        }

        private static void ApplyAverageFilterDecoding(byte[] curRow, byte[] prevRow, int bytesPerPixel)
        {
            for (var i = 1; i <= bytesPerPixel; i++)
                curRow[i] = (byte) (curRow[i] + prevRow[i] / 2);
            for (var i = bytesPerPixel + 1; i < curRow.Length; i++)
                curRow[i] = (byte) (curRow[i] + (curRow[i - bytesPerPixel] + prevRow[i]) / 2);
        }

        private static void ApplyPaethFilterDecoding(byte[] curRow, byte[] prevRow, int bytesPerPixel)
        {
            for (var i = 1; i <= bytesPerPixel; i++)
                curRow[i] = (byte)(curRow[i] + prevRow[i]);
            for (var i = bytesPerPixel + 1; i < curRow.Length; i++)
                curRow[i] = (byte)(curRow[i] + PaethPredictor(curRow[i - bytesPerPixel], prevRow[i], prevRow[i - bytesPerPixel]));
        }
        
        private static byte PaethPredictor(byte a, byte b, byte c)
        {
            var p = a + b - c;
            var pa = Math.Abs(p - a);
            var pb = Math.Abs(p - b);
            var pc = Math.Abs(p - c);
            return pa <= pb && pa <= pc ? a : pb <= pc ? b : c;
        }

        private static uint Msb(uint value)
        {
            return 
                ((value & 0x000000FF) << 24) |
                ((value & 0x0000FF00) << 8) |
                ((value & 0x00FF0000) >> 8) |
                ((value & 0xFF000000) >> 24);
        }
        
        private static ulong Msb(ulong value)
        {
            return 
                ((value & 0x_0000_0000_0000_00FF) << 56) |
                ((value & 0x_0000_0000_0000_FF00) << 40) |
                ((value & 0x_0000_0000_00FF_0000) << 24) |
                ((value & 0x_0000_0000_FF00_0000) << 8) |
                ((value & 0x_0000_00FF_0000_0000) >> 8) |
                ((value & 0x_0000_FF00_0000_0000) >> 24) |
                ((value & 0x_00FF_0000_0000_0000) >> 40) |
                ((value & 0x_FF00_0000_0000_0000) >> 56);
        }

        public void Save(Image image, Stream stream)
        {
            throw new NotSupportedException("Saving PNG images is not supported at this time.");
        }
    }
}
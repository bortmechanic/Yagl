/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable UnusedType.Global

using System.IO;

namespace Yagl.Graphics.Imaging.Formats
{
    public partial class Yaf
    {
        private struct ChannelDescription
        {
            public ushort Type;
            public ushort NumberOfBits;
        }

        private static class ImageDescChunk
        {
            public const uint Code = 0x43534449; // IDSC.
            private const ushort BaseSize = 24;
            private const ulong Reserved = 0;

            public static void Read(BinaryReader reader, out uint width, out uint height, out uint pixelFormat, out ushort numberOfChannels, out ushort rowPadding, out ChannelDescription[] channelsDescription)
            {
                width = reader.ReadUInt32(); // Image Width.
                height = reader.ReadUInt32(); // Image Height.
                pixelFormat = reader.ReadUInt32(); // Pixel Format.
                numberOfChannels = reader.ReadUInt16(); // Number of channels.
                rowPadding = reader.ReadUInt16(); // Row padding in bytes.
                channelsDescription = new ChannelDescription[numberOfChannels];
                for (var i = 0; i < numberOfChannels; i++)
                {
                    channelsDescription[i] = new ChannelDescription
                    {
                        Type = reader.ReadUInt16(),  // Channel type.
                        NumberOfBits = reader.ReadUInt16()  // Channel number of bits.
                    };
                }
                /*reserved =*/ reader.ReadUInt64(); // Reserved for future use.
            }

            public static void Write(BinaryWriter writer, uint width, uint height, uint pixelFormat,
                ushort numberOfChannels, ushort rowPadding, ChannelDescription[] channelsDescription)
            {
                writer.Write(Code); // Code.
                writer.Write(BaseSize + (numberOfChannels << 2)); // Size.
                writer.Write(width); // Image Width.
                writer.Write(height); // Image Height.
                writer.Write(pixelFormat); // Pixel Format.
                writer.Write(numberOfChannels); // Number of channels.
                writer.Write(rowPadding); // Row padding in bytes.
                foreach (var channel in channelsDescription)
                {
                    writer.Write(channel.Type);
                    writer.Write(channel.NumberOfBits);
                }
                writer.Write(Reserved); // Reserved for future use.
                writer.Write(0u); // Reserved.
            }
        }
    }
}
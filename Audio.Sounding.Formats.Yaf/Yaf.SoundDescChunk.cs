/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable UnusedType.Global

using System.IO;

namespace Yagl.Audio.Sounding.Formats
{
    public partial class Yaf
    {
        private static class SoundDescChunk
        {
            public const uint Code = 0x43534449; // IDSC.
            private const uint Size = 16;
            private const ulong Reserved = 0;

            public static void Read(BinaryReader reader, out uint sampleRate, out ushort bitsPerSample, out ushort numberOfChannels)
            {
                sampleRate = reader.ReadUInt32(); // Number of samples per second..
                bitsPerSample = reader.ReadUInt16(); // Number of bits per one sample.
                numberOfChannels = reader.ReadUInt16(); // Number of channels.
                /*reserved =*/ reader.ReadUInt64(); // Reserved for future use.
            }

            public static void Write(BinaryWriter writer, uint sampleRate, ushort bitsPerSample, ushort numberOfChannels)
            {
                writer.Write(Code); // Code.
                writer.Write(Size); // Size.
                writer.Write(sampleRate); // Number of samples per second..
                writer.Write(bitsPerSample); // Number of bits per one sample.
                writer.Write(numberOfChannels); // Number of channels.
                writer.Write(Reserved); // Reserved for future use.
                writer.Write(0u); // Reserved.
            }
        }
    }
}
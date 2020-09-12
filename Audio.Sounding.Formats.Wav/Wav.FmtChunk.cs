/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System;
using System.IO;

namespace Yagl.Audio.Sounding.Formats
{
    public partial class Wav
    {
        private static class FmtChunk
        {
            private const uint Code = 0x20746D66; // fmt\n.
            private const uint Size = 16;

            public static void Read(BinaryReader reader, out uint samplesPerSecond, out ushort bitsPerSample, out ushort numberOfChannels)
            {
                var code = reader.ReadUInt32();
                if (code != Code)
                    throw new BadImageFormatException();
                var size = reader.ReadUInt32();
                if (size != Size)
                    throw new BadImageFormatException();
                var format = reader.ReadUInt16();
                if (format != 1) // PCM.
                    throw new BadImageFormatException("Only PCM format is supported.");
                numberOfChannels = reader.ReadUInt16();
                if (numberOfChannels < 1 || numberOfChannels > 2)
                    throw new BadImageFormatException("Only mono and stereo audio formats are supported.");
                samplesPerSecond = reader.ReadUInt32();
                /*var bytesPerSecond =*/ reader.ReadUInt32();
                /*var blockSize =*/ reader.ReadUInt16();
                bitsPerSample = reader.ReadUInt16();
                if (bitsPerSample != 8 && bitsPerSample != 16)
                    throw new BadImageFormatException("Only 8 and 16 bits per sample formats are supported.");
            }
        }
    }
}
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
        private static class RiffChunk
        {
            private const uint Code = 0x46464952; // RIFF.
            private const uint Format = 0x45564157;

            public static void Read(BinaryReader reader)
            {
                var code = reader.ReadUInt32();
                if (code != Code)
                    throw new BadImageFormatException();
                /*var size =*/ reader.ReadUInt32();
                var format = reader.ReadUInt32();
                if (format != Format)
                    throw new BadImageFormatException();
            }
        }
    }
}
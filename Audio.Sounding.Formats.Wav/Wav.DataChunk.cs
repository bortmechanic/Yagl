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
        private static class DataChunk
        {
            private const uint Code = 0x61746164; // data.

            public static void Read(BinaryReader reader, out byte[] data)
            {
                var code = reader.ReadUInt32();
                if (code != Code)
                    throw new BadImageFormatException();
                var size =reader.ReadUInt32();
                data = reader.ReadBytes((int)size);
            }
        }
    }
}
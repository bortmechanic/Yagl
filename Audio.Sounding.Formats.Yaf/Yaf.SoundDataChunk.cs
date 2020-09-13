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
        private static class SoundDataChunk
        {
            public const uint Code = 0x54414449;  // IDAT.

            public static void Read(BinaryReader reader, uint size, out byte[] bitmap)
            {
                bitmap = reader.ReadBytes((int)size);
            }
            
            public static void Write(BinaryWriter writer, byte[] data)
            {
                writer.Write(Code);  // Code.
                writer.Write((uint)data.Length);  // Size.
                writer.Write(data);
                writer.Write(0u);  // Reserved.
            }
        }
    }
}
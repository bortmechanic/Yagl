/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable UnusedType.Global

using System;
using System.IO;

namespace Yagl.Audio.Sounding.Formats
{
    public partial class Yaf
    {
        private static class Signature
        {
            private const ulong CorrectSignature = 0x_21444E53_21464159;  // YAF!SND!

            public static void Read(BinaryReader reader, out ulong signature)
            {
                signature = reader.ReadUInt64();
                if (signature != CorrectSignature)
                    throw new InvalidOperationException();
            }

            public static void Write(BinaryWriter writer)
            {
                writer.Write(CorrectSignature);
            }
        }
    }
}
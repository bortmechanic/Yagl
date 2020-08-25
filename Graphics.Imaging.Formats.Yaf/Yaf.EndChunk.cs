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
        private static class EndChunk
        {
            public const uint Code = 0x21444E45; // END!.
            private const uint Size = 0;

            //public static void Read(BinaryReader reader)
            //{
            //    // Intentionally left blank.
            //}

            public static void Write(BinaryWriter writer)
            {
                writer.Write(Code);  // Code.
                writer.Write(Size);  // Size.
                writer.Write(0u);  // Reserved.
            }
        }
    }
}
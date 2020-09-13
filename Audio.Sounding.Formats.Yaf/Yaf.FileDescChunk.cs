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
        private static class FileDescChunk
        {
            public const uint Code = 0x43534446;  // FDSC.
            private const uint Size = 20;

            private const uint FileType = 0x21464159;  // YAF!.
            private const uint FileSubType = 0x21444E53;  // SND!
            private const ushort VersionMajor = 0x0000;  // 0
            private const ushort VersionMinor = 0x0001;  // 1
            private const ulong Reserved = 0;
            
            public static void Read(BinaryReader reader, out uint fileType, out uint fileSubType, out ushort versionMajor, out ushort versionMinor)
            {
                fileType = reader.ReadUInt32();  // File type.
                fileSubType = reader.ReadUInt32();  // File sub type.
                versionMinor = reader.ReadUInt16();  // Minor component of the format version.
                versionMajor = reader.ReadUInt16();  // Major component of the format version.
                /*reserved =*/ reader.ReadUInt64();  // Reserved for future use.
                if (fileType != FileType)
                    throw new InvalidOperationException();
                if (fileSubType != FileSubType)
                    throw new InvalidOperationException();
                if (versionMajor != VersionMajor || versionMinor != VersionMinor)
                    throw new InvalidOperationException();
            }

            public static void Write(BinaryWriter writer)
            {
                writer.Write(Code);  // Code.
                writer.Write(Size);  // Size.
                writer.Write(FileType);  // File type.
                writer.Write(FileSubType);  // File sub type.
                writer.Write(VersionMinor);  // Minor component of the format version.
                writer.Write(VersionMajor);  // Major component of the format version.
                writer.Write(Reserved);  // Reserved for future use.
                writer.Write(0u);  // Reserved.
            }
        }
    }
}
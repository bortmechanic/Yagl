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
using System.Text;

namespace Yagl.Audio.Sounding.Formats
{
    public partial class Yaf : IFormat
    {
        public bool CanProcess(string filename)
        {
            return filename.EndsWith(".yaf", true, CultureInfo.InvariantCulture);
        }

        public Sound Load(Stream stream)
        {
            using var reader = new BinaryReader(stream, Encoding.UTF8);

            uint sampleRate = 0;
            ushort bitsPerSample = 0;
            ushort numberOfChannels = 0;
            byte[] data = null;

            Signature.Read(reader, out _);

            var finished = false;
            while (!finished)
            {
                var code = reader.ReadUInt32();
                var size = reader.ReadUInt32();
                var beginPosition = stream.Position;

                switch (code)
                {
                    case FileDescChunk.Code:
                        FileDescChunk.Read(reader, out _, out _, out _, out _);
                        break;
                    case SoundDescChunk.Code:
                        SoundDescChunk.Read(reader, out sampleRate, out bitsPerSample, out numberOfChannels);
                        break;
                    case SoundDataChunk.Code:
                        SoundDataChunk.Read(reader, size, out data);
                        break;
                    case EndChunk.Code:
                        //EndChunk.Read(reader);
                        finished = true;
                        break;
                }

                var endPosition = stream.Position;
                var realSize = endPosition - beginPosition;
                if (realSize != size)
                    throw new InvalidOperationException();
                /*var reserved =*/
                reader.ReadUInt32();
            }

            return new Sound
            {
                SampleRate = (int) sampleRate,
                BitsPerSample = (short) bitsPerSample,
                NumberOfChannels = (short) numberOfChannels,
                Data = data
            };
        }

        public void Save(Sound sound, Stream stream)
        {
            using var writer = new BinaryWriter(stream, Encoding.UTF8);
            Signature.Write(writer);
            FileDescChunk.Write(writer);
            SoundDescChunk.Write(writer, (uint) sound.SampleRate, (ushort) sound.BitsPerSample,
                (ushort) sound.NumberOfChannels);
            SoundDataChunk.Write(writer, sound.Data);
            EndChunk.Write(writer);
        }
    }
}
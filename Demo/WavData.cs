using System;
using System.IO;
using Yagl.Audio;

namespace Yagl.Demo
{
    public class WavData
    {
        public uint Format;
        public uint Freqency;
        public ushort Channels;
        public byte[] Data;

        public static WavData Load(string filename)
        {
            var sound = new WavData();

            using var file = File.OpenRead(filename);
            using var reader = new BinaryReader(file);

            reader.ReadBytes(4);
            reader.ReadUInt32();
            reader.ReadBytes(4);
            reader.ReadBytes(4);
            reader.ReadUInt32();
            reader.ReadUInt16();
            sound.Channels = reader.ReadUInt16();
            sound.Freqency = reader.ReadUInt32();
            reader.ReadUInt32();
            reader.ReadUInt16();
            var bitsPerSample = reader.ReadUInt16();
            reader.ReadBytes(4);
            var dataSize = reader.ReadUInt32();
            sound.Data = reader.ReadBytes((int)dataSize);

            if (sound.Channels == 1 && bitsPerSample == 8)
                sound.Format = AL.FORMAT_MONO8;
            else if (sound.Channels == 1 && bitsPerSample == 16)
                sound.Format = AL.FORMAT_MONO16;
            else if (sound.Channels == 2 && bitsPerSample == 8)
                sound.Format = AL.FORMAT_STEREO8;
            else if (sound.Channels == 2 && bitsPerSample == 16)
                sound.Format = AL.FORMAT_STEREO16;
            else
                throw new BadImageFormatException();

            return sound;
        }
    }
}

using System;
using System.Globalization;
using System.IO;

namespace Yagl.Audio.Sounding.Formats
{
    public partial class Wav : IFormat
    {
        public bool CanProcess(string filename)
        {
            return filename?.EndsWith(".wav", true, CultureInfo.InvariantCulture) == true
                   || filename?.EndsWith(".wave", true, CultureInfo.InvariantCulture) == true;
        }

        public Sound Load(Stream stream)
        {
            using var reader = new BinaryReader(stream);
            RiffChunk.Read(reader);
            FmtChunk.Read(reader, out var samplesPerSecond, out var bitsPerSample, out var numberOfChannels);
            DataChunk.Read(reader, out var data);
            return new Sound()
            {
                SampleRate = (int) samplesPerSecond,
                BitsPerSample = bitsPerSample,
                NumberOfChannels = numberOfChannels,
                Data = data
            };
        }

        public void Save(Sound sound, Stream stream)
        {
            throw new NotSupportedException("Saving WAV files is not supported at this time.");
        }
    }
}
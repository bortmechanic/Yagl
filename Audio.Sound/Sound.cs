namespace Yagl.Audio
{
    public class Sound
    {
        public int NumberOfChannels { get; set; }
        public int SampleRate { get; set; }
        public int BitsPerSample { get; set; }
        public byte[] Data { get; set; }
    }
}
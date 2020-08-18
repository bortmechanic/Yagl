namespace Yagl.Graphics.Imaging
{
    public class PixelFormatDescriptor
    {
        public Channel[] Channels { get; set; }
        public int PixelPadding { get; set; }
        public int RowPadding { get; set; }

        public enum ChannelType
        {
            General = 0,
            Red = 1,
            Green = 2,
            Blue = 3,
            Alpha = 4,
            PaletteColor = 5
        }
        
        public class Channel
        {
            public ChannelType Type { get; set; }
            public int NumberOfBits { get; set; }
        }
    }
}
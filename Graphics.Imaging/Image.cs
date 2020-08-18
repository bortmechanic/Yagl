
namespace Yagl.Graphics.Imaging
{
    public class Image
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public PixelFormatDescriptor PixelFormatDescriptor { get; set; }
        public Palette Palette { get; set; }
        public byte[] BitMap { get; set; }
    }
}
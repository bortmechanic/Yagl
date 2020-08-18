namespace Yagl.Graphics.Imaging
{
    public class Palette
    {
        public Color[] Colors { get; set; }
        
        public class Color
        {
            public double Red { get; set; }
            public double Green { get; set; }
            public double Blue { get; set; }
            public double Alpha { get; set; }
        }
    }
}
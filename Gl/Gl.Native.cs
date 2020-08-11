namespace Yagl.Graphics
{
    public static partial class Gl
    {
        private delegate void ClearColorDelegate(float red, float green, float blue, float alpha);
        private static ClearColorDelegate _clearColor;
        
        private delegate void ClearDelegate(uint mask);
        private static ClearDelegate _clear;
    }
}
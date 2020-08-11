// ReSharper disable UnusedMember.Global
namespace Yagl.Graphics
{
    public static partial class Gl
    {
        public static void ClearColor(float red, float green, float blue, float alpha) => _clearColor(red, green, blue, alpha);
        public static void Clear(uint mask) => _clear(mask);
    }
}
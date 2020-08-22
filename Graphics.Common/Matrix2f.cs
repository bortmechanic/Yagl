namespace Yagl.Graphics
{
    public struct Matrix2f
    {
        public float M11, M12;
        public float M21, M22;

        public Matrix2f(float m11, float m12,
                        float m21, float m22)
        {
            M11 = m11; M12 = m12;
            M21 = m21; M22 = m22;
        }
    }
}
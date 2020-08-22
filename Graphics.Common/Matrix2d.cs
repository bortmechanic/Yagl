namespace Yagl.Graphics
{
    public struct Matrix2d
    {
        public double M11, M12;
        public double M21, M22;

        public Matrix2d(double m11, double m12,
                        double m21, double m22)
        {
            M11 = m11; M12 = m12;
            M21 = m21; M22 = m22;
        }
    }
}
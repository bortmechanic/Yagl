/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Viktor Kalmuk.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/
/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Viktor Kalmuk.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

namespace Yagl.Graphics
{
    public struct Matrix3d
    {
        public double M11, M12, M13;
        public double M21, M22, M23;
        public double M31, M32, M33;

        public Matrix3d(double m11, double m12, double m13,
                        double m21, double m22, double m23,
                        double m31, double m32, double m33)
        {
            M11 = m11; M12 = m12; M13 = m13;
            M21 = m21; M22 = m22; M23 = m23;
            M31 = m31; M32 = m32; M33 = m33;
        }
    }
}

namespace Yagl.Graphics
{
    public struct Matrix3f
    {
        public float M11, M12, M13;
        public float M21, M22, M23;
        public float M31, M32, M33;

        public Matrix3f(float m11, float m12, float m13,
            float m21, float m22, float m23,
            float m31, float m32, float m33)
        {
            M11 = m11; M12 = m12; M13 = m13;
            M21 = m21; M22 = m22; M23 = m23;
            M31 = m31; M32 = m32; M33 = m33;
        }
    }
}

namespace Yagl.Graphics
{
    public struct Matrix3i
    {
        public int M11, M12, M13;
        public int M21, M22, M23;
        public int M31, M32, M33;

        public Matrix3i(int m11, int m12, int m13,
            int m21, int m22, int m23,
            int m31, int m32, int m33)
        {
            M11 = m11; M12 = m12; M13 = m13;
            M21 = m21; M22 = m22; M23 = m23;
            M31 = m31; M32 = m32; M33 = m33;
        }
    }
}
/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Viktor Kalmuk, Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/
namespace Yagl.Graphics
{
    public struct Matrix4i
    {
        public int M11, M12, M13, M14;
        public int M21, M22, M23, M24;
        public int M31, M32, M33, M34;
        public int M41, M42, M43, M44;

        public Matrix4i(int m11, int m12, int m13, int m14,
                        int m21, int m22, int m23, int m24,
                        int m31, int m32, int m33, int m34,
                        int m41, int m42, int m43, int m44)
        {
            M11 = m11; M12 = m12; M13 = m13; M14 = m14;
            M21 = m21; M22 = m22; M23 = m23; M24 = m24;
            M31 = m31; M32 = m32; M33 = m33; M34 = m34;
            M41 = m41; M42 = m42; M43 = m43; M44 = m44;
        }
    }
}
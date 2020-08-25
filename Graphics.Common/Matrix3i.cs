/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Viktor Kalmuk, Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/
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
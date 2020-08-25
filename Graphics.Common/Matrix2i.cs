/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Viktor Kalmuk, Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/
namespace Yagl.Graphics
{
    public struct Matrix2i
    {
        public int M11, M12;
        public int M21, M22;

        public Matrix2i(int m11, int m12,
                        int m21, int m22)
        {
            M11 = m11; M12 = m12;
            M21 = m21; M22 = m22;
        }
    }
}
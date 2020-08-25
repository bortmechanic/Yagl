/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Viktor Kalmuk.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable InconsistentNaming
// ReSharper disable FieldCanBeMadeReadOnly.Global

namespace Yagl.Graphics
{
    public struct Vector4d
    {
        public double X, Y, Z, W;

        public Vector4d(double x, double y, double z,double w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
    }

    public struct Vector4f
    {
        public float X, Y, Z, W;

        public Vector4f(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
    }

    public struct Vector4i
    {
        public int X, Y, Z, W;

        public Vector4i(int x, int y, int z, int w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
    }
}
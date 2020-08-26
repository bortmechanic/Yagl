/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Viktor Kalmuk.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable InconsistentNaming
// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable UnusedMember.Global

using System.Globalization;

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
        
        public static Vector4d Zero => new Vector4d(0, 0, 0, 1);
        public static Vector4d UnitX => new Vector4d(1, 0, 0, 1);
        public static Vector4d UnitY => new Vector4d(0, 1, 0, 1);
        public static Vector4d UnitZ => new Vector4d(0, 0, 1, 1);
        
        public override string ToString() =>
            $"({X.ToString(CultureInfo.InvariantCulture)}, {Y.ToString(CultureInfo.InvariantCulture)}, {Z.ToString(CultureInfo.InvariantCulture)}, {W.ToString(CultureInfo.InvariantCulture)})";
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
        
        public static Vector4f Zero => new Vector4f(0, 0, 0, 1);
        public static Vector4f UnitX => new Vector4f(1, 0, 0, 1);
        public static Vector4f UnitY => new Vector4f(0, 1, 0, 1);
        public static Vector4f UnitZ => new Vector4f(0, 0, 1, 1);
        
        public override string ToString() =>
            $"({X.ToString(CultureInfo.InvariantCulture)}, {Y.ToString(CultureInfo.InvariantCulture)}, {Z.ToString(CultureInfo.InvariantCulture)}, {W.ToString(CultureInfo.InvariantCulture)})";
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
        
        public static Vector4i Zero => new Vector4i(0, 0, 0, 1);
        public static Vector4i UnitX => new Vector4i(1, 0, 0, 1);
        public static Vector4i UnitY => new Vector4i(0, 1, 0, 1);
        public static Vector4i UnitZ => new Vector4i(0, 0, 1, 1);
        
        public override string ToString() =>
            $"({X.ToString()}, {Y.ToString()}, {Z.ToString()}, {W.ToString()})";
    }
}
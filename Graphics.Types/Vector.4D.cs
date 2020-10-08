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
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedType.Global

using System.Globalization;
using System.Runtime.InteropServices;

namespace Yagl.Graphics
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct Vector4d
    {
        [FieldOffset(0)] public double X;
        [FieldOffset(8)] public double Y;
        [FieldOffset(16)] public double Z;
        [FieldOffset(24)] public double W;

        [FieldOffset(0)] public unsafe fixed double Data[4];

        public static unsafe implicit operator double*(Vector4d value) => value.Data;

        public Vector4d(double x, double y, double z, double w)
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

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct Vector4f
    {
        [FieldOffset(0)] public float X;
        [FieldOffset(4)] public float Y;
        [FieldOffset(8)] public float Z;
        [FieldOffset(12)] public float W;

        [FieldOffset(0)] public unsafe fixed float Data[4];

        public static unsafe implicit operator float*(Vector4f value) => value.Data;

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

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct Vector4i
    {
        [FieldOffset(0)] public int X;
        [FieldOffset(4)] public int Y;
        [FieldOffset(8)] public int Z;
        [FieldOffset(12)] public int W;

        [FieldOffset(0)] public unsafe fixed int Data[4];

        public static unsafe implicit operator int*(Vector4i value) => value.Data;

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
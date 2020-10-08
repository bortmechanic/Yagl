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
    public struct Vector2d
    {
        [FieldOffset(0)] public double X;
        [FieldOffset(8)] public double Y;

        [FieldOffset(0)] public unsafe fixed double Data[2];

        public static unsafe implicit operator double*(Vector2d value) => value.Data;

        public Vector2d(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Vector2d Zero => new Vector2d(0, 0);
        public static Vector2d UnitX => new Vector2d(1, 0);
        public static Vector2d UnitY => new Vector2d(0, 1);

        public override string ToString() =>
            $"({X.ToString(CultureInfo.InvariantCulture)}, {Y.ToString(CultureInfo.InvariantCulture)})";
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct Vector2f
    {
        [FieldOffset(0)] public float X;
        [FieldOffset(4)] public float Y;

        [FieldOffset(0)] public unsafe fixed float Data[2];

        public static unsafe implicit operator float*(Vector2f value) => value.Data;

        public Vector2f(float x, float y)
        {
            X = x;
            Y = y;
        }

        public static Vector2f Zero => new Vector2f(0, 0);
        public static Vector2f UnitX => new Vector2f(1, 0);
        public static Vector2f UnitY => new Vector2f(0, 1);

        public override string ToString() =>
            $"({X.ToString(CultureInfo.InvariantCulture)}, {Y.ToString(CultureInfo.InvariantCulture)})";
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct Vector2i
    {
        [FieldOffset(0)] public int X;
        [FieldOffset(4)] public int Y;

        [FieldOffset(0)] public unsafe fixed int Data[2];

        public static unsafe implicit operator int*(Vector2i value) => value.Data;

        public Vector2i(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Vector2i Zero => new Vector2i(0, 0);
        public static Vector2i UnitX => new Vector2i(1, 0);
        public static Vector2i UnitY => new Vector2i(0, 1);

        public override string ToString() =>
            $"({X.ToString()}, {Y.ToString()})";
    }
}
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
    public struct Vector3d
    {
        [FieldOffset(0)] public double X;
        [FieldOffset(8)] public double Y;
        [FieldOffset(16)] public double Z;

        [FieldOffset(0)] public unsafe fixed double Data[3];

        public static unsafe implicit operator double*(Vector3d value) => value.Data;

        public Vector3d(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector3d Zero => new Vector3d(0, 0, 0);
        public static Vector3d UnitX => new Vector3d(1, 0, 0);
        public static Vector3d UnitY => new Vector3d(0, 1, 0);
        public static Vector3d UnitZ => new Vector3d(0, 0, 1);

        public override string ToString() =>
            $"({X.ToString(CultureInfo.InvariantCulture)}, {Y.ToString(CultureInfo.InvariantCulture)}, {Z.ToString(CultureInfo.InvariantCulture)})";
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct Vector3f
    {
        [FieldOffset(0)] public float X;
        [FieldOffset(4)] public float Y;
        [FieldOffset(8)] public float Z;

        [FieldOffset(0)] public unsafe fixed float Data[3];

        public static unsafe implicit operator float*(Vector3f value) => value.Data;

        public Vector3f(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector3f Zero => new Vector3f(0, 0, 0);
        public static Vector3f UnitX => new Vector3f(1, 0, 0);
        public static Vector3f UnitY => new Vector3f(0, 1, 0);
        public static Vector3f UnitZ => new Vector3f(0, 0, 1);

        public override string ToString() =>
            $"({X.ToString(CultureInfo.InvariantCulture)}, {Y.ToString(CultureInfo.InvariantCulture)}, {Z.ToString(CultureInfo.InvariantCulture)})";
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct Vector3i
    {
        [FieldOffset(0)] public int X;
        [FieldOffset(4)] public int Y;
        [FieldOffset(8)] public int Z;

        [FieldOffset(0)] public unsafe fixed int Data[3];

        public static unsafe implicit operator int*(Vector3i value) => value.Data;

        public Vector3i(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector3i Zero => new Vector3i(0, 0, 0);
        public static Vector3i UnitX => new Vector3i(1, 0, 0);
        public static Vector3i UnitY => new Vector3i(0, 1, 0);
        public static Vector3i UnitZ => new Vector3i(0, 0, 1);

        public override string ToString() =>
            $"({X.ToString()}, {Y.ToString()}, {Z.ToString()})";
    }
}
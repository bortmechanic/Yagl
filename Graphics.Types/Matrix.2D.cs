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
    public struct Matrix2d
    {
        [FieldOffset(0)] public double M11;
        [FieldOffset(8)] public double M12;
        [FieldOffset(16)] public double M21;
        [FieldOffset(24)] public double M22;

        [FieldOffset(0)] public unsafe fixed double Data[4];

        public static unsafe implicit operator double*(Matrix2d value) => value.Data;

        public Matrix2d(double m11, double m12, double m21, double m22)
        {
            M11 = m11;
            M12 = m12;
            M21 = m21;
            M22 = m22;
        }

        public static Matrix2d Identity => new Matrix2d(1, 0, 1, 0);

        public override string ToString() =>
            $"( ({M11.ToString(CultureInfo.InvariantCulture)}, {M12.ToString(CultureInfo.InvariantCulture)}), ({M21.ToString(CultureInfo.InvariantCulture)}, {M22.ToString(CultureInfo.InvariantCulture)}) )";
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct Matrix2f
    {
        [FieldOffset(0)] public float M11;
        [FieldOffset(4)] public float M12;
        [FieldOffset(8)] public float M21;
        [FieldOffset(12)] public float M22;

        [FieldOffset(0)] public unsafe fixed float Data[4];

        public static unsafe implicit operator float*(Matrix2f value) => value.Data;

        public Matrix2f(float m11, float m12, float m21, float m22)
        {
            M11 = m11;
            M12 = m12;
            M21 = m21;
            M22 = m22;
        }

        public static Matrix2f Identity => new Matrix2f(1, 0, 1, 0);

        public override string ToString() =>
            $"( ({M11.ToString(CultureInfo.InvariantCulture)}, {M12.ToString(CultureInfo.InvariantCulture)}), ({M21.ToString(CultureInfo.InvariantCulture)}, {M22.ToString(CultureInfo.InvariantCulture)}) )";
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct Matrix2i
    {
        [FieldOffset(0)] public int M11;
        [FieldOffset(4)] public int M12;
        [FieldOffset(8)] public int M21;
        [FieldOffset(12)] public int M22;

        [FieldOffset(0)] public unsafe fixed int Data[4];

        public static unsafe implicit operator int*(Matrix2i value) => value.Data;

        public Matrix2i(int m11, int m12, int m21, int m22)
        {
            M11 = m11;
            M12 = m12;
            M21 = m21;
            M22 = m22;
        }

        public static Matrix2i Identity => new Matrix2i(1, 0, 1, 0);

        public override string ToString() =>
            $"( ({M11.ToString()}, {M12.ToString()}), ({M21.ToString()}, {M22.ToString()}) )";
    }
}
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
    public struct Matrix3d
    {
        [FieldOffset(0)] public double M11;
        [FieldOffset(8)] public double M12;
        [FieldOffset(16)] public double M13;
        [FieldOffset(24)] public double M21;
        [FieldOffset(32)] public double M22;
        [FieldOffset(40)] public double M23;
        [FieldOffset(48)] public double M31;
        [FieldOffset(56)] public double M32;
        [FieldOffset(64)] public double M33;

        [FieldOffset(0)] public unsafe fixed double Data[9];

        public static unsafe implicit operator double*(Matrix3d value) => value.Data;

        public Matrix3d(double m11, double m12, double m13, double m21, double m22, double m23, double m31, double m32,
            double m33)
        {
            M11 = m11;
            M12 = m12;
            M13 = m13;
            M21 = m21;
            M22 = m22;
            M23 = m23;
            M31 = m31;
            M32 = m32;
            M33 = m33;
        }

        public static Matrix3d Identity => new Matrix3d(1, 0, 0, 0, 1, 0, 0, 0, 1);

        public override string ToString() =>
            $"( ({M11.ToString(CultureInfo.InvariantCulture)}, {M12.ToString(CultureInfo.InvariantCulture)}, {M13.ToString(CultureInfo.InvariantCulture)}), ({M21.ToString(CultureInfo.InvariantCulture)}, {M22.ToString(CultureInfo.InvariantCulture)}, {M23.ToString(CultureInfo.InvariantCulture)}), ({M31.ToString(CultureInfo.InvariantCulture)}, {M32.ToString(CultureInfo.InvariantCulture)}, {M33.ToString(CultureInfo.InvariantCulture)}) )";
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct Matrix3f
    {
        [FieldOffset(0)] public float M11;
        [FieldOffset(4)] public float M12;
        [FieldOffset(8)] public float M13;
        [FieldOffset(12)] public float M21;
        [FieldOffset(16)] public float M22;
        [FieldOffset(20)] public float M23;
        [FieldOffset(24)] public float M31;
        [FieldOffset(28)] public float M32;
        [FieldOffset(32)] public float M33;

        [FieldOffset(0)] public unsafe fixed float Data[9];

        public static unsafe implicit operator float*(Matrix3f value) => value.Data;

        public Matrix3f(float m11, float m12, float m13, float m21, float m22, float m23, float m31, float m32,
            float m33)
        {
            M11 = m11;
            M12 = m12;
            M13 = m13;
            M21 = m21;
            M22 = m22;
            M23 = m23;
            M31 = m31;
            M32 = m32;
            M33 = m33;
        }

        public static Matrix3f Identity => new Matrix3f(1, 0, 0, 0, 1, 0, 0, 0, 1);

        public override string ToString() =>
            $"( ({M11.ToString(CultureInfo.InvariantCulture)}, {M12.ToString(CultureInfo.InvariantCulture)}, {M13.ToString(CultureInfo.InvariantCulture)}), ({M21.ToString(CultureInfo.InvariantCulture)}, {M22.ToString(CultureInfo.InvariantCulture)}, {M23.ToString(CultureInfo.InvariantCulture)}), ({M31.ToString(CultureInfo.InvariantCulture)}, {M32.ToString(CultureInfo.InvariantCulture)}, {M33.ToString(CultureInfo.InvariantCulture)}) )";
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct Matrix3i
    {
        [FieldOffset(0)] public int M11;
        [FieldOffset(4)] public int M12;
        [FieldOffset(8)] public int M13;
        [FieldOffset(12)] public int M21;
        [FieldOffset(16)] public int M22;
        [FieldOffset(20)] public int M23;
        [FieldOffset(24)] public int M31;
        [FieldOffset(28)] public int M32;
        [FieldOffset(32)] public int M33;

        [FieldOffset(0)] public unsafe fixed int Data[9];

        public static unsafe implicit operator int*(Matrix3i value) => value.Data;

        public Matrix3i(int m11, int m12, int m13, int m21, int m22, int m23, int m31, int m32, int m33)
        {
            M11 = m11;
            M12 = m12;
            M13 = m13;
            M21 = m21;
            M22 = m22;
            M23 = m23;
            M31 = m31;
            M32 = m32;
            M33 = m33;
        }

        public static Matrix3i Identity => new Matrix3i(1, 0, 0, 0, 1, 0, 0, 0, 1);

        public override string ToString() =>
            $"( ({M11.ToString()}, {M12.ToString()}, {M13.ToString()}), ({M21.ToString()}, {M22.ToString()}, {M23.ToString()}), ({M31.ToString()}, {M32.ToString()}, {M33.ToString()}) )";
    }
}
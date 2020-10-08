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
    public struct Matrix4d
    {
        [FieldOffset(0)] public double M11;
        [FieldOffset(8)] public double M12;
        [FieldOffset(16)] public double M13;
        [FieldOffset(24)] public double M14;
        [FieldOffset(32)] public double M21;
        [FieldOffset(40)] public double M22;
        [FieldOffset(48)] public double M23;
        [FieldOffset(56)] public double M24;
        [FieldOffset(64)] public double M31;
        [FieldOffset(72)] public double M32;
        [FieldOffset(80)] public double M33;
        [FieldOffset(88)] public double M34;
        [FieldOffset(96)] public double M41;
        [FieldOffset(104)] public double M42;
        [FieldOffset(112)] public double M43;
        [FieldOffset(120)] public double M44;

        [FieldOffset(0)] public unsafe fixed double Data[16];

        public static unsafe implicit operator double*(Matrix4d value) => value.Data;

        public Matrix4d(double m11, double m12, double m13, double m14, double m21, double m22, double m23, double m24,
            double m31, double m32, double m33, double m34, double m41, double m42, double m43, double m44)
        {
            M11 = m11;
            M12 = m12;
            M13 = m13;
            M14 = m14;
            M21 = m21;
            M22 = m22;
            M23 = m23;
            M24 = m24;
            M31 = m31;
            M32 = m32;
            M33 = m33;
            M34 = m34;
            M41 = m41;
            M42 = m42;
            M43 = m43;
            M44 = m44;
        }

        public static Matrix4d Identity => new Matrix4d(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);

        public override string ToString() =>
            $"( ({M11.ToString(CultureInfo.InvariantCulture)}, {M12.ToString(CultureInfo.InvariantCulture)}, {M13.ToString(CultureInfo.InvariantCulture)}, {M14.ToString(CultureInfo.InvariantCulture)}), ({M21.ToString(CultureInfo.InvariantCulture)}, {M22.ToString(CultureInfo.InvariantCulture)}, {M23.ToString(CultureInfo.InvariantCulture)} {M24.ToString(CultureInfo.InvariantCulture)}), ({M31.ToString(CultureInfo.InvariantCulture)}, {M32.ToString(CultureInfo.InvariantCulture)}, {M33.ToString(CultureInfo.InvariantCulture)} {M34.ToString(CultureInfo.InvariantCulture)}), ({M41.ToString(CultureInfo.InvariantCulture)}, {M42.ToString(CultureInfo.InvariantCulture)}, {M43.ToString(CultureInfo.InvariantCulture)} {M44.ToString(CultureInfo.InvariantCulture)}) )";
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct Matrix4f
    {
        [FieldOffset(0)] public float M11;
        [FieldOffset(4)] public float M12;
        [FieldOffset(8)] public float M13;
        [FieldOffset(12)] public float M14;
        [FieldOffset(16)] public float M21;
        [FieldOffset(20)] public float M22;
        [FieldOffset(24)] public float M23;
        [FieldOffset(28)] public float M24;
        [FieldOffset(32)] public float M31;
        [FieldOffset(36)] public float M32;
        [FieldOffset(40)] public float M33;
        [FieldOffset(44)] public float M34;
        [FieldOffset(48)] public float M41;
        [FieldOffset(52)] public float M42;
        [FieldOffset(56)] public float M43;
        [FieldOffset(60)] public float M44;

        [FieldOffset(0)] public unsafe fixed float Data[16];

        public static unsafe implicit operator float*(Matrix4f value) => value.Data;

        public Matrix4f(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24,
            float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
        {
            M11 = m11;
            M12 = m12;
            M13 = m13;
            M14 = m14;
            M21 = m21;
            M22 = m22;
            M23 = m23;
            M24 = m24;
            M31 = m31;
            M32 = m32;
            M33 = m33;
            M34 = m34;
            M41 = m41;
            M42 = m42;
            M43 = m43;
            M44 = m44;
        }

        public static Matrix4f Identity => new Matrix4f(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);

        public override string ToString() =>
            $"( ({M11.ToString(CultureInfo.InvariantCulture)}, {M12.ToString(CultureInfo.InvariantCulture)}, {M13.ToString(CultureInfo.InvariantCulture)}, {M14.ToString(CultureInfo.InvariantCulture)}), ({M21.ToString(CultureInfo.InvariantCulture)}, {M22.ToString(CultureInfo.InvariantCulture)}, {M23.ToString(CultureInfo.InvariantCulture)} {M24.ToString(CultureInfo.InvariantCulture)}), ({M31.ToString(CultureInfo.InvariantCulture)}, {M32.ToString(CultureInfo.InvariantCulture)}, {M33.ToString(CultureInfo.InvariantCulture)} {M34.ToString(CultureInfo.InvariantCulture)}), ({M41.ToString(CultureInfo.InvariantCulture)}, {M42.ToString(CultureInfo.InvariantCulture)}, {M43.ToString(CultureInfo.InvariantCulture)} {M44.ToString(CultureInfo.InvariantCulture)}) )";
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct Matrix4i
    {
        [FieldOffset(0)] public int M11;
        [FieldOffset(4)] public int M12;
        [FieldOffset(8)] public int M13;
        [FieldOffset(12)] public int M14;
        [FieldOffset(16)] public int M21;
        [FieldOffset(20)] public int M22;
        [FieldOffset(24)] public int M23;
        [FieldOffset(28)] public int M24;
        [FieldOffset(32)] public int M31;
        [FieldOffset(36)] public int M32;
        [FieldOffset(40)] public int M33;
        [FieldOffset(44)] public int M34;
        [FieldOffset(48)] public int M41;
        [FieldOffset(52)] public int M42;
        [FieldOffset(56)] public int M43;
        [FieldOffset(60)] public int M44;

        [FieldOffset(0)] public unsafe fixed int Data[16];

        public static unsafe implicit operator int*(Matrix4i value) => value.Data;

        public Matrix4i(int m11, int m12, int m13, int m14, int m21, int m22, int m23, int m24, int m31, int m32,
            int m33, int m34, int m41, int m42, int m43, int m44)
        {
            M11 = m11;
            M12 = m12;
            M13 = m13;
            M14 = m14;
            M21 = m21;
            M22 = m22;
            M23 = m23;
            M24 = m24;
            M31 = m31;
            M32 = m32;
            M33 = m33;
            M34 = m34;
            M41 = m41;
            M42 = m42;
            M43 = m43;
            M44 = m44;
        }

        public static Matrix4i Identity => new Matrix4i(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);

        public override string ToString() =>
            $"( ({M11.ToString()}, {M12.ToString()}, {M13.ToString()}, {M14.ToString()}), ({M21.ToString()}, {M22.ToString()}, {M23.ToString()} {M24.ToString()}), ({M31.ToString()}, {M32.ToString()}, {M33.ToString()} {M34.ToString()}), ({M41.ToString()}, {M42.ToString()}, {M43.ToString()} {M44.ToString()}) )";
    }
}
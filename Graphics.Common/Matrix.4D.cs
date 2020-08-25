/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Viktor Kalmuk.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable InconsistentNaming
// ReSharper disable FieldCanBeMadeReadOnly.Global

using System.Globalization;

namespace Yagl.Graphics
{
    public struct Matrix4d
    {
        public double M11, M12, M13, M14;
        public double M21, M22, M23, M24;
        public double M31, M32, M33, M34;
        public double M41, M42, M43, M44;

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
        
        public override string ToString() =>
            $"( ({M11.ToString(CultureInfo.InvariantCulture)}, {M12.ToString(CultureInfo.InvariantCulture)}, {M13.ToString(CultureInfo.InvariantCulture)}, {M14.ToString(CultureInfo.InvariantCulture)}), ({M21.ToString(CultureInfo.InvariantCulture)}, {M22.ToString(CultureInfo.InvariantCulture)}, {M23.ToString(CultureInfo.InvariantCulture)} {M24.ToString(CultureInfo.InvariantCulture)}), ({M31.ToString(CultureInfo.InvariantCulture)}, {M32.ToString(CultureInfo.InvariantCulture)}, {M33.ToString(CultureInfo.InvariantCulture)} {M34.ToString(CultureInfo.InvariantCulture)}), ({M41.ToString(CultureInfo.InvariantCulture)}, {M42.ToString(CultureInfo.InvariantCulture)}, {M43.ToString(CultureInfo.InvariantCulture)} {M44.ToString(CultureInfo.InvariantCulture)}) )";
    }

    public struct Matrix4f
    {
        public float M11, M12, M13, M14;
        public float M21, M22, M23, M24;
        public float M31, M32, M33, M34;
        public float M41, M42, M43, M44;

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
        
        public override string ToString() =>
            $"( ({M11.ToString(CultureInfo.InvariantCulture)}, {M12.ToString(CultureInfo.InvariantCulture)}, {M13.ToString(CultureInfo.InvariantCulture)}, {M14.ToString(CultureInfo.InvariantCulture)}), ({M21.ToString(CultureInfo.InvariantCulture)}, {M22.ToString(CultureInfo.InvariantCulture)}, {M23.ToString(CultureInfo.InvariantCulture)} {M24.ToString(CultureInfo.InvariantCulture)}), ({M31.ToString(CultureInfo.InvariantCulture)}, {M32.ToString(CultureInfo.InvariantCulture)}, {M33.ToString(CultureInfo.InvariantCulture)} {M34.ToString(CultureInfo.InvariantCulture)}), ({M41.ToString(CultureInfo.InvariantCulture)}, {M42.ToString(CultureInfo.InvariantCulture)}, {M43.ToString(CultureInfo.InvariantCulture)} {M44.ToString(CultureInfo.InvariantCulture)}) )";
    }

    public struct Matrix4i
    {
        public int M11, M12, M13, M14;
        public int M21, M22, M23, M24;
        public int M31, M32, M33, M34;
        public int M41, M42, M43, M44;

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
        
        public override string ToString() =>
            $"( ({M11.ToString()}, {M12.ToString()}, {M13.ToString()}, {M14.ToString()}), ({M21.ToString()}, {M22.ToString()}, {M23.ToString()} {M24.ToString()}), ({M31.ToString()}, {M32.ToString()}, {M33.ToString()} {M34.ToString()}), ({M41.ToString()}, {M42.ToString()}, {M43.ToString()} {M44.ToString()}) )";
    }
}
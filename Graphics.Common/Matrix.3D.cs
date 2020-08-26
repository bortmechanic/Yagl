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
    public struct Matrix3d
    {
        public double M11, M12, M13;
        public double M21, M22, M23;
        public double M31, M32, M33;

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

    public struct Matrix3f
    {
        public float M11, M12, M13;
        public float M21, M22, M23;
        public float M31, M32, M33;

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

    public struct Matrix3i
    {
        public int M11, M12, M13;
        public int M21, M22, M23;
        public int M31, M32, M33;

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
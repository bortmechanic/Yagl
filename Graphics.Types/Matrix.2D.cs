﻿/*
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

namespace Yagl.Graphics
{
    public struct Matrix2d
    {
        public double M11, M12;
        public double M21, M22;

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

    public struct Matrix2f
    {
        public float M11, M12;
        public float M21, M22;

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

    public struct Matrix2i
    {
        public int M11, M12;
        public int M21, M22;

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
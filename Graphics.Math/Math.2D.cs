/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Viktor Kalmuk.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global

namespace Yagl.Graphics
{
    public partial class Math
    {
        public static double Length(Vector2d v)
        {
            return Sqrt(v.X * v.X + v.Y * v.Y);
        }

        public static float Length(Vector2f v)
        {
            return Sqrt(v.X * v.X + v.Y * v.Y);
        }

        public static float Length(Vector2i v)
        {
            return Sqrt(v.X * v.X + v.Y * v.Y);
        }

        public static double Dot(Vector2d v1, Vector2d v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        public static float Dot(Vector2f v1, Vector2f v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        public static int Dot(Vector2i v1, Vector2i v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        public static Vector2d Add(Vector2d v1, Vector2d v2)
        {
            return new Vector2d(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector2f Add(Vector2f v1, Vector2f v2)
        {
            return new Vector2f(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector2i Add(Vector2i v1, Vector2i v2)
        {
            return new Vector2i(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector2d Subtract(Vector2d v1, Vector2d v2)
        {
            return new Vector2d(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static Vector2f Subtract(Vector2f v1, Vector2f v2)
        {
            return new Vector2f(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static Vector2i Subtract(Vector2i v1, Vector2i v2)
        {
            return new Vector2i(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static Vector2d Multiply(Vector2d v, double a)
        {
            return new Vector2d(a * v.X, a * v.Y);
        }

        public static Vector2f Multiply(Vector2f v, float a)
        {
            return new Vector2f(a * v.X, a * v.Y);
        }

        public static Vector2i Multiply(Vector2i v, int a)
        {
            return new Vector2i(a * v.X, a * v.Y);
        }

        public static Vector2d Divide(Vector2d v, double a)
        {
            return new Vector2d(v.X / a, v.Y / a);
        }

        public static Vector2f Divide(Vector2f v, float a)
        {
            return new Vector2f(v.X / a, v.Y / a);
        }

        public static Vector2f Divide(Vector2i v, int a)
        {
            return new Vector2f(v.X / (float) a, v.Y / (float) a);
        }

        public static Vector2d Normalize(Vector2d v)
        {
            var a = Length(v);
            return new Vector2d(v.X / a, v.Y / a);
        }

        public static Vector2f Normalize(Vector2f v)
        {
            var a = Length(v);
            return new Vector2f(v.X / a, v.Y / a);
        }

        public static Vector2f Normalize(Vector2i v)
        {
            var a = Length(v);
            return new Vector2f(v.X / a, v.Y / a);
        }

        public static Vector2d Negate(Vector2d v)
        {
            return new Vector2d(-v.X, -v.Y);
        }

        public static Vector2f Negate(Vector2f v)
        {
            return new Vector2f(-v.X, -v.Y);
        }

        public static Vector2i Negate(Vector2i v)
        {
            return new Vector2i(-v.X, -v.Y);
        }

        public static Matrix2d Multiply(Matrix2d m, double a)
        {
            return new Matrix2d(m.M11 * a, m.M12 * a, m.M21 * a, m.M22 * a);
        }

        public static Matrix2f Multiply(Matrix2f m, float a)
        {
            return new Matrix2f(m.M11 * a, m.M12 * a, m.M21 * a, m.M22 * a);
        }

        public static Matrix2i Multiply(Matrix2i m, int a)
        {
            return new Matrix2i(m.M11 * a, m.M12 * a, m.M21 * a, m.M22 * a);
        }

        public static Matrix2d Divide(Matrix2d m, double a)
        {
            return new Matrix2d(m.M11 / a, m.M12 / a, m.M21 / a, m.M22 / a);
        }

        public static Matrix2f Divide(Matrix2f m, float a)
        {
            return new Matrix2f(m.M11 / a, m.M12 / a, m.M21 / a, m.M22 / a);
        }

        public static Matrix2f Divide(Matrix2i m, int a)
        {
            return new Matrix2f(m.M11 / (float) a, m.M12 / (float) a, m.M21 / (float) a, m.M22 / (float) a);
        }

        public static Matrix2d Add(Matrix2d m1, Matrix2d m2)
        {
            return new Matrix2d(m1.M11 + m2.M11, m1.M12 + m2.M12, m1.M21 + m2.M21, m1.M22 + m2.M22);
        }

        public static Matrix2f Add(Matrix2f m1, Matrix2f m2)
        {
            return new Matrix2f(m1.M11 + m2.M11, m1.M12 + m2.M12, m1.M21 + m2.M21, m1.M22 + m2.M22);
        }

        public static Matrix2i Add(Matrix2i m1, Matrix2i m2)
        {
            return new Matrix2i(m1.M11 + m2.M11, m1.M12 + m2.M12, m1.M21 + m2.M21, m1.M22 + m2.M22);
        }

        public static Matrix2d Subtract(Matrix2d m1, Matrix2d m2)
        {
            return new Matrix2d(m1.M11 - m2.M11, m1.M12 - m2.M12, m1.M21 - m2.M21, m1.M22 - m2.M22);
        }

        public static Matrix2f Subtract(Matrix2f m1, Matrix2f m2)
        {
            return new Matrix2f(m1.M11 - m2.M11, m1.M12 - m2.M12, m1.M21 - m2.M21, m1.M22 - m2.M22);
        }

        public static Matrix2i Subtract(Matrix2i m1, Matrix2i m2)
        {
            return new Matrix2i(m1.M11 - m2.M11, m1.M12 - m2.M12, m1.M21 - m2.M21, m1.M22 - m2.M22);
        }

        public static double Determinant(Matrix2d m)
        {
            return m.M11 * m.M22 - m.M21 * m.M12;
        }

        public static float Determinant(Matrix2f m)
        {
            return m.M11 * m.M22 - m.M21 * m.M12;
        }

        public static int Determinant(Matrix2i m)
        {
            return m.M11 * m.M22 - m.M21 * m.M12;
        }

        public static Matrix2d Multiply(Matrix2d m1, Matrix2d m2)
        {
            return new Matrix2d(m1.M11 * m2.M11 + m1.M12 * m2.M21, m1.M11 * m2.M12 + m1.M12 * m2.M22,
                m1.M21 * m2.M11 + m1.M22 * m2.M21, m1.M21 * m2.M12 + m1.M22 * m2.M22);
        }

        public static Matrix2f Multiply(Matrix2f m1, Matrix2f m2)
        {
            return new Matrix2f(m1.M11 * m2.M11 + m1.M12 * m2.M21, m1.M11 * m2.M12 + m1.M12 * m2.M22,
                m1.M21 * m2.M11 + m1.M22 * m2.M21, m1.M21 * m2.M12 + m1.M22 * m2.M22);
        }

        public static Matrix2i Multiply(Matrix2i m1, Matrix2i m2)
        {
            return new Matrix2i(m1.M11 * m2.M11 + m1.M12 * m2.M21, m1.M11 * m2.M12 + m1.M12 * m2.M22,
                m1.M21 * m2.M11 + m1.M22 * m2.M21, m1.M21 * m2.M12 + m1.M22 * m2.M22);
        }

        public static Matrix2d Invert(Matrix2d m)
        {
            var st = new Matrix2d(m.M22, -m.M12, -m.M21, m.M11);
            return Divide(st, Determinant(m));
        }

        public static Matrix2f Invert(Matrix2f m)
        {
            var st = new Matrix2f(m.M22, -m.M12, -m.M21, m.M11);
            return Divide(st, Determinant(m));
        }

        public static Matrix2f Invert(Matrix2i m)
        {
            var st = new Matrix2i(m.M22, -m.M12, -m.M21, m.M11);
            return Divide(st, Determinant(m));
        }
    }
}
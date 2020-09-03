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
        public static double Length(Vector3d v)
        {
            return Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);
        }

        public static float Length(Vector3f v)
        {
            return Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);
        }

        public static float Length(Vector3i v)
        {
            return Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);
        }

        public static double Dot(Vector3d v1, Vector3d v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        public static float Dot(Vector3f v1, Vector3f v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        public static int Dot(Vector3i v1, Vector3i v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        public static Vector3d Add(Vector3d v1, Vector3d v2)
        {
            return new Vector3d(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector3f Add(Vector3f v1, Vector3f v2)
        {
            return new Vector3f(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector3i Add(Vector3i v1, Vector3i v2)
        {
            return new Vector3i(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector3d Subtract(Vector3d v1, Vector3d v2)
        {
            return new Vector3d(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector3f Subtract(Vector3f v1, Vector3f v2)
        {
            return new Vector3f(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector3i Subtract(Vector3i v1, Vector3i v2)
        {
            return new Vector3i(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector3d Multiply(Vector3d v, double a)
        {
            return new Vector3d(a * v.X, a * v.Y, a * v.Z);
        }

        public static Vector3f Multiply(Vector3f v, float a)
        {
            return new Vector3f(a * v.X, a * v.Y, a * v.Z);
        }

        public static Vector3i Multiply(Vector3i v, int a)
        {
            return new Vector3i(a * v.X, a * v.Y, a * v.Z);
        }

        public static Vector3d Divide(Vector3d v, double a)
        {
            return new Vector3d(v.X / a, v.Y / a, v.Z / a);
        }

        public static Vector3f Divide(Vector3f v, float a)
        {
            return new Vector3f(v.X / a, v.Y / a, v.Z / a);
        }

        public static Vector3f Divide(Vector3i v, int a)
        {
            return new Vector3f(v.X / (float) a, v.Y / (float) a, v.Z / (float) a);
        }

        public static Vector3d Normalize(Vector3d v)
        {
            var a = Length(v);
            return new Vector3d(v.X / a, v.Y / a, v.Z / a);
        }

        public static Vector3f Normalize(Vector3f v)
        {
            var a = Length(v);
            return new Vector3f(v.X / a, v.Y / a, v.Z / a);
        }

        public static Vector3f Normalize(Vector3i v)
        {
            var a = Length(v);
            return new Vector3f(v.X / a, v.Y / a, v.Z / a);
        }

        public static Vector3d Negate(Vector3d v)
        {
            return new Vector3d(-v.X, -v.Y, -v.Z);
        }

        public static Vector3f Negate(Vector3f v)
        {
            return new Vector3f(-v.X, -v.Y, -v.Z);
        }

        public static Vector3i Negate(Vector3i v)
        {
            return new Vector3i(-v.X, -v.Y, -v.Z);
        }

        public static Vector3d Cross(Vector3d v1, Vector3d v2)
        {
            return new Vector3d(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
        }

        public static Vector3f Cross(Vector3f v1, Vector3f v2)
        {
            return new Vector3f(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
        }

        public static Vector3i Cross(Vector3i v1, Vector3i v2)
        {
            return new Vector3i(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
        }

        public static Matrix3d Multiply(Matrix3d m, double a)
        {
            return new Matrix3d(
                m.M11 * a, m.M12 * a, m.M13 * a,
                m.M21 * a, m.M22 * a, m.M23 * a,
                m.M31 * a, m.M32 * a, m.M33 * a);
        }

        public static Matrix3f Multiply(Matrix3f m, float a)
        {
            return new Matrix3f(
                m.M11 * a, m.M12 * a, m.M13 * a,
                m.M21 * a, m.M22 * a, m.M23 * a,
                m.M31 * a, m.M32 * a, m.M33 * a);
        }

        public static Matrix3i Multiply(Matrix3i m, int a)
        {
            return new Matrix3i(
                m.M11 * a, m.M12 * a, m.M13 * a,
                m.M21 * a, m.M22 * a, m.M23 * a,
                m.M31 * a, m.M32 * a, m.M33 * a);
        }

        public static Matrix3d Divide(Matrix3d m, double a)
        {
            return new Matrix3d(
                m.M11 / a, m.M12 / a, m.M13 / a,
                m.M21 / a, m.M22 / a, m.M23 / a,
                m.M31 / a, m.M32 / a, m.M33 / a);
        }

        public static Matrix3f Divide(Matrix3f m, float a)
        {
            return new Matrix3f(
                m.M11 / a, m.M12 / a, m.M13 / a,
                m.M21 / a, m.M22 / a, m.M23 / a,
                m.M31 / a, m.M32 / a, m.M33 / a);
        }

        public static Matrix3f Divide(Matrix3i m, int a)
        {
            return new Matrix3f(
                m.M11 / (float) a, m.M12 / (float) a, m.M13 / (float) a,
                m.M21 / (float) a, m.M22 / (float) a, m.M23 / (float) a,
                m.M31 / (float) a, m.M32 / (float) a, m.M33 / (float) a);
        }

        public static Matrix3d Add(Matrix3d m1, Matrix3d m2)
        {
            return new Matrix3d(
                m1.M11 + m2.M11, m1.M12 + m2.M12, m1.M13 + m2.M13,
                m1.M21 + m2.M21, m1.M22 + m2.M22, m1.M23 + m2.M23,
                m1.M31 + m2.M31, m1.M32 + m2.M32, m1.M33 + m2.M33);
        }

        public static Matrix3f Add(Matrix3f m1, Matrix3f m2)
        {
            return new Matrix3f(
                m1.M11 + m2.M11, m1.M12 + m2.M12, m1.M13 + m2.M13,
                m1.M21 + m2.M21, m1.M22 + m2.M22, m1.M23 + m2.M23,
                m1.M31 + m2.M31, m1.M32 + m2.M32, m1.M33 + m2.M33);
        }

        public static Matrix3i Add(Matrix3i m1, Matrix3i m2)
        {
            return new Matrix3i(
                m1.M11 + m2.M11, m1.M12 + m2.M12, m1.M13 + m2.M13,
                m1.M21 + m2.M21, m1.M22 + m2.M22, m1.M23 + m2.M23,
                m1.M31 + m2.M31, m1.M32 + m2.M32, m1.M33 + m2.M33);
        }

        public static Matrix3d Subtract(Matrix3d m1, Matrix3d m2)
        {
            return new Matrix3d(
                m1.M11 - m2.M11, m1.M12 - m2.M12, m1.M13 - m2.M13,
                m1.M21 - m2.M21, m1.M22 - m2.M22, m1.M23 - m2.M23,
                m1.M31 - m2.M31, m1.M32 - m2.M32, m1.M33 - m2.M33);
        }

        public static Matrix3f Subtract(Matrix3f m1, Matrix3f m2)
        {
            return new Matrix3f(
                m1.M11 - m2.M11, m1.M12 - m2.M12, m1.M13 - m2.M13,
                m1.M21 - m2.M21, m1.M22 - m2.M22, m1.M23 - m2.M23,
                m1.M31 - m2.M31, m1.M32 - m2.M32, m1.M33 - m2.M33);
        }

        public static Matrix3i Subtract(Matrix3i m1, Matrix3i m2)
        {
            return new Matrix3i(
                m1.M11 - m2.M11, m1.M12 - m2.M12, m1.M13 - m2.M13,
                m1.M21 - m2.M21, m1.M22 - m2.M22, m1.M23 - m2.M23,
                m1.M31 - m2.M31, m1.M32 - m2.M32, m1.M33 - m2.M33);
        }

        public static double Determinant(Matrix3d m)
        {
            return m.M11 * m.M22 * m.M33 + m.M12 * m.M23 * m.M31 +
                   m.M21 * m.M32 * m.M13 - m.M31 * m.M22 * m.M13 -
                   m.M21 * m.M12 * m.M33 - m.M32 * m.M23 * m.M11;
        }

        public static float Determinant(Matrix3f m)
        {
            return m.M11 * m.M22 * m.M33 + m.M12 * m.M23 * m.M31 +
                   m.M21 * m.M32 * m.M13 - m.M31 * m.M22 * m.M13 -
                   m.M21 * m.M12 * m.M33 - m.M32 * m.M23 * m.M11;
        }

        public static int Determinant(Matrix3i m)
        {
            return m.M11 * m.M22 * m.M33 + m.M12 * m.M23 * m.M31 + 
                   m.M21 * m.M32 * m.M13 - m.M31 * m.M22 * m.M13 -
                   m.M21 * m.M12 * m.M33 - m.M32 * m.M23 * m.M11;
        }

        public static Matrix3d Multiply(Matrix3d m1, Matrix3d m2)
        {
            return new Matrix3d(
                m1.M11 * m2.M11 + m1.M12 * m2.M21 + m1.M13 * m2.M31,
                m1.M11 * m2.M12 + m1.M12 * m2.M22 + m1.M13 * m2.M32,
                m1.M11 * m2.M13 + m1.M12 * m2.M23 + m1.M13 * m2.M33,
                m1.M21 * m2.M11 + m1.M22 * m2.M21 + m1.M23 * m2.M31,
                m1.M21 * m2.M12 + m1.M22 * m2.M22 + m1.M23 * m2.M32,
                m1.M21 * m2.M13 + m1.M22 * m2.M23 + m1.M23 * m2.M33,
                m1.M31 * m2.M11 + m1.M32 * m2.M21 + m1.M33 * m2.M31,
                m1.M31 * m2.M12 + m1.M32 * m2.M22 + m1.M33 * m2.M32,
                m1.M31 * m2.M13 + m1.M32 * m2.M23 + m1.M33 * m2.M33);
        }

        public static Matrix3f Multiply(Matrix3f m1, Matrix3f m2)
        {
            return new Matrix3f(
                m1.M11 * m2.M11 + m1.M12 * m2.M21 + m1.M13 * m2.M31,
                m1.M11 * m2.M12 + m1.M12 * m2.M22 + m1.M13 * m2.M32,
                m1.M11 * m2.M13 + m1.M12 * m2.M23 + m1.M13 * m2.M33,
                m1.M21 * m2.M11 + m1.M22 * m2.M21 + m1.M23 * m2.M31,
                m1.M21 * m2.M12 + m1.M22 * m2.M22 + m1.M23 * m2.M32,
                m1.M21 * m2.M13 + m1.M22 * m2.M23 + m1.M23 * m2.M33,
                m1.M31 * m2.M11 + m1.M32 * m2.M21 + m1.M33 * m2.M31,
                m1.M31 * m2.M12 + m1.M32 * m2.M22 + m1.M33 * m2.M32,
                m1.M31 * m2.M13 + m1.M32 * m2.M23 + m1.M33 * m2.M33);
        }

        public static Matrix3i Multiply(Matrix3i m1, Matrix3i m2)
        {
            return new Matrix3i(
                m1.M11 * m2.M11 + m1.M12 * m2.M21 + m1.M13 * m2.M31,
                m1.M11 * m2.M12 + m1.M12 * m2.M22 + m1.M13 * m2.M32,
                m1.M11 * m2.M13 + m1.M12 * m2.M23 + m1.M13 * m2.M33,
                m1.M21 * m2.M11 + m1.M22 * m2.M21 + m1.M23 * m2.M31,
                m1.M21 * m2.M12 + m1.M22 * m2.M22 + m1.M23 * m2.M32,
                m1.M21 * m2.M13 + m1.M22 * m2.M23 + m1.M23 * m2.M33,
                m1.M31 * m2.M11 + m1.M32 * m2.M21 + m1.M33 * m2.M31,
                m1.M31 * m2.M12 + m1.M32 * m2.M22 + m1.M33 * m2.M32,
                m1.M31 * m2.M13 + m1.M32 * m2.M23 + m1.M33 * m2.M33);
        }

        public static Matrix3d Invert(Matrix3d m)
        {
            var st = new Matrix3d(
                m.M22 * m.M33 - m.M23 * m.M32, m.M13 * m.M32 - m.M12 * m.M33, m.M12 * m.M23 - m.M22 * m.M13,
                m.M23 * m.M31 - m.M21 * m.M33, m.M11 * m.M33 - m.M13 * m.M31, m.M13 * m.M21 - m.M11 * m.M23,
                m.M21 * m.M32 - m.M22 * m.M31, m.M12 * m.M31 - m.M11 * m.M32, m.M11 * m.M22 - m.M12 * m.M21);
            return Divide(st, Determinant(m));
        }

        public static Matrix3f Invert(Matrix3f m)
        {
            var st = new Matrix3f(
                m.M22 * m.M33 - m.M23 * m.M32, m.M13 * m.M32 - m.M12 * m.M33, m.M12 * m.M23 - m.M22 * m.M13,
                m.M23 * m.M31 - m.M21 * m.M33, m.M11 * m.M33 - m.M13 * m.M31, m.M13 * m.M21 - m.M11 * m.M23,
                m.M21 * m.M32 - m.M22 * m.M31, m.M12 * m.M31 - m.M11 * m.M32, m.M11 * m.M22 - m.M12 * m.M21);
            return Divide(st, Determinant(m));
        }

        public static Matrix3f Invert(Matrix3i m)
        {
            var st = new Matrix3i(
                m.M22 * m.M33 - m.M23 * m.M32, m.M13 * m.M32 - m.M12 * m.M33, m.M12 * m.M23 - m.M22 * m.M13,
                m.M23 * m.M31 - m.M21 * m.M33, m.M11 * m.M33 - m.M13 * m.M31, m.M13 * m.M21 - m.M11 * m.M23,
                m.M21 * m.M32 - m.M22 * m.M31, m.M12 * m.M31 - m.M11 * m.M32, m.M11 * m.M22 - m.M12 * m.M21);
            return Divide(st, Determinant(m));
        }

        public static Vector3d Transform(Matrix3d m, Vector3d v)
        {
            return new Vector3d(
                m.M11 * v.X + m.M12 * v.Y + m.M13 * v.Z,
                m.M21 * v.X + m.M22 * v.Y + m.M23 * v.Z,
                m.M31 * v.X + m.M32 * v.Y + m.M33 * v.Z);
        }

        public static Vector3f Transform(Matrix3f m, Vector3f v)
        {
            return new Vector3f(
                m.M11 * v.X + m.M12 * v.Y + m.M13 * v.Z,
                m.M21 * v.X + m.M22 * v.Y + m.M23 * v.Z,
                m.M31 * v.X + m.M32 * v.Y + m.M33 * v.Z);
        }

        public static Vector3i Transform(Matrix3i m, Vector3i v)
        {
            return new Vector3i(
                m.M11 * v.X + m.M12 * v.Y + m.M13 * v.Z,
                m.M21 * v.X + m.M22 * v.Y + m.M23 * v.Z,
                m.M31 * v.X + m.M32 * v.Y + m.M33 * v.Z);
        }
    }
}

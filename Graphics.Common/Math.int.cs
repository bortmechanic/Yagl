/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Viktor Kalmuk, Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/
namespace Yagl.Graphics
{
    public partial class Math
    {
        //Length Vector2
        public static float Length(Vector2i v)
        {
            return Sqrt(v.X * v.X + v.Y * v.Y);
        }

        //Length Vector3
        public static float Length(Vector3i v)
        {
            return Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);
        }

        //Dot Vector2
        public static int Dot(Vector2i v1, Vector2i v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        //Dot Vector3
        public static int Dot(Vector3i v1, Vector3i v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        //Add Vector2
        public static Vector2i Add(Vector2i v1, Vector2i v2)
        {
            return new Vector2i(v1.X + v2.X, v1.Y + v2.Y);
        }

        //Add Vector3
        public static Vector3i Add(Vector3i v1, Vector3i v2)
        {
            return new Vector3i(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        //Subtract Vector2
        public static Vector2i Subtract(Vector2i v1, Vector2i v2)
        {
            return new Vector2i(v1.X - v2.X, v1.Y - v2.Y);
        }

        //Subtract Vector3
        public static Vector3i Subtract(Vector3i v1, Vector3i v2)
        {
            return new Vector3i(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        //Multiply Vector2
        public static Vector2i Multiply(Vector2i v, int a)
        {
            return new Vector2i(a * v.X, a * v.Y);
        }

        //Multiply Vector3
        public static Vector3i Multiply(Vector3i v, int a)
        {
            return new Vector3i(a * v.X, a * v.Y, a * v.Z);
        }

        //Divide Vector2(try..catch a!=0)
        public static Vector2f Divide(Vector2i v, int a)
        {
            return new Vector2f(v.X / (float) a, v.Y / (float) a);
        }

        //Divide Vector3(try..catch a!=0)
        public static Vector3f Divide(Vector3i v, int a)
        {
            return new Vector3f(v.X / (float) a, v.Y / (float) a, v.Z / (float) a);
        }

        //Normalize Vector2(try..catch Length!=0)
        public static Vector2f Normalize(Vector2i v)
        {
            float a = Length(v);
            return new Vector2f(v.X / a, v.Y / a);
        }

        //Normalize Vector3(try..catch Length!=0)
        public static Vector3f Normalize(Vector3i v)
        {
            float a = Length(v);
            return new Vector3f(v.X / a, v.Y / a, v.Z / a);
        }

        //Negative Vector2
        public static Vector2i Negate(Vector2i v)
        {
            return new Vector2i(-v.X, -v.Y);
        }

        //Negative Vector3
        public static Vector3i Negate(Vector3i v)
        {
            return new Vector3i(-v.X, -v.Y, -v.Z);
        }

        //Cross Vector3
        public static Vector3i Cross(Vector3i v1, Vector3i v2)
        {
            return new Vector3i(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
        }

        //Multiply Matrix2
        public static Matrix2i Multiply(Matrix2i m, int a)
        {
            return new Matrix2i(m.M11 * a, m.M12 * a,
                                m.M21 * a, m.M22 * a);
        }

        //Multiply Matrix3
        public static Matrix3i Multiply(Matrix3i m, int a)
        {
            return new Matrix3i(m.M11 * a, m.M12 * a, m.M13 * a,
                                m.M21 * a, m.M22 * a, m.M23 * a,
                                m.M31 * a, m.M32 * a, m.M33 * a);
        }

        //Multiply Matrix4
        public static Matrix4i Multiply(Matrix4i m, int a)
        {
            return new Matrix4i(m.M11 * a, m.M12 * a, m.M13 * a, m.M14 * a,
                                m.M21 * a, m.M22 * a, m.M23 * a, m.M24 * a,
                                m.M31 * a, m.M32 * a, m.M33 * a, m.M34 * a,
                                m.M41 * a, m.M42 * a, m.M43 * a, m.M44 * a);
        }

        //Divide Matrix2(try..catch a!=0)
        public static Matrix2f Divide(Matrix2i m, int a)
        {
            return new Matrix2f(m.M11 / (float) a, m.M12 / (float) a,
                                m.M21 / (float) a, m.M22 / (float) a);
        }

        //Divide Matrix3(try..catch a!=0)
        public static Matrix3f Divide(Matrix3i m, int a)
        {
            return new Matrix3f(m.M11 / (float) a, m.M12 / (float) a, m.M13 / (float) a,
                                m.M21 / (float) a, m.M22 / (float) a, m.M23 / (float) a,
                                m.M31 / (float) a, m.M32 / (float) a, m.M33 / (float) a);
        }

        //Divide Matrix4(try..catch a!=0)
        public static Matrix4f Divide(Matrix4i m, int a)
        {
            return new Matrix4f(m.M11 / (float) a, m.M12 / (float) a, m.M13 / (float) a, m.M14 / (float) a,
                                m.M21 / (float) a, m.M22 / (float) a, m.M23 / (float) a, m.M24 / (float) a,
                                m.M31 / (float) a, m.M32 / (float) a, m.M33 / (float) a, m.M34 / (float) a,
                                m.M41 / (float) a, m.M42 / (float) a, m.M43 / (float) a, m.M44 / (float) a);
        }

        //Add Matrix2
        public static Matrix2i Add(Matrix2i m1, Matrix2i m2)
        {
            return new Matrix2i(m1.M11 + m2.M11, m1.M12 + m2.M12,
                                m1.M21 + m2.M21, m1.M22 + m2.M22);
        }

        //Add Matrix3
        public static Matrix3i Add(Matrix3i m1, Matrix3i m2)
        {
            return new Matrix3i(m1.M11 + m2.M11, m1.M12 + m2.M12, m1.M13 + m2.M13,
                                m1.M21 + m2.M21, m1.M22 + m2.M22, m1.M23 + m2.M23,
                                m1.M31 + m2.M31, m1.M32 + m2.M32, m1.M33 + m2.M33);
        }

        //Add Matrix4
        public static Matrix4i Add(Matrix4i m1, Matrix4i m2)
        {
            return new Matrix4i(m1.M11 + m2.M11, m1.M12 + m2.M12, m1.M13 + m2.M13, m1.M14 + m2.M14,
                                m1.M21 + m2.M21, m1.M22 + m2.M22, m1.M23 + m2.M23, m1.M24 + m2.M24,
                                m1.M31 + m2.M31, m1.M32 + m2.M32, m1.M33 + m2.M33, m1.M34 + m2.M34,
                                m1.M41 + m2.M41, m1.M42 + m2.M42, m1.M43 + m2.M43, m1.M44 + m2.M44);
        }

        //Subtract Matrix2
        public static Matrix2i Subtract(Matrix2i m1, Matrix2i m2)
        {
            return new Matrix2i(m1.M11 - m2.M11, m1.M12 - m2.M12,
                                m1.M21 - m2.M21, m1.M22 - m2.M22);
        }

        //Subtract Matrix3
        public static Matrix3i Subtract(Matrix3i m1, Matrix3i m2)
        {
            return new Matrix3i(m1.M11 - m2.M11, m1.M12 - m2.M12, m1.M13 - m2.M13,
                                m1.M21 - m2.M21, m1.M22 - m2.M22, m1.M23 - m2.M23,
                                m1.M31 - m2.M31, m1.M32 - m2.M32, m1.M33 - m2.M33);
        }

        //Subtract Matrix4
        public static Matrix4i Subtract(Matrix4i m1, Matrix4i m2)
        {
            return new Matrix4i(m1.M11 - m2.M11, m1.M12 - m2.M12, m1.M13 - m2.M13, m1.M14 - m2.M14,
                                m1.M21 - m2.M21, m1.M22 - m2.M22, m1.M23 - m2.M23, m1.M24 - m2.M24,
                                m1.M31 - m2.M31, m1.M32 - m2.M32, m1.M33 - m2.M33, m1.M34 - m2.M34,
                                m1.M41 - m2.M41, m1.M42 - m2.M42, m1.M43 - m2.M43, m1.M44 - m2.M44);
        }

        //Determinant Matrix2
        public static int Determinant(Matrix2i m)
        {
            return m.M11 * m.M22 - m.M21 * m.M12;
        }

        //Determinant Matrix3
        public static int Determinant(Matrix3i m)
        {
            return m.M11 * m.M22 * m.M33 + m.M12 * m.M23 * m.M31 + m.M21 * m.M32 * m.M13 - m.M31 * m.M22 * m.M13 - m.M21 * m.M12 * m.M33 - m.M32 * m.M23 * m.M11;
        }

        //Determinant Matrix4
        public static int Determinant(Matrix4i m)
        {
            Matrix3i a = new Matrix3i(m.M12, m.M13, m.M14,
                                      m.M22, m.M23, m.M24,
                                      m.M32, m.M33, m.M34);

            Matrix3i b = new Matrix3i(m.M11, m.M13, m.M14,
                                      m.M21, m.M23, m.M24,
                                      m.M31, m.M33, m.M34);

            Matrix3i c = new Matrix3i(m.M11, m.M12, m.M14,
                                      m.M21, m.M22, m.M24,
                                      m.M31, m.M32, m.M34);

            Matrix3i d = new Matrix3i(m.M11, m.M12, m.M13,
                                      m.M21, m.M22, m.M23,
                                      m.M31, m.M32, m.M33);

            return -m.M41 * Determinant(a) + m.M42 * Determinant(b) - m.M43 * Determinant(c) + m.M44 * Determinant(d);
        }

        //Multiply Matrix2
        public static Matrix2i Multiply(Matrix2i m1, Matrix2i m2)
        {
            return new Matrix2i(
            m1.M11 * m2.M11 + m1.M12 * m2.M21, m1.M11 * m2.M12 + m1.M12 * m2.M22,
            m1.M21 * m2.M11 + m1.M22 * m2.M21, m1.M21 * m2.M12 + m1.M22 * m2.M22);
        }

        //Multiply Matrix3
        public static Matrix3i Multiply(Matrix3i m1, Matrix3i m2)
        {
            return new Matrix3i(
            m1.M11 * m2.M11 + m1.M12 * m2.M21 + m1.M13 * m2.M31, m1.M11 * m2.M12 + m1.M12 * m2.M22 + m1.M13 * m2.M32, m1.M11 * m2.M13 + m1.M12 * m2.M23 + m1.M13 * m2.M33,
            m1.M21 * m2.M11 + m1.M22 * m2.M21 + m1.M23 * m2.M31, m1.M21 * m2.M12 + m1.M22 * m2.M22 + m1.M23 * m2.M32, m1.M21 * m2.M13 + m1.M22 * m2.M23 + m1.M23 * m2.M33,
            m1.M31 * m2.M11 + m1.M32 * m2.M21 + m1.M33 * m2.M31, m1.M31 * m2.M12 + m1.M32 * m2.M22 + m1.M33 * m2.M32, m1.M31 * m2.M13 + m1.M32 * m2.M23 + m1.M33 * m2.M33);
        }

        //Multiply Matrix4
        public static Matrix4i Multiply(Matrix4i m1, Matrix4i m2)
        {
            return new Matrix4i(
            m1.M11 * m2.M11 + m1.M12 * m2.M21 + m1.M13 * m2.M31 + m1.M14 * m2.M41, m1.M11 * m2.M12 + m1.M12 * m2.M22 + m1.M13 * m2.M32 + m1.M14 * m2.M42, m1.M11 * m2.M13 + m1.M12 * m2.M23 + m1.M13 * m2.M33 + m1.M14 * m2.M43, m1.M11 * m2.M14 + m1.M12 * m2.M24 + m1.M13 * m2.M34 + m1.M14 * m2.M44,
            m1.M21 * m2.M11 + m1.M22 * m2.M21 + m1.M23 * m2.M31 + m1.M24 * m2.M41, m1.M21 * m2.M12 + m1.M22 * m2.M22 + m1.M23 * m2.M32 + m1.M24 * m2.M42, m1.M21 * m2.M13 + m1.M22 * m2.M23 + m1.M23 * m2.M33 + m1.M24 * m2.M43, m1.M21 * m2.M14 + m1.M22 * m2.M24 + m1.M23 * m2.M34 + m1.M24 * m2.M44,
            m1.M31 * m2.M11 + m1.M32 * m2.M21 + m1.M33 * m2.M31 + m1.M34 * m2.M41, m1.M31 * m2.M12 + m1.M32 * m2.M22 + m1.M33 * m2.M32 + m1.M34 * m2.M42, m1.M31 * m2.M13 + m1.M32 * m2.M23 + m1.M33 * m2.M33 + m1.M34 * m2.M43, m1.M31 * m2.M14 + m1.M32 * m2.M24 + m1.M33 * m2.M34 + m1.M34 * m2.M44,
            m1.M41 * m2.M11 + m1.M42 * m2.M21 + m1.M43 * m2.M31 + m1.M44 * m2.M41, m1.M41 * m2.M12 + m1.M42 * m2.M22 + m1.M43 * m2.M32 + m1.M44 * m2.M42, m1.M41 * m2.M13 + m1.M42 * m2.M23 + m1.M43 * m2.M33 + m1.M44 * m2.M43, m1.M41 * m2.M14 + m1.M42 * m2.M24 + m1.M43 * m2.M34 + m1.M44 * m2.M44);
        }

        //Invert Matrix2
        public static Matrix2f Invert(Matrix2i m)
        {
            Matrix2i St = new Matrix2i(m.M22, -m.M12,
                                       -m.M21, m.M11);

            return Divide(St, Determinant(m));
        }

        //Invert Matrix3
        public static Matrix3f Invert(Matrix3i m)
        {
            Matrix3i St = new Matrix3i(m.M22 * m.M33 - m.M23 * m.M32, m.M13 * m.M32 - m.M12 * m.M33, m.M12 * m.M23 - m.M22 * m.M13,
                                       m.M23 * m.M31 - m.M21 * m.M33, m.M11 * m.M33 - m.M13 * m.M31, m.M13 * m.M21 - m.M11 * m.M23,
                                       m.M21 * m.M32 - m.M22 * m.M31, m.M12 * m.M31 - m.M11 * m.M32, m.M11 * m.M22 - m.M12 * m.M21);

            return Divide(St, Determinant(m));
        }

        //Invert Matrix4
        public static Matrix4f Invert(Matrix4i m)
        {
            Matrix4i St = new Matrix4i(  m.M22 * m.M33 * m.M44 + m.M32 * m.M43 * m.M24 + m.M23 * m.M34 * m.M42 - m.M42 * m.M33 * m.M24 - m.M43 * m.M34 * m.M22 - m.M32 * m.M23 * m.M44,
                                        -m.M12 * m.M33 * m.M44 - m.M32 * m.M43 * m.M14 - m.M13 * m.M34 * m.M42 + m.M42 * m.M33 * m.M14 + m.M43 * m.M34 * m.M12 + m.M32 * m.M13 * m.M44,
                                         m.M12 * m.M23 * m.M44 + m.M22 * m.M43 * m.M14 + m.M13 * m.M24 * m.M42 - m.M42 * m.M23 * m.M14 - m.M43 * m.M24 * m.M12 - m.M22 * m.M13 * m.M44,
                                        -m.M12 * m.M23 * m.M34 - m.M22 * m.M33 * m.M14 - m.M13 * m.M24 * m.M32 + m.M32 * m.M23 * m.M14 + m.M33 * m.M24 * m.M12 + m.M22 * m.M13 * m.M34,

                                        -m.M21 * m.M33 * m.M44 - m.M31 * m.M43 * m.M24 - m.M23 * m.M34 * m.M41 + m.M41 * m.M33 * m.M24 + m.M43 * m.M34 * m.M21 + m.M31 * m.M23 * m.M44,
                                         m.M11 * m.M33 * m.M44 + m.M31 * m.M43 * m.M14 + m.M13 * m.M34 * m.M41 - m.M41 * m.M33 * m.M14 - m.M43 * m.M34 * m.M11 - m.M31 * m.M13 * m.M44,
                                        -m.M11 * m.M23 * m.M44 - m.M21 * m.M43 * m.M14 - m.M13 * m.M24 * m.M41 + m.M41 * m.M23 * m.M14 + m.M43 * m.M24 * m.M11 + m.M21 * m.M13 * m.M44,
                                         m.M11 * m.M23 * m.M34 + m.M21 * m.M33 * m.M14 + m.M13 * m.M24 * m.M31 - m.M31 * m.M23 * m.M14 - m.M33 * m.M24 * m.M11 - m.M21 * m.M13 * m.M34,

                                         m.M21 * m.M32 * m.M44 + m.M31 * m.M42 * m.M24 + m.M22 * m.M34 * m.M41 - m.M41 * m.M32 * m.M24 - m.M42 * m.M34 * m.M21 - m.M31 * m.M22 * m.M44,
                                        -m.M11 * m.M32 * m.M44 - m.M31 * m.M42 * m.M14 - m.M12 * m.M34 * m.M41 + m.M41 * m.M32 * m.M14 + m.M42 * m.M34 * m.M11 + m.M31 * m.M12 * m.M44,
                                         m.M11 * m.M22 * m.M44 + m.M21 * m.M42 * m.M14 + m.M12 * m.M24 * m.M41 - m.M41 * m.M22 * m.M14 - m.M42 * m.M24 * m.M11 - m.M21 * m.M12 * m.M44,
                                        -m.M11 * m.M22 * m.M34 - m.M21 * m.M32 * m.M14 - m.M12 * m.M24 * m.M31 + m.M31 * m.M22 * m.M14 + m.M32 * m.M24 * m.M11 + m.M21 * m.M12 * m.M34,

                                        -m.M21 * m.M32 * m.M43 - m.M31 * m.M42 * m.M23 - m.M22 * m.M33 * m.M41 + m.M41 * m.M32 * m.M23 + m.M42 * m.M33 * m.M21 + m.M31 * m.M22 * m.M43,
                                         m.M11 * m.M32 * m.M43 + m.M31 * m.M42 * m.M13 + m.M12 * m.M33 * m.M41 - m.M41 * m.M32 * m.M13 - m.M42 * m.M33 * m.M11 - m.M31 * m.M12 * m.M43,
                                        -m.M11 * m.M22 * m.M43 - m.M21 * m.M42 * m.M13 - m.M12 * m.M23 * m.M41 + m.M41 * m.M22 * m.M13 + m.M42 * m.M23 * m.M11 + m.M21 * m.M12 * m.M43,
                                         m.M11 * m.M22 * m.M33 + m.M12 * m.M23 * m.M31 + m.M21 * m.M32 * m.M13 - m.M31 * m.M22 * m.M13 - m.M21 * m.M12 * m.M33 - m.M32 * m.M23 * m.M11);

            return Divide(St, Determinant(m));
        }

        public static Vector4i Transform(Matrix4i m, Vector4i v)
        {
            return new Vector4i(m.M11 * v.X + m.M12 * v.Y + m.M13 * v.Z + m.M14 * v.S,
                                m.M21 * v.X + m.M22 * v.Y + m.M23 * v.Z + m.M24 * v.S,
                                m.M31 * v.X + m.M32 * v.Y + m.M33 * v.Z + m.M34 * v.S,
                                m.M41 * v.X + m.M42 * v.Y + m.M43 * v.Z + m.M44 * v.S);
        }

        public static Vector3i Transform(Matrix3i m, Vector3i v)
        {
            return new Vector3i(m.M11 * v.X + m.M12 * v.Y + m.M13 * v.Z,
                                m.M21 * v.X + m.M22 * v.Y + m.M23 * v.Z,
                                m.M31 * v.X + m.M32 * v.Y + m.M33 * v.Z);
        }
    }
}

/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Viktor Kalmuk.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

namespace Yagl.Graphics
{
    public partial class Math
    {
        public static Matrix4d Multiply(Matrix4d m, double a)
        {
            return new Matrix4d(m.M11 * a, m.M12 * a, m.M13 * a, m.M14 * a,
                m.M21 * a, m.M22 * a, m.M23 * a, m.M24 * a,
                m.M31 * a, m.M32 * a, m.M33 * a, m.M34 * a,
                m.M41 * a, m.M42 * a, m.M43 * a, m.M44 * a);
        }

        public static Matrix4f Multiply(Matrix4f m, float a)
        {
            return new Matrix4f(m.M11 * a, m.M12 * a, m.M13 * a, m.M14 * a,
                m.M21 * a, m.M22 * a, m.M23 * a, m.M24 * a,
                m.M31 * a, m.M32 * a, m.M33 * a, m.M34 * a,
                m.M41 * a, m.M42 * a, m.M43 * a, m.M44 * a);
        }
        
        public static Matrix4i Multiply(Matrix4i m, int a)
        {
            return new Matrix4i(m.M11 * a, m.M12 * a, m.M13 * a, m.M14 * a,
                m.M21 * a, m.M22 * a, m.M23 * a, m.M24 * a,
                m.M31 * a, m.M32 * a, m.M33 * a, m.M34 * a,
                m.M41 * a, m.M42 * a, m.M43 * a, m.M44 * a);
        }
        
        public static Matrix4d Divide(Matrix4d m, double a)
        {
            return new Matrix4d(m.M11 / a, m.M12 / a, m.M13 / a, m.M14 / a,
                m.M21 / a, m.M22 / a, m.M23 / a, m.M24 / a,
                m.M31 / a, m.M32 / a, m.M33 / a, m.M34 / a,
                m.M41 / a, m.M42 / a, m.M43 / a, m.M44 / a);
        }

        public static Matrix4f Divide(Matrix4f m, float a)
        {
            return new Matrix4f(m.M11 / a, m.M12 / a, m.M13 / a, m.M14 / a,
                m.M21 / a, m.M22 / a, m.M23 / a, m.M24 / a,
                m.M31 / a, m.M32 / a, m.M33 / a, m.M34 / a,
                m.M41 / a, m.M42 / a, m.M43 / a, m.M44 / a);
        }
        
        public static Matrix4f Divide(Matrix4i m, int a)
        {
            return new Matrix4f(m.M11 / (float) a, m.M12 / (float) a, m.M13 / (float) a, m.M14 / (float) a,
                m.M21 / (float) a, m.M22 / (float) a, m.M23 / (float) a, m.M24 / (float) a,
                m.M31 / (float) a, m.M32 / (float) a, m.M33 / (float) a, m.M34 / (float) a,
                m.M41 / (float) a, m.M42 / (float) a, m.M43 / (float) a, m.M44 / (float) a);
        }
        
        public static Matrix4d Add(Matrix4d m1, Matrix4d m2)
        {
            return new Matrix4d(m1.M11 + m2.M11, m1.M12 + m2.M12, m1.M13 + m2.M13, m1.M14 + m2.M14,
                m1.M21 + m2.M21, m1.M22 + m2.M22, m1.M23 + m2.M23, m1.M24 + m2.M24,
                m1.M31 + m2.M31, m1.M32 + m2.M32, m1.M33 + m2.M33, m1.M34 + m2.M34,
                m1.M41 + m2.M41, m1.M42 + m2.M42, m1.M43 + m2.M43, m1.M44 + m2.M44);
        }

        public static Matrix4f Add(Matrix4f m1, Matrix4f m2)
        {
            return new Matrix4f(m1.M11 + m2.M11, m1.M12 + m2.M12, m1.M13 + m2.M13, m1.M14 + m2.M14,
                m1.M21 + m2.M21, m1.M22 + m2.M22, m1.M23 + m2.M23, m1.M24 + m2.M24,
                m1.M31 + m2.M31, m1.M32 + m2.M32, m1.M33 + m2.M33, m1.M34 + m2.M34,
                m1.M41 + m2.M41, m1.M42 + m2.M42, m1.M43 + m2.M43, m1.M44 + m2.M44);
        }
        
        public static Matrix4i Add(Matrix4i m1, Matrix4i m2)
        {
            return new Matrix4i(m1.M11 + m2.M11, m1.M12 + m2.M12, m1.M13 + m2.M13, m1.M14 + m2.M14,
                m1.M21 + m2.M21, m1.M22 + m2.M22, m1.M23 + m2.M23, m1.M24 + m2.M24,
                m1.M31 + m2.M31, m1.M32 + m2.M32, m1.M33 + m2.M33, m1.M34 + m2.M34,
                m1.M41 + m2.M41, m1.M42 + m2.M42, m1.M43 + m2.M43, m1.M44 + m2.M44);
        }
        
        public static Matrix4d Subtract(Matrix4d m1, Matrix4d m2)
        {
            return new Matrix4d(m1.M11 - m2.M11, m1.M12 - m2.M12, m1.M13 - m2.M13, m1.M14 - m2.M14,
                m1.M21 - m2.M21, m1.M22 - m2.M22, m1.M23 - m2.M23, m1.M24 - m2.M24,
                m1.M31 - m2.M31, m1.M32 - m2.M32, m1.M33 - m2.M33, m1.M34 - m2.M34,
                m1.M41 - m2.M41, m1.M42 - m2.M42, m1.M43 - m2.M43, m1.M44 - m2.M44);
        }

        public static Matrix4f Subtract(Matrix4f m1, Matrix4f m2)
        {
            return new Matrix4f(m1.M11 - m2.M11, m1.M12 - m2.M12, m1.M13 - m2.M13, m1.M14 - m2.M14,
                m1.M21 - m2.M21, m1.M22 - m2.M22, m1.M23 - m2.M23, m1.M24 - m2.M24,
                m1.M31 - m2.M31, m1.M32 - m2.M32, m1.M33 - m2.M33, m1.M34 - m2.M34,
                m1.M41 - m2.M41, m1.M42 - m2.M42, m1.M43 - m2.M43, m1.M44 - m2.M44);
        }
        
        public static Matrix4i Subtract(Matrix4i m1, Matrix4i m2)
        {
            return new Matrix4i(m1.M11 - m2.M11, m1.M12 - m2.M12, m1.M13 - m2.M13, m1.M14 - m2.M14,
                m1.M21 - m2.M21, m1.M22 - m2.M22, m1.M23 - m2.M23, m1.M24 - m2.M24,
                m1.M31 - m2.M31, m1.M32 - m2.M32, m1.M33 - m2.M33, m1.M34 - m2.M34,
                m1.M41 - m2.M41, m1.M42 - m2.M42, m1.M43 - m2.M43, m1.M44 - m2.M44);
        }
        
        public static double Determinant(Matrix4d m)
        {
            Matrix3d a = new Matrix3d(m.M12, m.M13, m.M14,
                                      m.M22, m.M23, m.M24,
                                      m.M32, m.M33, m.M34);

            Matrix3d b = new Matrix3d(m.M11, m.M13, m.M14,
                                      m.M21, m.M23, m.M24,
                                      m.M31, m.M33, m.M34);

            Matrix3d c = new Matrix3d(m.M11, m.M12, m.M14,
                                      m.M21, m.M22, m.M24,
                                      m.M31, m.M32, m.M34);

            Matrix3d d = new Matrix3d(m.M11, m.M12, m.M13,
                                      m.M21, m.M22, m.M23,
                                      m.M31, m.M32, m.M33);
            
            return -m.M41 * Determinant(a) + m.M42 * Determinant(b) - m.M43 * Determinant(c) + m.M44 * Determinant(d);
        }

        public static float Determinant(Matrix4f m)
        {
            Matrix3f a = new Matrix3f(m.M12, m.M13, m.M14,
                                      m.M22, m.M23, m.M24,
                                      m.M32, m.M33, m.M34);

            Matrix3f b = new Matrix3f(m.M11, m.M13, m.M14,
                                      m.M21, m.M23, m.M24,
                                      m.M31, m.M33, m.M34);

            Matrix3f c = new Matrix3f(m.M11, m.M12, m.M14,
                                      m.M21, m.M22, m.M24,
                                      m.M31, m.M32, m.M34);

            Matrix3f d = new Matrix3f(m.M11, m.M12, m.M13,
                                      m.M21, m.M22, m.M23,
                                      m.M31, m.M32, m.M33);

            return -m.M41 * Determinant(a) + m.M42 * Determinant(b) - m.M43 * Determinant(c) + m.M44 * Determinant(d);
        }
        
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
        
        public static Matrix4d Multiply(Matrix4d m1, Matrix4d m2)
        {
            return new Matrix4d(
            m1.M11 * m2.M11 + m1.M12 * m2.M21 + m1.M13 * m2.M31 + m1.M14 * m2.M41, m1.M11 * m2.M12 + m1.M12 * m2.M22 + m1.M13 * m2.M32 + m1.M14 * m2.M42, m1.M11 * m2.M13 + m1.M12 * m2.M23 + m1.M13 * m2.M33 + m1.M14 * m2.M43, m1.M11 * m2.M14 + m1.M12 * m2.M24 + m1.M13 * m2.M34 + m1.M14 * m2.M44,
            m1.M21 * m2.M11 + m1.M22 * m2.M21 + m1.M23 * m2.M31 + m1.M24 * m2.M41, m1.M21 * m2.M12 + m1.M22 * m2.M22 + m1.M23 * m2.M32 + m1.M24 * m2.M42, m1.M21 * m2.M13 + m1.M22 * m2.M23 + m1.M23 * m2.M33 + m1.M24 * m2.M43, m1.M21 * m2.M14 + m1.M22 * m2.M24 + m1.M23 * m2.M34 + m1.M24 * m2.M44,
            m1.M31 * m2.M11 + m1.M32 * m2.M21 + m1.M33 * m2.M31 + m1.M34 * m2.M41, m1.M31 * m2.M12 + m1.M32 * m2.M22 + m1.M33 * m2.M32 + m1.M34 * m2.M42, m1.M31 * m2.M13 + m1.M32 * m2.M23 + m1.M33 * m2.M33 + m1.M34 * m2.M43, m1.M31 * m2.M14 + m1.M32 * m2.M24 + m1.M33 * m2.M34 + m1.M34 * m2.M44,
            m1.M41 * m2.M11 + m1.M42 * m2.M21 + m1.M43 * m2.M31 + m1.M44 * m2.M41, m1.M41 * m2.M12 + m1.M42 * m2.M22 + m1.M43 * m2.M32 + m1.M44 * m2.M42, m1.M41 * m2.M13 + m1.M42 * m2.M23 + m1.M43 * m2.M33 + m1.M44 * m2.M43, m1.M41 * m2.M14 + m1.M42 * m2.M24 + m1.M43 * m2.M34 + m1.M44 * m2.M44);
        }

        public static Matrix4f Multiply(Matrix4f m1, Matrix4f m2)
        {
            return new Matrix4f(
            m1.M11 * m2.M11 + m1.M12 * m2.M21 + m1.M13 * m2.M31 + m1.M14 * m2.M41, m1.M11 * m2.M12 + m1.M12 * m2.M22 + m1.M13 * m2.M32 + m1.M14 * m2.M42, m1.M11 * m2.M13 + m1.M12 * m2.M23 + m1.M13 * m2.M33 + m1.M14 * m2.M43, m1.M11 * m2.M14 + m1.M12 * m2.M24 + m1.M13 * m2.M34 + m1.M14 * m2.M44,
            m1.M21 * m2.M11 + m1.M22 * m2.M21 + m1.M23 * m2.M31 + m1.M24 * m2.M41, m1.M21 * m2.M12 + m1.M22 * m2.M22 + m1.M23 * m2.M32 + m1.M24 * m2.M42, m1.M21 * m2.M13 + m1.M22 * m2.M23 + m1.M23 * m2.M33 + m1.M24 * m2.M43, m1.M21 * m2.M14 + m1.M22 * m2.M24 + m1.M23 * m2.M34 + m1.M24 * m2.M44,
            m1.M31 * m2.M11 + m1.M32 * m2.M21 + m1.M33 * m2.M31 + m1.M34 * m2.M41, m1.M31 * m2.M12 + m1.M32 * m2.M22 + m1.M33 * m2.M32 + m1.M34 * m2.M42, m1.M31 * m2.M13 + m1.M32 * m2.M23 + m1.M33 * m2.M33 + m1.M34 * m2.M43, m1.M31 * m2.M14 + m1.M32 * m2.M24 + m1.M33 * m2.M34 + m1.M34 * m2.M44,
            m1.M41 * m2.M11 + m1.M42 * m2.M21 + m1.M43 * m2.M31 + m1.M44 * m2.M41, m1.M41 * m2.M12 + m1.M42 * m2.M22 + m1.M43 * m2.M32 + m1.M44 * m2.M42, m1.M41 * m2.M13 + m1.M42 * m2.M23 + m1.M43 * m2.M33 + m1.M44 * m2.M43, m1.M41 * m2.M14 + m1.M42 * m2.M24 + m1.M43 * m2.M34 + m1.M44 * m2.M44);
        }
        
        public static Matrix4i Multiply(Matrix4i m1, Matrix4i m2)
        {
            return new Matrix4i(
                m1.M11 * m2.M11 + m1.M12 * m2.M21 + m1.M13 * m2.M31 + m1.M14 * m2.M41, m1.M11 * m2.M12 + m1.M12 * m2.M22 + m1.M13 * m2.M32 + m1.M14 * m2.M42, m1.M11 * m2.M13 + m1.M12 * m2.M23 + m1.M13 * m2.M33 + m1.M14 * m2.M43, m1.M11 * m2.M14 + m1.M12 * m2.M24 + m1.M13 * m2.M34 + m1.M14 * m2.M44,
                m1.M21 * m2.M11 + m1.M22 * m2.M21 + m1.M23 * m2.M31 + m1.M24 * m2.M41, m1.M21 * m2.M12 + m1.M22 * m2.M22 + m1.M23 * m2.M32 + m1.M24 * m2.M42, m1.M21 * m2.M13 + m1.M22 * m2.M23 + m1.M23 * m2.M33 + m1.M24 * m2.M43, m1.M21 * m2.M14 + m1.M22 * m2.M24 + m1.M23 * m2.M34 + m1.M24 * m2.M44,
                m1.M31 * m2.M11 + m1.M32 * m2.M21 + m1.M33 * m2.M31 + m1.M34 * m2.M41, m1.M31 * m2.M12 + m1.M32 * m2.M22 + m1.M33 * m2.M32 + m1.M34 * m2.M42, m1.M31 * m2.M13 + m1.M32 * m2.M23 + m1.M33 * m2.M33 + m1.M34 * m2.M43, m1.M31 * m2.M14 + m1.M32 * m2.M24 + m1.M33 * m2.M34 + m1.M34 * m2.M44,
                m1.M41 * m2.M11 + m1.M42 * m2.M21 + m1.M43 * m2.M31 + m1.M44 * m2.M41, m1.M41 * m2.M12 + m1.M42 * m2.M22 + m1.M43 * m2.M32 + m1.M44 * m2.M42, m1.M41 * m2.M13 + m1.M42 * m2.M23 + m1.M43 * m2.M33 + m1.M44 * m2.M43, m1.M41 * m2.M14 + m1.M42 * m2.M24 + m1.M43 * m2.M34 + m1.M44 * m2.M44);
        }
        
        public static Matrix4d Invert(Matrix4d m)
        {
            Matrix4d St = new Matrix4d(  m.M22 * m.M33 * m.M44 + m.M32 * m.M43 * m.M24 + m.M23 * m.M34 * m.M42 - m.M42 * m.M33 * m.M24 - m.M43 * m.M34 * m.M22 - m.M32 * m.M23 * m.M44,
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

        public static Matrix4f Invert(Matrix4f m)
        {
            Matrix4f St = new Matrix4f(  m.M22 * m.M33 * m.M44 + m.M32 * m.M43 * m.M24 + m.M23 * m.M34 * m.M42 - m.M42 * m.M33 * m.M24 - m.M43 * m.M34 * m.M22 - m.M32 * m.M23 * m.M44,
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
        
        public static Matrix4f CreateTranslation(float x, float y, float z)
        {
            return new Matrix4f( 1, 0, 0, x,
                                 0, 1, 0, y,
                                 0, 0, 1, z,
                                 0, 0, 0, 1);
        }

        public static Matrix4f CreateRotationX(float a)
        {
            return new Matrix4f(1, 0, 0, 0,
                                 0, Cos(a), -Sin(a), 0,
                                 0, Sin(a), Cos(a), 0,
                                 0, 0, 0, 1);
        }

        public static Matrix4f CreateRotationY(float a)
        {
            return new Matrix4f(Cos(a), 0, Sin(a), 0,
                                 0, 1, 0, 0,
                                 -Sin(a), 0, Cos(a), 0,
                                 0, 0, 0, 1);
        }

        public static Matrix4f CreateRotationZ(float a)
        {
            return new Matrix4f(Cos(a), Sin(a), 0, 0,
                                Sin(a), Cos(a), 0, 0,
                                  0, 0, 1, 0,
                                  0, 0, 0, 1);
        }

        public static Matrix4f CreateScaling(float x, float y, float z)
        {
            return new Matrix4f( x, 0, 0, 0,
                                 0, y, 0, 0,
                                 0, 0, z, 0,
                                 0, 0, 0, 1);
        }

        public static Matrix4f CreateShearX(float a)
        {
            return new Matrix4f( 1, Cos(a)/ Sin(a), 0, 0,
                                 0, 1, 0, 0,
                                 0, 0, 1, 0,
                                 0, 0, 0, 1);
        }

        public static Vector4d Transform(Matrix4d m, Vector4d v)
        {
            return new Vector4d(m.M11 * v.X + m.M12 * v.Y + m.M13 * v.Z + m.M14 * v.S,
                                m.M21 * v.X + m.M22 * v.Y + m.M23 * v.Z + m.M24 * v.S,
                                m.M31 * v.X + m.M32 * v.Y + m.M33 * v.Z + m.M34 * v.S,
                                m.M41 * v.X + m.M42 * v.Y + m.M43 * v.Z + m.M44 * v.S);
        }

        public static Vector4f Transform(Matrix4f m, Vector4f v)
        {
            return new Vector4f(m.M11 * v.X + m.M12 * v.Y + m.M13 * v.Z + m.M14 * v.S,
                                m.M21 * v.X + m.M22 * v.Y + m.M23 * v.Z + m.M24 * v.S,
                                m.M31 * v.X + m.M32 * v.Y + m.M33 * v.Z + m.M34 * v.S,
                                m.M41 * v.X + m.M42 * v.Y + m.M43 * v.Z + m.M44 * v.S);
        }
        
        public static Vector4i Transform(Matrix4i m, Vector4i v)
        {
            return new Vector4i(m.M11 * v.X + m.M12 * v.Y + m.M13 * v.Z + m.M14 * v.S,
                m.M21 * v.X + m.M22 * v.Y + m.M23 * v.Z + m.M24 * v.S,
                m.M31 * v.X + m.M32 * v.Y + m.M33 * v.Z + m.M34 * v.S,
                m.M41 * v.X + m.M42 * v.Y + m.M43 * v.Z + m.M44 * v.S);
        }
    }
}
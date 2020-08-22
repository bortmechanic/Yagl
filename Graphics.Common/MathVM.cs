namespace Yagl.Graphics
{
    class MathVM
    {
        //Length Vector2
        public static double Length(Vector2d v)
        {
            return System.Math.Sqrt(v.X * v.X + v.Y * v.Y );
        }

        public static float Length(Vector2f v)
        {
            return (float)(System.Math.Sqrt(v.X * v.X + v.Y * v.Y ));
        }

        public static float Length(Vector2i v)
        {
            return (float)System.Math.Sqrt(v.X * v.X + v.Y * v.Y );
        }

        //Length Vector3
        public static double Length(Vector3d v)
        {
            return System.Math.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);
        }

        public static float Length(Vector3f v)
        {
            return (float)(System.Math.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z));
        }

        public static float Length(Vector3i v)
        {
            return (float)System.Math.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);
        }

        //Dot Vector2
        public static double Dot(Vector2d v1, Vector2d v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        public static float Dot(Vector2f v1, Vector2f v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y ;
        }

        public static int Dot(Vector2i v1, Vector2i v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y ;
        }
        //Dot Vector3
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

        //Add Vector2
        public static Vector2d Add(Vector2d v1, Vector2d v2)
        {
            Vector2d Add = new Vector2d(v1.X + v2.X, v1.Y + v2.Y);
            return Add;
        }

        public static Vector2f Add(Vector2f v1, Vector2f v2)
        {
            Vector2f Add = new Vector2f(v1.X + v2.X, v1.Y + v2.Y);
            return Add;
        }

        public static Vector2i Add(Vector2i v1, Vector2i v2)
        {
            Vector2i Add = new Vector2i(v1.X + v2.X, v1.Y + v2.Y);
            return Add;
        }

        //Add Vector3
        public static Vector3d Add(Vector3d v1, Vector3d v2)
        {
            Vector3d Add = new Vector3d(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
            return Add;
        }

        public static Vector3f Add(Vector3f v1, Vector3f v2)
        {
            Vector3f Add = new Vector3f(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
            return Add;
        }

        public static Vector3i Add(Vector3i v1, Vector3i v2)
        {
            Vector3i Add = new Vector3i(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
            return Add;
        }

        //Subtract Vector2
        public static Vector2d Subtract(Vector2d v1, Vector2d v2)
        {
            Vector2d Sub = new Vector2d(v1.X - v2.X, v1.Y - v2.Y);
            return Sub;
        }

        public static Vector2f Subtract(Vector2f v1, Vector2f v2)
        {
            Vector2f Sub = new Vector2f(v1.X - v2.X, v1.Y - v2.Y);
            return Sub;
        }

        public static Vector2i Subtract(Vector2i v1, Vector2i v2)
        {
            Vector2i Sub = new Vector2i(v1.X - v2.X, v1.Y - v2.Y);
            return Sub;
        }

        //Subtract Vector3
        public static Vector3d Subtract(Vector3d v1, Vector3d v2)
        {
            Vector3d Sub = new Vector3d(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
            return Sub;
        }

        public static Vector3f Subtract(Vector3f v1, Vector3f v2)
        {
            Vector3f Sub = new Vector3f(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
            return Sub;
        }

        public static Vector3i Subtract(Vector3i v1, Vector3i v2)
        {
            Vector3i Sub = new Vector3i(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
            return Sub;
        }

        //Multiply Vector2
        public static Vector2d Multiply(Vector2d v, double a)
        {
            Vector2d Mult = new Vector2d(a * v.X, a * v.Y);
            return Mult;
        }

        public static Vector2f Multiply(Vector2f v, float a)
        {
            Vector2f Mult = new Vector2f(a * v.X, a * v.Y);
            return Mult;
        }

        public static Vector2i Multiply(Vector2i v, int a)
        {
            Vector2i Mult = new Vector2i(a * v.X, a * v.Y);
            return Mult;
        }

        //Multiply Vector3
        public static Vector3d Multiply(Vector3d v, double a)
        {
            Vector3d Mult = new Vector3d(a * v.X, a * v.Y, a * v.Z);
            return Mult;
        }

        public static Vector3f Multiply(Vector3f v, float a)
        {
            Vector3f Mult = new Vector3f(a * v.X, a * v.Y, a * v.Z);
            return Mult;
        }

        public static Vector3i Multiply(Vector3i v, int a)
        {
            Vector3i Mult = new Vector3i(a * v.X, a * v.Y, a * v.Z);
            return Mult;
        }

        //Divide Vector2
        public static Vector2d Divide(Vector2d v, double a)
        {
            Vector2d Div = new Vector2d(v.X / a, v.Y / a);
            return Div;
        }
        public static Vector2f Divide(Vector2f v, float a)
        {
            Vector2f Div = new Vector2f(v.X / a, v.Y / a);
            return Div;
        }
        public static Vector2f Divide(Vector2i v, int a)
        {
            Vector2f Div = new Vector2f(v.X / a, v.Y / a);
            return Div;
        }
        //Divide Vector3
        public static Vector3d Divide(Vector3d v, double a)
        {
            Vector3d Div = new Vector3d(v.X / a, v.Y / a, v.Z / a);
            return Div;
        }
        public static Vector3f Divide(Vector3f v, float a)
        {
            Vector3f Div = new Vector3f(v.X / a, v.Y / a, v.Z / a);
            return Div;
        }
        public static Vector3f Divide(Vector3i v, int a)
        {
            Vector3f Div = new Vector3f(v.X / a, v.Y / a, v.Z / a);
            return Div;
        }

        //Normalize Vector2
        public static Vector2d Normalize(Vector2d v)
        {
            Vector2d Norm = new Vector2d(v.X / Length(v), v.Y / Length(v));
            return Norm;
        }
        public static Vector2f Normalize(Vector2f v)
        {
            Vector2f Norm = new Vector2f(v.X / Length(v), v.Y / Length(v));
            return Norm;
        }
        public static Vector2f Normalize(Vector2i v)
        {
            Vector2f Norm = new Vector2f(v.X / Length(v), v.Y / Length(v));
            return Norm;
        }
        //Normalize Vector3
        public static Vector3d Normalize(Vector3d v)
        {
            Vector3d Norm = new Vector3d(v.X / Length(v), v.Y / Length(v), v.Z / Length(v));
            return Norm;
        }
        public static Vector3f Normalize(Vector3f v)
        {
            Vector3f Norm = new Vector3f(v.X / Length(v), v.Y / Length(v), v.Z / Length(v));
            return Norm;
        }
        public static Vector3f Normalize(Vector3i v)
        {
            Vector3f Norm = new Vector3f(v.X / Length(v), v.Y / Length(v), v.Z / Length(v));
            return Norm;
        }

        //Negate Vector2
        public static Vector2d Negate(Vector2d v)
        {
            Vector2d Neg = new Vector2d(-v.X, -v.Y);
            return Neg;
        }
        public static Vector2f Negate(Vector2f v)
        {
            Vector2f Neg = new Vector2f(-v.X, -v.Y);
            return Neg;
        }
        public static Vector2i Negate(Vector2i v)
        {
            Vector2i Neg = new Vector2i(-v.X, -v.Y);
            return Neg;
        }

        //Negate Vector3
        public static Vector3d Negate(Vector3d v)
        {
            Vector3d Neg = new Vector3d(-v.X, -v.Y, -v.Z);
            return Neg;
        }
        public static Vector3f Negate(Vector3f v)
        {
            Vector3f Neg = new Vector3f(-v.X, -v.Y, -v.Z);
            return Neg;
        }
        public static Vector3i Negate(Vector3i v)
        {
            Vector3i Neg = new Vector3i(-v.X, -v.Y, -v.Z);
            return Neg;
        }
        
        //Cross Vector3
        public static Vector3d Cross(Vector3d v1, Vector3d v2)
        {
            Vector3d Cro = new Vector3d(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
            return Cro;
        }

        public static Vector3f Cross(Vector3f v1, Vector3f v2)
        {
            Vector3f Cro = new Vector3f(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
            return Cro;
        }

        public static Vector3i Cross(Vector3i v1, Vector3i v2)
        {
            Vector3i Cro = new Vector3i(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
            return Cro;
        }


        //Multiply Matrix2
        public static Matrix2d Multiply(Matrix2d m, double a)
        {
            Matrix2d Mult = new Matrix2d(m.M11*a,m.M12*a,
                                         m.M21*a,m.M22*a);
            return Mult;
        }

        public static Matrix2f Multiply(Matrix2f m, float a)
        {
            Matrix2f Mult = new Matrix2f(m.M11 * a, m.M12 * a,
                                         m.M21 * a, m.M22 * a);
            return Mult;
        }

        public static Matrix2i Multiply(Matrix2i m, int a)
        {
            Matrix2i Mult = new Matrix2i(m.M11 * a, m.M12 * a,
                                         m.M21 * a, m.M22 * a);
            return Mult;
        }
        //Multiply Matrix3
        public static Matrix3d Multiply(Matrix3d m, double a)
        {
            Matrix3d Mult = new Matrix3d(m.M11 * a, m.M12 * a, m.M13 * a,
                                         m.M21 * a, m.M22 * a, m.M23 * a,
                                         m.M31 * a, m.M32 * a, m.M33 * a);
            return Mult;
        }
        public static Matrix3f Multiply(Matrix3f m, float a)
        {
            Matrix3f Mult = new Matrix3f(m.M11 * a, m.M12 * a, m.M13 * a,
                                         m.M21 * a, m.M22 * a, m.M23 * a,
                                         m.M31 * a, m.M32 * a, m.M33 * a);
            return Mult;
        }
        public static Matrix3i Multiply(Matrix3i m, int a)
        {
            Matrix3i Mult = new Matrix3i(m.M11 * a, m.M12 * a, m.M13 * a,
                                         m.M21 * a, m.M22 * a, m.M23 * a,
                                         m.M31 * a, m.M32 * a, m.M33 * a);
            return Mult;
        }

        //Multiply Matrix4
        public static Matrix4d Multiply(Matrix4d m, double a)
        {
            Matrix4d Mult = new Matrix4d(m.M11 * a, m.M12 * a, m.M13 * a, m.M14 * a,
                                         m.M21 * a, m.M22 * a, m.M23 * a, m.M24 * a,
                                         m.M31 * a, m.M32 * a, m.M33 * a, m.M34 * a,
                                         m.M41 * a, m.M42 * a, m.M43 * a, m.M44 * a);
            return Mult;
        }

        public static Matrix4f Multiply(Matrix4f m, float a)
        {
            Matrix4f Mult = new Matrix4f(m.M11 * a, m.M12 * a, m.M13 * a, m.M14 * a,
                                         m.M21 * a, m.M22 * a, m.M23 * a, m.M24 * a,
                                         m.M31 * a, m.M32 * a, m.M33 * a, m.M34 * a,
                                         m.M41 * a, m.M42 * a, m.M43 * a, m.M44 * a);
            return Mult;
        }

        public static Matrix4i Multiply(Matrix4i m, int a)
        {
            Matrix4i Mult = new Matrix4i(m.M11 * a, m.M12 * a, m.M13 * a, m.M14 * a,
                                         m.M21 * a, m.M22 * a, m.M23 * a, m.M24 * a,
                                         m.M31 * a, m.M32 * a, m.M33 * a, m.M34 * a,
                                         m.M41 * a, m.M42 * a, m.M43 * a, m.M44 * a);
            return Mult;
        }

        //Divide Matrix2
        public static Matrix2d Divide(Matrix2d m, double a)
        {
            Matrix2d Div = new Matrix2d(m.M11 / a, m.M12 / a,
                                        m.M21 / a, m.M22 / a);
            return Div;
        }

        public static Matrix2f Divide(Matrix2f m, float a)
        {
            Matrix2f Div = new Matrix2f(m.M11 / a, m.M12 / a,
                                        m.M21 / a, m.M22 / a);
            return Div;
        }

        public static Matrix2f Divide(Matrix2i m, int a)
        {
            Matrix2f Div = new Matrix2f(m.M11 / a, m.M12 / a,
                                        m.M21 / a, m.M22 / a);
            return Div;
        }
        //Divide Matrix3
        public static Matrix3d Divide(Matrix3d m, double a)
        {
            Matrix3d Div = new Matrix3d(m.M11 / a, m.M12 / a, m.M13 / a,
                                        m.M21 / a, m.M22 / a, m.M23 / a,
                                        m.M31 / a, m.M32 / a, m.M33 / a);
            return Div;
        }
        public static Matrix3f Divide(Matrix3f m, float a)
        {
            Matrix3f Div = new Matrix3f(m.M11 / a, m.M12 / a, m.M13 / a,
                                        m.M21 / a, m.M22 / a, m.M23 / a,
                                        m.M31 / a, m.M32 / a, m.M33 / a);
            return Div;
        }
        public static Matrix3f Divide(Matrix3i m, int a)
        {
            Matrix3f Div = new Matrix3f(m.M11 / a, m.M12 / a, m.M13 / a,
                                        m.M21 / a, m.M22 / a, m.M23 / a,
                                        m.M31 / a, m.M32 / a, m.M33 / a);
            return Div;
        }

        //Divide Matrix4
        public static Matrix4d Divide(Matrix4d m, double a)
        {
            Matrix4d Div = new Matrix4d(m.M11 / a, m.M12 / a, m.M13 / a, m.M14 / a,
                                        m.M21 / a, m.M22 / a, m.M23 / a, m.M24 / a,
                                        m.M31 / a, m.M32 / a, m.M33 / a, m.M34 / a,
                                        m.M41 / a, m.M42 / a, m.M43 / a, m.M44 / a);
            return Div;
        }

        public static Matrix4f Divide(Matrix4f m, float a)
        {
            Matrix4f Div = new Matrix4f(m.M11 / a, m.M12 / a, m.M13 / a, m.M14 / a,
                                        m.M21 / a, m.M22 / a, m.M23 / a, m.M24 / a,
                                        m.M31 / a, m.M32 / a, m.M33 / a, m.M34 / a,
                                        m.M41 / a, m.M42 / a, m.M43 / a, m.M44 / a);
            return Div;
        }

        public static Matrix4f Divide(Matrix4i m, int a)
        {
            Matrix4f Div = new Matrix4f(m.M11 / a, m.M12 / a, m.M13 / a, m.M14 / a,
                                        m.M21 / a, m.M22 / a, m.M23 / a, m.M24 / a,
                                        m.M31 / a, m.M32 / a, m.M33 / a, m.M34 / a,
                                        m.M41 / a, m.M42 / a, m.M43 / a, m.M44 / a);
            return Div;
        }

        //Add Matrix2
        public static Matrix2d Add(Matrix2d m1, Matrix2d m2)
        {
            Matrix2d Add = new Matrix2d(m1.M11 + m2.M11, m1.M12 + m2.M12,
                                        m1.M21 + m2.M21, m1.M22 + m2.M22);
            return Add;
        }
        public static Matrix2f Add(Matrix2f m1, Matrix2f m2)
        {
            Matrix2f Add = new Matrix2f(m1.M11 + m2.M11, m1.M12 + m2.M12,
                                        m1.M21 + m2.M21, m1.M22 + m2.M22);
            return Add;
        }

        public static Matrix2i Add(Matrix2i m1, Matrix2i m2)
        {
            Matrix2i Add = new Matrix2i(m1.M11 + m2.M11, m1.M12 + m2.M12,
                                        m1.M21 + m2.M21, m1.M22 + m2.M22);
            return Add;
        }
        //Add Matrix3
        public static Matrix3d Add(Matrix3d m1, Matrix3d m2)
        {
            Matrix3d Add = new Matrix3d(m1.M11 + m2.M11, m1.M12 + m2.M12, m1.M13 + m2.M13,
                                        m1.M21 + m2.M21, m1.M22 + m2.M22, m1.M23 + m2.M23,
                                        m1.M31 + m2.M31, m1.M32 + m2.M32, m1.M33 + m2.M33);
            return Add;
        }
        public static Matrix3f Add(Matrix3f m1, Matrix3f m2)
        {
            Matrix3f Add = new Matrix3f(m1.M11 + m2.M11, m1.M12 + m2.M12, m1.M13 + m2.M13,
                                        m1.M21 + m2.M21, m1.M22 + m2.M22, m1.M23 + m2.M23,
                                        m1.M31 + m2.M31, m1.M32 + m2.M32, m1.M33 + m2.M33);
            return Add;
        }
        public static Matrix3i Add(Matrix3i m1, Matrix3i m2)
        {
            Matrix3i Add = new Matrix3i(m1.M11 + m2.M11, m1.M12 + m2.M12, m1.M13 + m2.M13,
                                        m1.M21 + m2.M21, m1.M22 + m2.M22, m1.M23 + m2.M23,
                                        m1.M31 + m2.M31, m1.M32 + m2.M32, m1.M33 + m2.M33);
            return Add;
        }
        //Add Matrix4
        public static Matrix4d Add(Matrix4d m1, Matrix4d m2)
        {
            Matrix4d Add = new Matrix4d(m1.M11 + m2.M11, m1.M12 + m2.M12, m1.M13 + m2.M13, m1.M14 + m2.M14,
                                        m1.M21 + m2.M21, m1.M22 + m2.M22, m1.M23 + m2.M23, m1.M24 + m2.M24,
                                        m1.M31 + m2.M31, m1.M32 + m2.M32, m1.M33 + m2.M33, m1.M34 + m2.M34,
                                        m1.M41 + m2.M41, m1.M42 + m2.M42, m1.M43 + m2.M43, m1.M44 + m2.M44);
            return Add;
        }

        public static Matrix4f Add(Matrix4f m1, Matrix4f m2)
        {
            Matrix4f Add = new Matrix4f(m1.M11 + m2.M11, m1.M12 + m2.M12, m1.M13 + m2.M13, m1.M14 + m2.M14,
                                        m1.M21 + m2.M21, m1.M22 + m2.M22, m1.M23 + m2.M23, m1.M24 + m2.M24,
                                        m1.M31 + m2.M31, m1.M32 + m2.M32, m1.M33 + m2.M33, m1.M34 + m2.M34,
                                        m1.M41 + m2.M41, m1.M42 + m2.M42, m1.M43 + m2.M43, m1.M44 + m2.M44);
            return Add;
        }
        public static Matrix4i Add(Matrix4i m1, Matrix4i m2)
        {
            Matrix4i Add = new Matrix4i(m1.M11 + m2.M11, m1.M12 + m2.M12, m1.M13 + m2.M13, m1.M14 + m2.M14,
                                        m1.M21 + m2.M21, m1.M22 + m2.M22, m1.M23 + m2.M23, m1.M24 + m2.M24,
                                        m1.M31 + m2.M31, m1.M32 + m2.M32, m1.M33 + m2.M33, m1.M34 + m2.M34,
                                        m1.M41 + m2.M41, m1.M42 + m2.M42, m1.M43 + m2.M43, m1.M44 + m2.M44);
            return Add;
        }

        //Sub Matrix2
        public static Matrix2d Sub(Matrix2d m1, Matrix2d m2)
        {
            Matrix2d Sub = new Matrix2d(m1.M11 - m2.M11, m1.M12 - m2.M12,
                                        m1.M21 - m2.M21, m1.M22 - m2.M22);
            return Sub;
        }
        public static Matrix2f Sub(Matrix2f m1, Matrix2f m2)
        {
            Matrix2f Sub = new Matrix2f(m1.M11 - m2.M11, m1.M12 - m2.M12,
                                        m1.M21 - m2.M21, m1.M22 - m2.M22);
            return Sub;
        }

        public static Matrix2i Sub(Matrix2i m1, Matrix2i m2)
        {
            Matrix2i Sub = new Matrix2i(m1.M11 - m2.M11, m1.M12 - m2.M12,
                                        m1.M21 - m2.M21, m1.M22 - m2.M22);
            return Sub;
        }
        //Sub Matrix3
        public static Matrix3d Sub(Matrix3d m1, Matrix3d m2)
        {
            Matrix3d Sub = new Matrix3d(m1.M11 - m2.M11, m1.M12 - m2.M12, m1.M13 - m2.M13,
                                        m1.M21 - m2.M21, m1.M22 - m2.M22, m1.M23 - m2.M23,
                                        m1.M31 - m2.M31, m1.M32 - m2.M32, m1.M33 - m2.M33);
            return Sub;
        }
        public static Matrix3f Sub(Matrix3f m1, Matrix3f m2)
        {
            Matrix3f Sub = new Matrix3f(m1.M11 - m2.M11, m1.M12 - m2.M12, m1.M13 - m2.M13,
                                        m1.M21 - m2.M21, m1.M22 - m2.M22, m1.M23 - m2.M23,
                                        m1.M31 - m2.M31, m1.M32 - m2.M32, m1.M33 - m2.M33);
            return Sub;
        }
        public static Matrix3i Sub(Matrix3i m1, Matrix3i m2)
        {
            Matrix3i Sub = new Matrix3i(m1.M11 - m2.M11, m1.M12 - m2.M12, m1.M13 - m2.M13,
                                        m1.M21 - m2.M21, m1.M22 - m2.M22, m1.M23 - m2.M23,
                                        m1.M31 - m2.M31, m1.M32 - m2.M32, m1.M33 - m2.M33);
            return Sub;
        }
        //Sub Matrix4
        public static Matrix4d Sub(Matrix4d m1, Matrix4d m2)
        {
            Matrix4d Sub = new Matrix4d(m1.M11 - m2.M11, m1.M12 - m2.M12, m1.M13 - m2.M13, m1.M14 - m2.M14,
                                        m1.M21 - m2.M21, m1.M22 - m2.M22, m1.M23 - m2.M23, m1.M24 - m2.M24,
                                        m1.M31 - m2.M31, m1.M32 - m2.M32, m1.M33 - m2.M33, m1.M34 - m2.M34,
                                        m1.M41 - m2.M41, m1.M42 - m2.M42, m1.M43 - m2.M43, m1.M44 - m2.M44);
            return Sub;
        }

        public static Matrix4f Sub(Matrix4f m1, Matrix4f m2)
        {
            Matrix4f Sub = new Matrix4f(m1.M11 - m2.M11, m1.M12 - m2.M12, m1.M13 - m2.M13, m1.M14 - m2.M14,
                                        m1.M21 - m2.M21, m1.M22 - m2.M22, m1.M23 - m2.M23, m1.M24 - m2.M24,
                                        m1.M31 - m2.M31, m1.M32 - m2.M32, m1.M33 - m2.M33, m1.M34 - m2.M34,
                                        m1.M41 - m2.M41, m1.M42 - m2.M42, m1.M43 - m2.M43, m1.M44 - m2.M44);
            return Sub;
        }
        public static Matrix4i Sub(Matrix4i m1, Matrix4i m2)
        {
            Matrix4i Sub = new Matrix4i(m1.M11 - m2.M11, m1.M12 - m2.M12, m1.M13 - m2.M13, m1.M14 - m2.M14,
                                        m1.M21 - m2.M21, m1.M22 - m2.M22, m1.M23 - m2.M23, m1.M24 - m2.M24,
                                        m1.M31 - m2.M31, m1.M32 - m2.M32, m1.M33 - m2.M33, m1.M34 - m2.M34,
                                        m1.M41 - m2.M41, m1.M42 - m2.M42, m1.M43 - m2.M43, m1.M44 - m2.M44);
            return Sub;
        }

        //Determinant Matrix2
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
        //Determinant Matrix3
        public static double Determinant(Matrix3d m)
        {
            return m.M11 * m.M22 * m.M33 + m.M12 * m.M23 * m.M31 + m.M21 * m.M32 * m.M13 - m.M31 * m.M22 * m.M13 - m.M21 * m.M12 * m.M33 - m.M32 * m.M23 * m.M11;
        }
        public static float Determinant(Matrix3f m)
        {
            return m.M11 * m.M22 * m.M33 + m.M12 * m.M23 * m.M31 + m.M21 * m.M32 * m.M13 - m.M31 * m.M22 * m.M13 - m.M21 * m.M12 * m.M33 - m.M32 * m.M23 * m.M11;
        }
        public static int Determinant(Matrix3i m)
        {
            return m.M11 * m.M22 * m.M33 + m.M12 * m.M23 * m.M31 + m.M21 * m.M32 * m.M13 - m.M31 * m.M22 * m.M13 - m.M21 * m.M12 * m.M33 - m.M32 * m.M23 * m.M11;
        }

        //Determinant Matrix4
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

        //Mult Matrix2
        public static Matrix2d Mult(Matrix2d m1, Matrix2d m2)
        {
            Matrix2d Mult = new Matrix2d(
            m1.M11 * m2.M11 + m1.M12 * m2.M21, m1.M11 * m2.M12 + m1.M12 * m2.M22,
            m1.M21 * m2.M11 + m1.M22 * m2.M21, m1.M21 * m2.M12 + m1.M22 * m2.M22);

            return Mult;
        }

        public static Matrix2f Mult(Matrix2f m1, Matrix2f m2)
        {
            Matrix2f Mult = new Matrix2f(
            m1.M11 * m2.M11 + m1.M12 * m2.M21, m1.M11 * m2.M12 + m1.M12 * m2.M22,
            m1.M21 * m2.M11 + m1.M22 * m2.M21, m1.M21 * m2.M12 + m1.M22 * m2.M22);

            return Mult;
        }

        public static Matrix2i Mult(Matrix2i m1, Matrix2i m2)
        {
            Matrix2i Mult = new Matrix2i(
            m1.M11 * m2.M11 + m1.M12 * m2.M21, m1.M11 * m2.M12 + m1.M12 * m2.M22,
            m1.M21 * m2.M11 + m1.M22 * m2.M21, m1.M21 * m2.M12 + m1.M22 * m2.M22);

            return Mult;
        }
        //Mult Matrix3
        public static Matrix3d Mult(Matrix3d m1, Matrix3d m2)
        {
            Matrix3d Mult = new Matrix3d(
            m1.M11 * m2.M11 + m1.M12 * m2.M21 + m1.M13 * m2.M31, m1.M11 * m2.M12 + m1.M12 * m2.M22 + m1.M13 * m2.M32, m1.M11 * m2.M13 + m1.M12 * m2.M23 + m1.M13 * m2.M33,
            m1.M21 * m2.M11 + m1.M22 * m2.M21 + m1.M23 * m2.M31, m1.M21 * m2.M12 + m1.M22 * m2.M22 + m1.M23 * m2.M32, m1.M21 * m2.M13 + m1.M22 * m2.M23 + m1.M23 * m2.M33,
            m1.M31 * m2.M11 + m1.M32 * m2.M21 + m1.M33 * m2.M31, m1.M31 * m2.M12 + m1.M32 * m2.M22 + m1.M33 * m2.M32, m1.M31 * m2.M13 + m1.M32 * m2.M23 + m1.M33 * m2.M33);

            return Mult;
        }

        public static Matrix3f Mult(Matrix3f m1, Matrix3f m2)
        {
            Matrix3f Mult = new Matrix3f(
            m1.M11 * m2.M11 + m1.M12 * m2.M21 + m1.M13 * m2.M31, m1.M11 * m2.M12 + m1.M12 * m2.M22 + m1.M13 * m2.M32, m1.M11 * m2.M13 + m1.M12 * m2.M23 + m1.M13 * m2.M33,
            m1.M21 * m2.M11 + m1.M22 * m2.M21 + m1.M23 * m2.M31, m1.M21 * m2.M12 + m1.M22 * m2.M22 + m1.M23 * m2.M32, m1.M21 * m2.M13 + m1.M22 * m2.M23 + m1.M23 * m2.M33,
            m1.M31 * m2.M11 + m1.M32 * m2.M21 + m1.M33 * m2.M31, m1.M31 * m2.M12 + m1.M32 * m2.M22 + m1.M33 * m2.M32, m1.M31 * m2.M13 + m1.M32 * m2.M23 + m1.M33 * m2.M33);

            return Mult;
        }

        public static Matrix3i Mult(Matrix3i m1, Matrix3i m2)
        {
            Matrix3i Mult = new Matrix3i(
            m1.M11 * m2.M11 + m1.M12 * m2.M21 + m1.M13 * m2.M31, m1.M11 * m2.M12 + m1.M12 * m2.M22 + m1.M13 * m2.M32, m1.M11 * m2.M13 + m1.M12 * m2.M23 + m1.M13 * m2.M33,
            m1.M21 * m2.M11 + m1.M22 * m2.M21 + m1.M23 * m2.M31, m1.M21 * m2.M12 + m1.M22 * m2.M22 + m1.M23 * m2.M32, m1.M21 * m2.M13 + m1.M22 * m2.M23 + m1.M23 * m2.M33,
            m1.M31 * m2.M11 + m1.M32 * m2.M21 + m1.M33 * m2.M31, m1.M31 * m2.M12 + m1.M32 * m2.M22 + m1.M33 * m2.M32, m1.M31 * m2.M13 + m1.M32 * m2.M23 + m1.M33 * m2.M33);

            return Mult;
        }
        //Mult Matrix4
        //public static Matrix4d Mult(Matrix4d m1, Matrix4d m2)
        //{
            //Matrix4d Mult = new Matrix4d(
            //m1.M11 * m2.M11 + m1.M12 * m2.M21 + m1.M13 * m2.M31, m1.M11 * m2.M12 + m1.M12 * m2.M22 + m1.M13 * m2.M32, m1.M11 * m2.M13 + m1.M12 * m2.M23 + m1.M13 * m2.M33,
            //m1.M21 * m2.M11 + m1.M22 * m2.M21 + m1.M23 * m2.M31, m1.M21 * m2.M12 + m1.M22 * m2.M22 + m1.M23 * m2.M32, m1.M21 * m2.M13 + m1.M22 * m2.M23 + m1.M23 * m2.M33,
            //m1.M31 * m2.M11 + m1.M32 * m2.M21 + m1.M33 * m2.M31, m1.M31 * m2.M12 + m1.M32 * m2.M22 + m1.M33 * m2.M32, m1.M31 * m2.M13 + m1.M32 * m2.M23 + m1.M33 * m2.M33);

            //return Mult;
        //}

        ////Обратная матрица
        //public static Matrix Invert(Matrix x)
        //{
        //    Vector a = new Vector(x.B.B * x.G.G - x.B.G * x.G.B, x.A.G * x.G.B - x.A.B * x.G.G, x.A.B * x.B.G - x.B.B * x.A.G);
        //    Vector b = new Vector(x.B.G * x.G.A - x.B.A * x.G.G, x.A.A * x.G.G - x.A.G * x.G.A, x.A.G * x.B.A - x.A.A * x.B.G);
        //    Vector g = new Vector(x.B.A * x.G.B - x.B.B * x.G.A, x.A.B * x.G.A - x.A.A * x.G.B, x.A.A * x.B.B - x.A.B * x.B.A);
        //    Matrix X = new Matrix(Divide(a, Determinant(x)), Divide(b, Determinant(x)), Divide(g, Determinant(x)));
        //    return X;
        //}

        
    }
}

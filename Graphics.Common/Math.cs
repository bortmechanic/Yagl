namespace Yagl.Graphics
{
    public partial class Math
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

        //Length Vector3
        public static double Length(Vector3d v)
        {
            return System.Math.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);
        }

        public static float Length(Vector3f v)
        {
            return (float)(System.Math.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z));
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

        //Dot Vector3
        public static double Dot(Vector3d v1, Vector3d v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        public static float Dot(Vector3f v1, Vector3f v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        //Add Vector2
        public static Vector2d Add(Vector2d v1, Vector2d v2)
        {
            return new Vector2d(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector2f Add(Vector2f v1, Vector2f v2)
        {
            return new Vector2f(v1.X + v2.X, v1.Y + v2.Y);
        }

        //Add Vector3
        public static Vector3d Add(Vector3d v1, Vector3d v2)
        {
            return new Vector3d(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector3f Add(Vector3f v1, Vector3f v2)
        {
            return new Vector3f(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        //Subtract Vector2
        public static Vector2d Subtract(Vector2d v1, Vector2d v2)
        {
            return new Vector2d(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static Vector2f Subtract(Vector2f v1, Vector2f v2)
        {
            return new Vector2f(v1.X - v2.X, v1.Y - v2.Y);
        }

        //Subtract Vector3
        public static Vector3d Subtract(Vector3d v1, Vector3d v2)
        {
            return new Vector3d(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector3f Subtract(Vector3f v1, Vector3f v2)
        {
            return new Vector3f(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        //Multiply Vector2
        public static Vector2d Multiply(Vector2d v, double a)
        {
            return new Vector2d(a * v.X, a * v.Y);
        }

        public static Vector2f Multiply(Vector2f v, float a)
        {
            return new Vector2f(a * v.X, a * v.Y);
        }

        //Multiply Vector3
        public static Vector3d Multiply(Vector3d v, double a)
        {
            return new Vector3d(a * v.X, a * v.Y, a * v.Z);
        }

        public static Vector3f Multiply(Vector3f v, float a)
        {
            return new Vector3f(a * v.X, a * v.Y, a * v.Z);
        }

        //Divide Vector2
        public static Vector2d Divide(Vector2d v, double a)
        {
            return new Vector2d(v.X / a, v.Y / a);
        }
        public static Vector2f Divide(Vector2f v, float a)
        {
            return new Vector2f(v.X / a, v.Y / a);
        }
       
        //Divide Vector3
        public static Vector3d Divide(Vector3d v, double a)
        {
            return new Vector3d(v.X / a, v.Y / a, v.Z / a);
        }
        public static Vector3f Divide(Vector3f v, float a)
        {
            return new Vector3f(v.X / a, v.Y / a, v.Z / a);
        }
        
        //Normalize Vector2
        public static Vector2d Normalize(Vector2d v)
        {
            return new Vector2d(v.X / Length(v), v.Y / Length(v));
        }
        public static Vector2f Normalize(Vector2f v)
        {
            return new Vector2f(v.X / Length(v), v.Y / Length(v));
        }
        
        //Normalize Vector3
        public static Vector3d Normalize(Vector3d v)
        {
            return new Vector3d(v.X / Length(v), v.Y / Length(v), v.Z / Length(v));
        }
        public static Vector3f Normalize(Vector3f v)
        {
            return new Vector3f(v.X / Length(v), v.Y / Length(v), v.Z / Length(v));
        }
        
        //Negate Vector2
        public static Vector2d Negative(Vector2d v)
        {
            return new Vector2d(-v.X, -v.Y); ;
        }
        public static Vector2f Negative(Vector2f v)
        {
            return new Vector2f(-v.X, -v.Y);
        }
       
        //Negate Vector3
        public static Vector3d Negative(Vector3d v)
        {
            return new Vector3d(-v.X, -v.Y, -v.Z);
        }
        public static Vector3f Negative(Vector3f v)
        {
            return new Vector3f(-v.X, -v.Y, -v.Z);
        }
                
        //Cross Vector3
        public static Vector3d Cross(Vector3d v1, Vector3d v2)
        {
            return new Vector3d(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
        }

        public static Vector3f Cross(Vector3f v1, Vector3f v2)
        {
            return new Vector3f(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
        }
                
        //Multiply Matrix2
        public static Matrix2d Multiply(Matrix2d m, double a)
        {
            return new Matrix2d(m.M11 * a, m.M12 * a,
                                m.M21 * a, m.M22 * a);
        }

        public static Matrix2f Multiply(Matrix2f m, float a)
        {
            return new Matrix2f(m.M11 * a, m.M12 * a,
                                m.M21 * a, m.M22 * a);
        }
                
        //Multiply Matrix3
        public static Matrix3d Multiply(Matrix3d m, double a)
        {
            return new Matrix3d(m.M11 * a, m.M12 * a, m.M13 * a,
                                m.M21 * a, m.M22 * a, m.M23 * a,
                                m.M31 * a, m.M32 * a, m.M33 * a);
        }
        public static Matrix3f Multiply(Matrix3f m, float a)
        {
            return new Matrix3f(m.M11 * a, m.M12 * a, m.M13 * a,
                                m.M21 * a, m.M22 * a, m.M23 * a,
                                m.M31 * a, m.M32 * a, m.M33 * a);
        }
        
        //Multiply Matrix4
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
                
        //Divide Matrix2
        /// <summary>
        /// Divide matrix 2x2
        /// </summary>
        /// <param name="m">matrix 2x2</param>
        /// <param name="a">a!=0</param>
        /// <returns></returns>
        public static Matrix2d Divide(Matrix2d m, double a)
        {
            return new Matrix2d(m.M11 / a, m.M12 / a,
                                m.M21 / a, m.M22 / a);
        }

        public static Matrix2f Divide(Matrix2f m, float a)
        {
            return new Matrix2f(m.M11 / a, m.M12 / a,
                                m.M21 / a, m.M22 / a);
        }
                
        //Divide Matrix3
        public static Matrix3d Divide(Matrix3d m, double a)
        {
            return new Matrix3d(m.M11 / a, m.M12 / a, m.M13 / a,
                                m.M21 / a, m.M22 / a, m.M23 / a,
                                m.M31 / a, m.M32 / a, m.M33 / a);
        }
        public static Matrix3f Divide(Matrix3f m, float a)
        {
            return new Matrix3f(m.M11 / a, m.M12 / a, m.M13 / a,
                                m.M21 / a, m.M22 / a, m.M23 / a,
                                m.M31 / a, m.M32 / a, m.M33 / a);
        }
        
        //Divide Matrix4
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
                
        //Add Matrix2
        public static Matrix2d Add(Matrix2d m1, Matrix2d m2)
        {
            return new Matrix2d(m1.M11 + m2.M11, m1.M12 + m2.M12,
                                m1.M21 + m2.M21, m1.M22 + m2.M22);
        }
        public static Matrix2f Add(Matrix2f m1, Matrix2f m2)
        {
            return new Matrix2f(m1.M11 + m2.M11, m1.M12 + m2.M12,
                                m1.M21 + m2.M21, m1.M22 + m2.M22);
        }
                
        //Add Matrix3
        public static Matrix3d Add(Matrix3d m1, Matrix3d m2)
        {
            return new Matrix3d(m1.M11 + m2.M11, m1.M12 + m2.M12, m1.M13 + m2.M13,
                                m1.M21 + m2.M21, m1.M22 + m2.M22, m1.M23 + m2.M23,
                                m1.M31 + m2.M31, m1.M32 + m2.M32, m1.M33 + m2.M33);
        }
        public static Matrix3f Add(Matrix3f m1, Matrix3f m2)
        {
            return new Matrix3f(m1.M11 + m2.M11, m1.M12 + m2.M12, m1.M13 + m2.M13,
                                m1.M21 + m2.M21, m1.M22 + m2.M22, m1.M23 + m2.M23,
                                m1.M31 + m2.M31, m1.M32 + m2.M32, m1.M33 + m2.M33);
        }
        
        //Add Matrix4
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
        
        //Subtract Matrix2
        public static Matrix2d Subtract(Matrix2d m1, Matrix2d m2)
        {
            return new Matrix2d(m1.M11 - m2.M11, m1.M12 - m2.M12,
                                m1.M21 - m2.M21, m1.M22 - m2.M22);
        }
        public static Matrix2f Subtract(Matrix2f m1, Matrix2f m2)
        {
            return new Matrix2f(m1.M11 - m2.M11, m1.M12 - m2.M12,
                                m1.M21 - m2.M21, m1.M22 - m2.M22);
        }
                
        //Subtract Matrix3
        public static Matrix3d Subtract(Matrix3d m1, Matrix3d m2)
        {
            return new Matrix3d(m1.M11 - m2.M11, m1.M12 - m2.M12, m1.M13 - m2.M13,
                                m1.M21 - m2.M21, m1.M22 - m2.M22, m1.M23 - m2.M23,
                                m1.M31 - m2.M31, m1.M32 - m2.M32, m1.M33 - m2.M33);
        }
        public static Matrix3f Subtract(Matrix3f m1, Matrix3f m2)
        {
            return new Matrix3f(m1.M11 - m2.M11, m1.M12 - m2.M12, m1.M13 - m2.M13,
                                m1.M21 - m2.M21, m1.M22 - m2.M22, m1.M23 - m2.M23,
                                m1.M31 - m2.M31, m1.M32 - m2.M32, m1.M33 - m2.M33);
        }
        
        //Subtract Matrix4
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
        
        //Determinant Matrix2
        public static double Determinant(Matrix2d m)
        {
            return m.M11 * m.M22 - m.M21 * m.M12;
        }

        public static float Determinant(Matrix2f m)
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
                
        //Multiply Matrix2
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
                
        //Multiply Matrix3
        public static Matrix3d Multiply(Matrix3d m1, Matrix3d m2)
        {
            return new Matrix3d(
            m1.M11 * m2.M11 + m1.M12 * m2.M21 + m1.M13 * m2.M31, m1.M11 * m2.M12 + m1.M12 * m2.M22 + m1.M13 * m2.M32, m1.M11 * m2.M13 + m1.M12 * m2.M23 + m1.M13 * m2.M33,
            m1.M21 * m2.M11 + m1.M22 * m2.M21 + m1.M23 * m2.M31, m1.M21 * m2.M12 + m1.M22 * m2.M22 + m1.M23 * m2.M32, m1.M21 * m2.M13 + m1.M22 * m2.M23 + m1.M23 * m2.M33,
            m1.M31 * m2.M11 + m1.M32 * m2.M21 + m1.M33 * m2.M31, m1.M31 * m2.M12 + m1.M32 * m2.M22 + m1.M33 * m2.M32, m1.M31 * m2.M13 + m1.M32 * m2.M23 + m1.M33 * m2.M33);
        }

        public static Matrix3f Multiply(Matrix3f m1, Matrix3f m2)
        {
            return new Matrix3f(
            m1.M11 * m2.M11 + m1.M12 * m2.M21 + m1.M13 * m2.M31, m1.M11 * m2.M12 + m1.M12 * m2.M22 + m1.M13 * m2.M32, m1.M11 * m2.M13 + m1.M12 * m2.M23 + m1.M13 * m2.M33,
            m1.M21 * m2.M11 + m1.M22 * m2.M21 + m1.M23 * m2.M31, m1.M21 * m2.M12 + m1.M22 * m2.M22 + m1.M23 * m2.M32, m1.M21 * m2.M13 + m1.M22 * m2.M23 + m1.M23 * m2.M33,
            m1.M31 * m2.M11 + m1.M32 * m2.M21 + m1.M33 * m2.M31, m1.M31 * m2.M12 + m1.M32 * m2.M22 + m1.M33 * m2.M32, m1.M31 * m2.M13 + m1.M32 * m2.M23 + m1.M33 * m2.M33);
        }

        //Multiply Matrix4
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

        //Invert Matrix2
        public static Matrix2d Invert(Matrix2d m)
        {
            Matrix2d St = new Matrix2d(m.M22, -m.M12,
                                       -m.M21, m.M11);

            return Divide(St, Determinant(m));
        }

        public static Matrix2f Invert(Matrix2f m)
        {
            Matrix2f St = new Matrix2f(m.M22, -m.M12,
                                       -m.M21, m.M11);

            return Divide(St, Determinant(m));
        }
                
        //Invert Matrix3
        public static Matrix3d Invert(Matrix3d m)
        {
            Matrix3d St = new Matrix3d(m.M22 * m.M33 - m.M23 * m.M32, m.M13 * m.M32 - m.M12 * m.M33, m.M12 * m.M23 - m.M22 * m.M13,
                                       m.M23 * m.M31 - m.M21 * m.M33, m.M11 * m.M33 - m.M13 * m.M31, m.M13 * m.M21 - m.M11 * m.M23,
                                       m.M21 * m.M32 - m.M22 * m.M31, m.M12 * m.M31 - m.M11 * m.M32, m.M11 * m.M22 - m.M12 * m.M21);
            
            return Divide(St,Determinant(m));
        }
        public static Matrix3f Invert(Matrix3f m)
        {
            Matrix3f St = new Matrix3f(m.M22 * m.M33 - m.M23 * m.M32, m.M13 * m.M32 - m.M12 * m.M33, m.M12 * m.M23 - m.M22 * m.M13,
                                       m.M23 * m.M31 - m.M21 * m.M33, m.M11 * m.M33 - m.M13 * m.M31, m.M13 * m.M21 - m.M11 * m.M23,
                                       m.M21 * m.M32 - m.M22 * m.M31, m.M12 * m.M31 - m.M11 * m.M32, m.M11 * m.M22 - m.M12 * m.M21);

            return Divide(St, Determinant(m));
        }
        
        //Invert Matrix4
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
        //x,y,z - distance to new point 
        //page 183-184 PavelBook
        public static Matrix4f Translation(float x, float y, float z)
        {
            return new Matrix4f( 1, 0, 0, x,
                                 0, 1, 0, y,
                                 0, 0, 1, z,
                                 0, 0, 0, 1);
        }

        public static Matrix4f RotationX(float a)
        {
            return new Matrix4f( 1, 0,                           0,                             0,
                                 0, (float)(System.Math.Cos(a)), -(float)(System.Math.Sin(a)),  0,
                                 0, (float)(System.Math.Sin(a)),  (float)(System.Math.Cos(a)),  0,
                                 0, 0,                           0,                             1);
        }

        public static Matrix4f RotationY(float a)
        {
            return new Matrix4f((float)(System.Math.Cos(a)), 0, (float)(System.Math.Sin(a)), 0,
                                 0, 1, 0, 0,
                                 -(float)(System.Math.Sin(a)), 0, (float)(System.Math.Cos(a)), 0,
                                 0, 0, 0, 1);
        }

        public static Matrix4f RotationZ(float a)
        {
            return new Matrix4f((float)(System.Math.Cos(a)), (float)(System.Math.Sin(a)), 0, 0,
                                (float)(System.Math.Sin(a)), (float)(System.Math.Cos(a)), 0, 0,
                                  0, 0, 1, 0,
                                  0, 0, 0, 1);
        }

        public static Matrix4f Scaling(float x, float y, float z)
        {
            return new Matrix4f( x, 0, 0, 0,
                                 0, y, 0, 0,
                                 0, 0, z, 0,
                                 0, 0, 0, 1);
        }

        public static Matrix4f ShearX(float a)
        {
            return new Matrix4f( 1, (float)(System.Math.Cos(a)/ System.Math.Sin(a)), 0, 0,
                                 0, 1, 0, 0,
                                 0, 0, 1, 0,
                                 0, 0, 0, 1);
        }
    }
}

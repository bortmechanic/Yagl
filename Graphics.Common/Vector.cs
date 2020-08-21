using System;


namespace Yagl.Graphics
{
    public struct Vector
    {
        public float A;
        public float B;
        public float G;


        public Vector(float x, float y, float z)
        {
            A = x;
            B = y;
            G = z;

        }
    }

    public struct Matrix
    {
        public Vector A;//alfa
        public Vector B;//beta
        public Vector G;//gamma

        public Matrix(Vector a, Vector b, Vector g)
        {
            //матрица описывает вектор равный векторному произведению векторов в своем базисе i,j,k
            A = a;//i,j,k-базис
            B = b;//x1,y1,z1-вектор первый
            G = g;//x2,y2,z2-вектор второй
        }
    }

    class MathVM
    {
        public static void displayVector(Vector x)
        {
            Console.WriteLine(x.A + ", " + x.B + ", " + x.G);
        }
        public static float Length(Vector x)
        {
            return (float)(Math.Sqrt(x.A * x.A + x.B * x.B + x.G * x.G));
        }
        public static float Dot(Vector x, Vector y)
        {
            return x.A * y.A + x.B * y.B + x.G * y.G;
        }

        public static Vector Add(Vector x, Vector y)
        {
            Vector X = new Vector(x.A + y.A, x.B + y.B, x.G + y.G);
            return X;
        }

        public static Vector Subtract(Vector x, Vector y)
        {
            Vector X = new Vector(x.A - y.A, x.B - y.B, x.G - y.G);
            return X;
        }
        public static Vector Multiply(Vector x, float y)
        {
            Vector X = new Vector(y * x.A, y * x.B, y * x.G);
            return X;
        }
        public static Vector Divide(Vector x, float y)
        {
            Vector X = new Vector(x.A / y, x.B / y, x.G / y);
            return X;
        }
        public static Vector Normalize(Vector x)
        {
            Vector X = new Vector(x.A / Length(x), x.B / Length(x), x.G / Length(x));
            return X;
        }
        public static Vector Negate(Vector x)
        {
            Vector X = new Vector(-x.A, -x.B, -x.G);
            return X;
        }
        public static Vector Cross(Vector x, Vector y)
        {
            Vector X = new Vector(x.B * y.G - x.G * y.B, x.G * y.A - x.A * y.G, x.A * y.B - x.B * y.A);
            return X;
        }


        public static Matrix Multiply(Matrix x, float y)
        {
            Matrix X = new Matrix(Multiply(x.A, y), Multiply(x.B, y), Multiply(x.G, y));
            return X;
        }

        public static Matrix Divide(Matrix x, float y)
        {
            Matrix X = new Matrix(Divide(x.A, y), Divide(x.B, y), Divide(x.G, y));
            return X;
        }

        public static Matrix Add(Matrix x, Matrix y)
        {
            Matrix X = new Matrix(Add(x.A, y.A), Add(x.B, y.B), Add(x.G, y.G));
            return X;
        }
        public static Matrix Sub(Matrix x, Matrix y)
        {
            Matrix X = new Matrix(Subtract(x.A, y.A), Subtract(x.B, y.B), Subtract(x.G, y.G));
            return X;
        }
        public static float Determinant(Matrix x)
        {
            return x.A.A * x.B.B * x.G.G + x.A.B * x.B.G * x.G.A + x.B.A * x.G.B * x.A.G - x.G.A * x.B.B * x.A.G - x.B.A * x.A.B * x.G.G - x.G.B * x.B.G * x.A.A;
        }
        //Обратная матрица
        public static Matrix Invert(Matrix x)
        {
            Vector a = new Vector(x.B.B * x.G.G - x.B.G * x.G.B, x.A.G * x.G.B - x.A.B * x.G.G, x.A.B * x.B.G - x.B.B * x.A.G);
            Vector b = new Vector(x.B.G * x.G.A - x.B.A * x.G.G, x.A.A * x.G.G - x.A.G * x.G.A, x.A.G * x.B.A - x.A.A * x.B.G);
            Vector g = new Vector(x.B.A * x.G.B - x.B.B * x.G.A, x.A.B * x.G.A - x.A.A * x.G.B, x.A.A * x.B.B - x.A.B * x.B.A);
            Matrix X = new Matrix(Divide(a, Determinant(x)), Divide(b, Determinant(x)), Divide(g, Determinant(x)));
            return X;
        }

        public static Matrix Mult(Matrix x, Matrix y)
        {
            Vector a = new Vector(x.A.A * y.A.A + x.A.B * y.B.A + x.A.G * y.G.A, x.A.A * y.A.B + x.A.B * y.B.B + x.A.G * y.G.B, x.A.A * y.A.G + x.A.B * y.B.G + x.A.G * y.G.G);
            Vector b = new Vector(x.B.A * y.A.A + x.B.B * y.B.A + x.B.G * y.G.A, x.B.A * y.A.B + x.B.B * y.B.B + x.B.G * y.G.B, x.B.A * y.A.G + x.B.B * y.B.G + x.B.G * y.G.G);
            Vector g = new Vector(x.G.A * y.A.A + x.G.B * y.B.A + x.G.G * y.G.A, x.G.A * y.A.B + x.G.B * y.B.B + x.G.G * y.G.B, x.G.A * y.A.G + x.G.B * y.B.G + x.G.G * y.G.G);

            Matrix X = new Matrix(a, b, g);
            return X;
        }

        public static void displayMatrix(Matrix x)
        {
            Console.WriteLine(x.A.A + "  " + x.A.B + "  " + x.A.G);
            Console.WriteLine(x.B.A + "  " + x.B.B + "  " + x.B.G);
            Console.WriteLine(x.G.A + "  " + x.G.B + "  " + x.G.G);
        }
    }
}

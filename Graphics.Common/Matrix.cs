using System;

namespace Yagl.Graphics
{
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
}

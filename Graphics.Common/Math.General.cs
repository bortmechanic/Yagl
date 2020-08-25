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
        public const double Pi = 3.141592653589793;
        public const double PiOverTwo = 1.570796326794897;
        public const double PiOverFour = 0.785398163397448;

        public static double Abs(double v) => v >= 0 ? v : -v;
        public static float Abs(float v) => v >= 0 ? v : -v;
        public static int Abs(int v) => v >= 0 ? v : -v;
        public static double Sqrt(double a) => System.Math.Sqrt(a);
        public static float Sqrt(float a) => (float)System.Math.Sqrt(a);
        public static double Pow(double x, double y) => System.Math.Pow(x, y);
        public static float Pow(float x, float y) => (float)System.Math.Pow(x, y);
        public static double Round(double v) => System.Math.Round(v);
        public static float Round(float v) => (float)System.Math.Round(v);
        public static double Round(double v, int digits) => System.Math.Round(v, digits);
        public static float Round(float v, int digits) => (float)System.Math.Round(v, digits);
        public static double Floor(double v) => System.Math.Floor(v);
        public static float Floor(float v) => (float)System.Math.Floor(v);
        public static double Ceiling(double v) => System.Math.Ceiling(v);
        public static float Ceiling(float v) => (float)System.Math.Ceiling(v);
        public static double Min(double v1, double v2) => System.Math.Min(v1, v2);
        public static float Min(float v1, float v2) => System.Math.Min(v1, v2);
        public static int Min(int v1, int v2) => System.Math.Min(v1, v2);
        public static double Max(double v1, double v2) => System.Math.Max(v1, v2);
        public static float Max(float v1, float v2) => System.Math.Max(v1, v2);
        public static int Max(int v1, int v2) => System.Math.Max(v1, v2);
        public static double Sin(double a) => System.Math.Sin(a);
        public static float Sin(float a) => (float)System.Math.Sin(a);
        public static double Cos(double a) => System.Math.Cos(a);
        public static float Cos(float a) => (float)System.Math.Cos(a);
        public static double Tan(double a) => System.Math.Tan(a);
        public static float Tan(float a) => (float)System.Math.Tan(a);
        public static double ArcCos(double a) => System.Math.Acos(a);
        public static float ArcCos(float a) => (float)System.Math.Acos(a);
        public static double ArcSin(double a) => System.Math.Asin(a);
        public static float ArcSin(float a) => (float)System.Math.Asin(a);
        public static double ArcTan(double a) => System.Math.Atan(a);
        public static float ArcTan(float a) => (float)System.Math.Atan(a);
    }
}

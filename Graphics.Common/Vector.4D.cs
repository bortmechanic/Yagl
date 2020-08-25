/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Viktor Kalmuk.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

public struct Vector4d
{
    public double X;
    public double Y;
    public double Z;
    public double S;

    public Vector4d(double x, double y, double z,double s)
    {
        X = x;
        Y = y;
        Z = z;
        S = s;
    }
}

public struct Vector4f
{
    public float X;
    public float Y;
    public float Z;
    public float S;

    public Vector4f(float x, float y, float z, float s)
    {
        X = x;
        Y = y;
        Z = z;
        S = s;
    }
}

public struct Vector4i
{
    public int X;
    public int Y;
    public int Z;
    public int S;

    public Vector4i(int x, int y, int z, int s)
    {
        X = x;
        Y = y;
        Z = z;
        S = s;
    }
}
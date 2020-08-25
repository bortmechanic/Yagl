/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Viktor Kalmuk.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

public struct Vector3d
{
    public double X;
    public double Y;
    public double Z;

    public Vector3d(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}

public struct Vector3f
{
    public float X;
    public float Y;
    public float Z;

    public Vector3f(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}

public struct Vector3i
{
    public int X;
    public int Y;
    public int Z;

    public Vector3i(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}
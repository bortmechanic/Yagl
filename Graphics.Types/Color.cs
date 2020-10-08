/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Viktor Kalmuk.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global
// ReSharper disable InconsistentNaming

using System.Runtime.InteropServices;

namespace Yagl.Graphics
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct Color3b
    {
        [FieldOffset(0)] public byte R;
        [FieldOffset(1)] public byte G;
        [FieldOffset(2)] public byte B;

        [FieldOffset(0)] public unsafe fixed byte Data[3];

        public static unsafe implicit operator byte*(Color3b value) => value.Data;

        public Color3b(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct Color3f
    {
        [FieldOffset(0)] public float R;
        [FieldOffset(4)] public float G;
        [FieldOffset(8)] public float B;

        [FieldOffset(0)] public unsafe fixed float Data[3];

        public static unsafe implicit operator float*(Color3f value) => value.Data;

        public Color3f(float r, float g, float b)
        {
            R = r > 1 ? 1.0f : r < 0 ? 0.0f : r;
            G = g > 1 ? 1.0f : g < 0 ? 0.0f : g;
            B = b > 1 ? 1.0f : b < 0 ? 0.0f : b;
        }
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct Color3d
    {
        [FieldOffset(0)] public double R;
        [FieldOffset(8)] public double G;
        [FieldOffset(16)] public double B;

        [FieldOffset(0)] public unsafe fixed double Data[3];

        public static unsafe implicit operator double*(Color3d value) => value.Data;

        public Color3d(double r, double g, double b)
        {
            R = r > 1 ? 1.0d : r < 0 ? 0.0d : r;
            G = g > 1 ? 1.0d : g < 0 ? 0.0d : g;
            B = b > 1 ? 1.0d : b < 0 ? 0.0d : b;
        }
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct Color4b
    {
        [FieldOffset(0)] public byte R;
        [FieldOffset(1)] public byte G;
        [FieldOffset(2)] public byte B;
        [FieldOffset(3)] public byte A;

        [FieldOffset(0)] public unsafe fixed byte Data[4];

        public static unsafe implicit operator byte*(Color4b value) => value.Data;

        public Color4b(byte r, byte g, byte b, byte a)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }

        public Color4b(Color3b color, byte a)
        {
            R = color.R;
            G = color.G;
            B = color.B;
            A = a;
        }
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct Color4f
    {
        [FieldOffset(0)] public float R;
        [FieldOffset(4)] public float G;
        [FieldOffset(8)] public float B;
        [FieldOffset(12)] public float A;

        [FieldOffset(0)] public unsafe fixed float Data[4];

        public static unsafe implicit operator float*(Color4f value) => value.Data;

        public Color4f(float r, float g, float b, float a)
        {
            R = r > 1 ? 1.0f : r < 0 ? 0.0f : r;
            G = g > 1 ? 1.0f : g < 0 ? 0.0f : g;
            B = b > 1 ? 1.0f : b < 0 ? 0.0f : b;
            A = a > 1 ? 1.0f : a < 0 ? 0.0f : a;
        }

        public Color4f(Color3f color, float a)
        {
            R = color.R;
            G = color.G;
            B = color.B;
            A = a > 1 ? 1.0f : a < 0 ? 0.0f : a;
        }
    }


    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct Color4d
    {
        [FieldOffset(0)] public double R;
        [FieldOffset(8)] public double G;
        [FieldOffset(16)] public double B;
        [FieldOffset(24)] public double A;

        [FieldOffset(0)] public unsafe fixed double Data[4];

        public static unsafe implicit operator double*(Color4d value) => value.Data;

        public Color4d(double r, double g, double b, double a)
        {
            R = r > 1 ? 1.0d : r < 0 ? 0.0d : r;
            G = g > 1 ? 1.0d : g < 0 ? 0.0d : g;
            B = b > 1 ? 1.0d : b < 0 ? 0.0d : b;
            A = a > 1 ? 1.0d : a < 0 ? 0.0d : a;
        }

        public Color4d(Color3d color, double a)
        {
            R = color.R;
            G = color.G;
            B = color.B;
            A = a > 1 ? 1.0d : a < 0 ? 0.0d : a;
        }
    }
}
﻿/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Viktor Kalmuk.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable InconsistentNaming
// ReSharper disable FieldCanBeMadeReadOnly.Global

using System.Globalization;

namespace Yagl.Graphics
{
    public struct Vector2d
    {
        public double X, Y;

        public Vector2d(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() =>
            $"({X.ToString(CultureInfo.InvariantCulture)}, {Y.ToString(CultureInfo.InvariantCulture)})";
    }

    public struct Vector2f
    {
        public float X, Y;

        public Vector2f(float x, float y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() =>
            $"({X.ToString(CultureInfo.InvariantCulture)}, {Y.ToString(CultureInfo.InvariantCulture)})";
    }

    public struct Vector2i
    {
        public int X, Y;

        public Vector2i(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() =>
            $"({X.ToString()}, {Y.ToString()})";
    }
}
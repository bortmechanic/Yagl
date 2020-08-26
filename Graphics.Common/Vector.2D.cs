/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Viktor Kalmuk.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable InconsistentNaming
// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable UnusedMember.Global

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
        
        public static Vector2d Zero => new Vector2d(0, 0);
        public static Vector2d UnitX => new Vector2d(1, 0);
        public static Vector2d UnitY => new Vector2d(0, 1);

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
        
        public static Vector2f Zero => new Vector2f(0, 0);
        public static Vector2f UnitX => new Vector2f(1, 0);
        public static Vector2f UnitY => new Vector2f(0, 1);

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
        
        public static Vector2i Zero => new Vector2i(0, 0);
        public static Vector2i UnitX => new Vector2i(1, 0);
        public static Vector2i UnitY => new Vector2i(0, 1);

        public override string ToString() =>
            $"({X.ToString()}, {Y.ToString()})";
    }
}
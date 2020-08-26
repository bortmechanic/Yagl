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
    public struct Vector3d
    {
        public double X, Y, Z;

        public Vector3d(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        public static Vector3d Zero => new Vector3d(0, 0, 0);
        public static Vector3d UnitX => new Vector3d(1, 0, 0);
        public static Vector3d UnitY => new Vector3d(0, 1, 0);
        public static Vector3d UnitZ => new Vector3d(0, 0, 1);

        public override string ToString() =>
            $"({X.ToString(CultureInfo.InvariantCulture)}, {Y.ToString(CultureInfo.InvariantCulture)}, {Z.ToString(CultureInfo.InvariantCulture)})";
    }

    public struct Vector3f
    {
        public float X, Y, Z;

        public Vector3f(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        public static Vector3f Zero => new Vector3f(0, 0, 0);
        public static Vector3f UnitX => new Vector3f(1, 0, 0);
        public static Vector3f UnitY => new Vector3f(0, 1, 0);
        public static Vector3f UnitZ => new Vector3f(0, 0, 1);
        
        public override string ToString() =>
            $"({X.ToString(CultureInfo.InvariantCulture)}, {Y.ToString(CultureInfo.InvariantCulture)}, {Z.ToString(CultureInfo.InvariantCulture)})";
    }

    public struct Vector3i
    {
        public int X, Y, Z;

        public Vector3i(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        public static Vector3i Zero => new Vector3i(0, 0, 0);
        public static Vector3i UnitX => new Vector3i(1, 0, 0);
        public static Vector3i UnitY => new Vector3i(0, 1, 0);
        public static Vector3i UnitZ => new Vector3i(0, 0, 1);
        
        public override string ToString() =>
            $"({X.ToString()}, {Y.ToString()}, {Z.ToString()})";
    }
}
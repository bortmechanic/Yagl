/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

namespace Yagl.Graphics.Imaging
{
    public class Palette
    {
        public Color[] Colors { get; set; }
        
        public class Color
        {
            public double Red { get; set; }
            public double Green { get; set; }
            public double Blue { get; set; }
            public double Alpha { get; set; }
        }
    }
}
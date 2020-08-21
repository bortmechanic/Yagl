/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

namespace Yagl.Graphics.Imaging
{
    public class PixelFormatDescriptor
    {
        public Channel[] Channels { get; set; }
        public int PixelPadding { get; set; }
        public int RowPadding { get; set; }

        public enum ChannelType
        {
            General = 0,
            Luminocity = 1,
            Red = 2,
            Green = 3,
            Blue = 4,
            Alpha = 5,
            PaletteColor = 6
        }
        
        public class Channel
        {
            public ChannelType Type { get; set; }
            public int NumberOfBits { get; set; }
        }
    }
}
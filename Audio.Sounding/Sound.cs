/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable UnusedAutoPropertyAccessor.Global

using System;
using System.IO;

namespace Yagl.Audio
{
    public class Sound
    {
        public int NumberOfChannels { get; set; }
        public int SampleRate { get; set; }
        public int BitsPerSample { get; set; }
        public byte[] Data { get; set; }
        
        public static Sound Load(string filename)
        {
            var format = FormatRegistry.FindFormat(filename);
            if (format == null)
                throw new NotSupportedException($"Sound format of the file '{filename}' is not supported.");
            using var stream = File.OpenRead(filename);
            return format.Load(stream);
        }

        public void Save(string filename)
        {
            var format = FormatRegistry.FindFormat(filename);
            if (format == null)
                throw new NotSupportedException($"No suitable encoder found to save the sound '{filename}'.");
            using var stream = File.OpenWrite(filename);
            format.Save(this, stream);
        }
    }
}
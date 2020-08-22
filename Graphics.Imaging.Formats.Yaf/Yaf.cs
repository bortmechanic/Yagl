/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable UnusedType.Global

using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Yagl.Graphics.Imaging.Formats
{
    public partial class Yaf : IFormat
    {
        public bool CanProcess(string filename)
        {
            return filename.EndsWith(".yaf", true, CultureInfo.InvariantCulture);
        }

        public Image Load(Stream stream)
        {
            using var reader = new BinaryReader(stream, Encoding.UTF8);

            uint width = 0;
            uint height = 0;
            ushort rowPadding = 0;
            ChannelDescription[] channelsDescription = null;
            byte[] bitmap = null;

            Signature.Read(reader, out _);

            var finished = false;
            while (!finished)
            {
                var code = reader.ReadUInt32();
                var size = reader.ReadUInt32();
                var beginPosition = stream.Position;

                switch (code)
                {
                    case FileDescChunk.Code:
                        FileDescChunk.Read(reader, out _, out _, out _, out _);
                        break;
                    case ImageDescChunk.Code:
                        ImageDescChunk.Read(reader, out width, out height, out _, out _,
                            out rowPadding, out channelsDescription);
                        break;
                    case ImageDataChunk.Code:
                        ImageDataChunk.Read(reader, size, out bitmap);
                        break;
                    case EndChunk.Code:
                        //EndChunk.Read(reader);
                        finished = true;
                        break;
                }

                var endPosition = stream.Position;
                var realSize = endPosition - beginPosition;
                if (realSize != size)
                    throw new InvalidOperationException();
                /*var reserved =*/ reader.ReadUInt32();
            }

            return new Image
            {
                Width = (int) width,
                Height = (int) height,
                PixelFormatDescriptor = new PixelFormatDescriptor
                {
                    RowPadding = rowPadding,
                    Channels = channelsDescription?.Select(ch => new PixelFormatDescriptor.Channel
                    {
                        Type = (PixelFormatDescriptor.ChannelType) ch.Type, NumberOfBits = ch.NumberOfBits
                    }).ToArray()
                },
                BitMap = bitmap
            };
        }

        public void Save(Image image, Stream stream)
        {
            using var writer = new BinaryWriter(stream, Encoding.UTF8);
            Signature.Write(writer);
            FileDescChunk.Write(writer);
            ImageDescChunk.Write(writer, (uint) image.Width, (uint) image.Height, 0,
                (ushort) image.PixelFormatDescriptor.Channels.Length, (ushort) image.PixelFormatDescriptor.RowPadding,
                image.PixelFormatDescriptor.Channels.Select(ch => new ChannelDescription
                    {Type = (ushort) ch.Type, NumberOfBits = (ushort) ch.NumberOfBits}).ToArray());
            ImageDataChunk.Write(writer, image.BitMap);
            EndChunk.Write(writer);
        }
    }
}
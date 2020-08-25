/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedParameter.Global

using System.IO;

namespace Yagl.Graphics.Imaging
{
    public interface IFormat
    {
        bool CanProcess(string filename);
        Image Load(Stream stream);
        void Save(Image image, Stream stream);
    }
}
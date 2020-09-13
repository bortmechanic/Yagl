/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System.IO;

namespace Yagl.Audio
{
    public interface IFormat
    {
        bool CanProcess(string filename);
        Sound Load(Stream stream);
        void Save(Sound sound, Stream stream);
    }
}
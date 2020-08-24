/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable UnusedMember.Global

namespace Yagl.Components
{
    public enum ComponentState
    {
        Unknown = 0,
        New = 10,
        Initializing = 20,
        Active = 30,
        ShuttingDown = 40,
        Disposed = 50
    }
}
/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable UnusedMember.Global
namespace Yagl.Windowing
{
    public enum Decorations
    {
        Default = TitleBar,
        None = 0,
        TitleBar = 1
    }
    
    public enum ResizeMode
    {
        Default = NotResizable,
        NotResizable = 0,
        Resizable = 1,
    }
}
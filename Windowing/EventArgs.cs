/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System;
// ReSharper disable UnusedMember.Global

namespace Yagl.Windowing
{
    public class SizeChangedEventArgs : EventArgs
    {
        public int Width;
        public int Height;
        public int ClientWidth;
        public int ClientHeight;
    }

    public class ActivatedEventArgs : EventArgs
    {
        public readonly bool IsActive = true;
        internal static readonly ActivatedEventArgs Instance = new ActivatedEventArgs();
    }
    
    public class DeActivatedEventArgs : EventArgs
    {
        public readonly bool IsActive = false;
        internal static readonly DeActivatedEventArgs Instance = new DeActivatedEventArgs();
    }
    
    public class RepaintEventArgs : EventArgs
    {
        internal static readonly RepaintEventArgs Instance = new RepaintEventArgs();
    }

    public class ClosingEventArgs : EventArgs
    {
        public bool Cancel = false;
    }

    public class ClosedEventArgs : EventArgs
    {
        internal static readonly  ClosedEventArgs Instance = new ClosedEventArgs();
    }
}
/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable NotAccessedField.Global
// ReSharper disable UnusedMember.Global

using System;

namespace Yagl.Components
{
    public readonly struct Time
    {
        public readonly TimeSpan Elapsed;
        public readonly TimeSpan TotalElapsed;
        
        public Time(TimeSpan elapsed, TimeSpan totalElapsed)
        {
            Elapsed = elapsed;
            TotalElapsed = totalElapsed;
        }
    }
}
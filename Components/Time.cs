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
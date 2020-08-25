/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System.Threading;

namespace Yagl.Components
{
    internal static class IdGenerator
    {
        private static long _idsSequence;
        public static long Generate() => Interlocked.Increment(ref _idsSequence);
    }
}
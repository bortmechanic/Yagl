/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System;
using System.Runtime.InteropServices;

namespace Yagl.Graphics
{
    public static partial class Gl
    {
        public static void Init(Func<string,IntPtr> getProcAddress)
        {
            Init_GL_1_0(getProcAddress);
        }

        private static T LoadProcByName<T>(string procName, Func<string,IntPtr> getProcAddress) where T: Delegate
        {
            var ptr = getProcAddress.Invoke(procName);
            return ptr != IntPtr.Zero ? Marshal.GetDelegateForFunctionPointer<T>(ptr) : null;
        }

    }
}

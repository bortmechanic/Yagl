// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

using System;
using System.Runtime.InteropServices;

namespace Yagl.Graphics
{
    public static partial class Gl
    {
        public static void Init(Func<string,IntPtr> getProcAddress)
        {
            _clearColor = LoadProcByName<ClearColorDelegate>("glClearColor", getProcAddress);
            _clear = LoadProcByName<ClearDelegate>("glClear", getProcAddress);
        }

        private static T LoadProcByName<T>(string procName, Func<string,IntPtr> getProcAddress) where T: Delegate
        {
            var ptr = getProcAddress.Invoke(procName);
            return ptr != IntPtr.Zero ? Marshal.GetDelegateForFunctionPointer<T>(ptr) : null;
        }
    }
}
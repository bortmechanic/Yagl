/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Yagl.Utils
{
    public class NativeLibResolver
    {
        public static void Configure(Assembly assembly, string libName, string windowsName, string linuxName, string osxName)
        {
            var resolver = new NativeLibResolver();
            resolver._libName = libName;
            resolver._windowsLibName = windowsName;
            resolver._linuxLibName = linuxName;
            resolver._osxLibName = osxName;
            NativeLibrary.SetDllImportResolver(assembly, resolver.ImportResolver);
        }

        private string _libName;
        private string _windowsLibName;
        private string _linuxLibName;
        private string _osxLibName;

        private IntPtr ImportResolver(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
        {
            var libHandle = IntPtr.Zero;
            if (libraryName != _libName) return libHandle;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) && !string.IsNullOrWhiteSpace(_windowsLibName))
                NativeLibrary.TryLoad(_windowsLibName, assembly, DllImportSearchPath.ApplicationDirectory, out libHandle);
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) && !string.IsNullOrWhiteSpace(_linuxLibName))
                NativeLibrary.TryLoad(_linuxLibName, assembly, DllImportSearchPath.ApplicationDirectory, out libHandle);
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX) && !string.IsNullOrWhiteSpace(_osxLibName))
                NativeLibrary.TryLoad(_osxLibName, assembly, DllImportSearchPath.ApplicationDirectory, out libHandle);
            return libHandle;
        }

    }
}
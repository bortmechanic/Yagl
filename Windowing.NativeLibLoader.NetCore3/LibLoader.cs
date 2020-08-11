using System;
using System.Reflection;
using System.Runtime.InteropServices;
using GLFW;

namespace Yagl.Windowing.NativeLibLoader.NetCore3
{
    public static class LibLoader
    {
        public static void Init()
        {
            NativeLibrary.SetDllImportResolver(typeof(Glfw).Assembly, ImportResolver);
        }

        private static IntPtr ImportResolver(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
        {
            var libHandle = IntPtr.Zero;
            if (libraryName != "glfw") return libHandle;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                NativeLibrary.TryLoad("glfw3.dll", assembly, DllImportSearchPath.ApplicationDirectory, out libHandle);
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                NativeLibrary.TryLoad("libglfw.so.3", assembly, DllImportSearchPath.ApplicationDirectory, out libHandle);
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                NativeLibrary.TryLoad("libglfw.3.dylib", assembly, DllImportSearchPath.ApplicationDirectory, out libHandle);
            return libHandle;
        }

    }
}
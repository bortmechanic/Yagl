using System;
using System.Threading;
using GLFW;

namespace Yagl.Windowing
{
    public class Window : IDisposable
    {
        private readonly NativeWindow _nativeWindow;

        public Window()
        {
            _nativeWindow = new NativeWindow();
        }

        public void Dispose()
        {
            _nativeWindow?.Dispose();
        }

        public void Run()
        {
            while (!_nativeWindow.IsClosed)
            {
                Thread.Sleep(5);
                Glfw.PollEvents();
            }
        }
    }
}
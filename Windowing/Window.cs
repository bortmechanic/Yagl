using System;
using System.Drawing;
using System.Threading;
using GLFW;
// ReSharper disable UnusedMember.Global

namespace Yagl.Windowing
{
    /// <summary>
    /// Represents a cross-platform window for drawing graphics.
    /// </summary>
    /// TODO: User Resizing options.
    /// TODO: Focus change event.
    /// TODO: Client size change event.
    /// TODO: Events processing.
    public class Window : IDisposable
    {
        private readonly NativeWindow _nativeWindow;

        public Window()
        {
            _nativeWindow = new NativeWindow();
        }

        public string Title
        {
            get => _nativeWindow.Title;
            set => _nativeWindow.Title = value;
        }

        public int Left
        {
            get => _nativeWindow.Position.X;
            set => _nativeWindow.Position = new Point(value, _nativeWindow.Position.Y);
        }
        
        public int Top
        {
            get => _nativeWindow.Position.Y;
            set => _nativeWindow.Position = new Point(_nativeWindow.Position.X, value);
        }

        public int Width
        {
            get => _nativeWindow.Size.Width;
            set => _nativeWindow.Size = new Size(value, _nativeWindow.Size.Height);
        }
        
        public int Height
        {
            get => _nativeWindow.Size.Height;
            set => _nativeWindow.Size = new Size(_nativeWindow.Size.Width, value);
        }
        
        public int ClientWidth
        {
            get => _nativeWindow.ClientSize.Width;
            set => _nativeWindow.ClientSize = new Size(value, _nativeWindow.ClientSize.Height);
        }
        
        public int ClientHeight
        {
            get => _nativeWindow.ClientSize.Height;
            set => _nativeWindow.ClientSize = new Size(_nativeWindow.ClientSize.Width, value);
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
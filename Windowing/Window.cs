using System;
using System.Drawing;
using System.Threading;
using GLFW;
// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable EventNeverSubscribedTo.Global

namespace Yagl.Windowing
{
    /// <summary>
    /// Represents a cross-platform window for drawing graphics.
    /// </summary>
    /// TODO: Client size change event.
    /// TODO: Events processing.
    /// TODO: Paint event.
    /// TODO: Closing and Closed events.
    public class Window : IDisposable
    {
        private readonly NativeWindow _nativeWindow;

        public Window()
        {
            _nativeWindow = new NativeWindow();
            ResizeMode = ResizeMode.Default;
            _nativeWindow.FocusChanged += OnFocusChanged;
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

        public ResizeMode ResizeMode
        {
            get => _nativeWindow.IsResizable ? ResizeMode.Resizable : ResizeMode.NotResizable;
            set => Glfw.SetWindowAttribute(_nativeWindow.Handle, WindowAttribute.Resizable,
                value == ResizeMode.Resizable);
        }

        public bool IsActive => _nativeWindow.IsFocused;

        public void Activate()
        {
            Glfw.FocusWindow(_nativeWindow);
        }

        public event EventHandler<EventArgs> Activated;
        public event EventHandler<EventArgs> DeActivated;
        
        private void OnFocusChanged(object sender, EventArgs e)
        {
            if (IsActive)
                Activated?.Invoke(this, EventArgs.Empty);
            else
                DeActivated?.Invoke(this, EventArgs.Empty);
        }

        public void Dispose()
        {
            _nativeWindow?.Dispose();
        }

        public void Run()
        {
            while (!_nativeWindow.IsClosed)
            {
                Glfw.PollEvents();
                Thread.Sleep(5);
            }
        }
    }
}
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
    /// TODO: Events processing.
    /// TODO: Closing and Closed events.
    public class Window : IDisposable
    {
        private readonly NativeWindow _wnd;

        #region Constructor(s)
        
        public Window()
        {
            _wnd = new NativeWindow();
            ResizeMode = ResizeMode.Default;
            _wnd.FocusChanged += OnFocusChanged;
            _wnd.SizeChanged += OnSizeChanged;
            _wnd.Refreshed += OnPaint;
        }

        #endregion

        #region Title
        
        public string Title
        {
            get => _wnd.Title;
            set => _wnd.Title = value;
        }
        
        #endregion

        #region Position and Size
        
        public int Left
        {
            get => _wnd.Position.X;
            set => _wnd.Position = new Point(value, _wnd.Position.Y);
        }
        
        public int Top
        {
            get => _wnd.Position.Y;
            set => _wnd.Position = new Point(_wnd.Position.X, value);
        }

        public int Width
        {
            get => _wnd.Size.Width;
            set => _wnd.Size = new Size(value, _wnd.Size.Height);
        }
        
        public int Height
        {
            get => _wnd.Size.Height;
            set => _wnd.Size = new Size(_wnd.Size.Width, value);
        }
        
        public int ClientWidth
        {
            get => _wnd.ClientSize.Width;
            set => _wnd.ClientSize = new Size(value, _wnd.ClientSize.Height);
        }
        
        public int ClientHeight
        {
            get => _wnd.ClientSize.Height;
            set => _wnd.ClientSize = new Size(_wnd.ClientSize.Width, value);
        }

        public ResizeMode ResizeMode
        {
            get => _wnd.IsResizable ? ResizeMode.Resizable : ResizeMode.NotResizable;
            set => Glfw.SetWindowAttribute(_wnd.Handle, WindowAttribute.Resizable,
                value == ResizeMode.Resizable);
        }
        
        public event EventHandler<SizeChangedEventArgs> SizeChanged;
        
        private void OnSizeChanged(object sender, SizeChangeEventArgs e)
        {
            SizeChanged?.Invoke(this, new SizeChangedEventArgs
                {Width = Width, Height = Height, ClientWidth = ClientWidth, ClientHeight = ClientHeight});
        }
        
        #endregion
        
        #region Active Status

        public bool IsActive => _wnd.IsFocused;

        public void Activate()
        {
            Glfw.FocusWindow(_wnd);
        }

        public event EventHandler<ActivatedEventArgs> Activated;
        public event EventHandler<DeActivatedEventArgs> DeActivated;
        
        private void OnFocusChanged(object sender, EventArgs e)
        {
            if (IsActive)
                Activated?.Invoke(this, ActivatedEventArgs.Instance);
            else
                DeActivated?.Invoke(this, DeActivatedEventArgs.Instance);
        }
        
        #endregion
        
        #region Repainting window

        public event EventHandler<RepaintEventArgs> RePaint;
        
        private void OnPaint(object sender, EventArgs e)
        {
            RePaint?.Invoke(this, RepaintEventArgs.Instance);
        }
        
        #endregion
        
        #region Disposable

        public void Dispose()
        {
            _wnd?.Dispose();
        }
        
        #endregion

        public void Run()
        {
            while (!_wnd.IsClosed)
            {
                Glfw.PollEvents();
                Thread.Sleep(5);
            }
        }
    }
}
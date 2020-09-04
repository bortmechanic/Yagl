/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable UnusedType.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable NotAccessedField.Global
// ReSharper disable UnusedParameter.Global
// ReSharper disable VirtualMemberNeverOverridden.Global
// ReSharper disable MemberCanBeProtected.Global

using System;
using Yagl.Components;
using Yagl.Graphics;
using Yagl.Input;
using Yagl.Windowing;

namespace Yagl.Gaming
{
    public class Game : IDisposable
    {
        protected readonly Window Window;
        protected readonly Collection Components;
        private readonly Context _context;
        private readonly GameLoop _gameLoop;

        protected Game()
        {
            Window = new Window();
            Window.Closed += WindowClosed;
            _context = new Context();
            _gameLoop = new GameLoop();
            _gameLoop.Initialize += InitializeInternal;
            _gameLoop.Update += UpdateInternal;
            _gameLoop.Draw += DrawInternal;
            _gameLoop.ShutDown += ShutDownInternal;
            Components = _context.Components;
            GL.Init(Window.GetProcAddressDelegate());
            Keyboard.Init(Window.GetNativeWindow());
        }

        private void WindowClosed(object sender, ClosedEventArgs e)
        {
            Exit();
        }

        public void Run()
        {
            _gameLoop.Run();
        }

        public void Exit()
        {
            _gameLoop.Exit();
        }

        protected virtual void Initialize()
        {
            Console.WriteLine("GAME INITIALIZE.");
        }

        protected virtual void LoadContent()
        {
            Console.WriteLine("GAME LOAD CONTENT.");
        }

        protected virtual void Update(Time time)
        {
            Console.WriteLine("GAME UPDATE.");
        }

        protected virtual void Draw(Time time)
        {
            Console.WriteLine("GAME DRAW.");
        }

        protected virtual void UnloadContent()
        {
            Console.WriteLine("GAME UNLOAD CONTENT.");
        }

        protected virtual void ShutDown()
        {
            Console.WriteLine("GAME SHUTDOWN.");
        }

        private void InitializeInternal()
        {
            Initialize();
            LoadContent();
            _context.Initialize();
        }
        
        private void UpdateInternal(TimeSpan elapsed, TimeSpan totalElapsed)
        {
            Keyboard.Keys.ClearEvents();
            Window.ProcessEvents();
            var time = new Time(elapsed, totalElapsed);
            Update(time);
            _context.Update(time);
        }

        private void DrawInternal(TimeSpan elapsed, TimeSpan totalElapsed)
        {
            var time = new Time(elapsed, totalElapsed);
            Draw(time);
            _context.Draw(time);
            Window.SwapBuffers();
        }
        private void ShutDownInternal()
        {
            _context.ShutDown();
            UnloadContent();
            ShutDown();
        }
        
        public void Dispose()
        {
            Window?.Dispose();
        }
    }
}
/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System;
using Yagl.Components;
using Yagl.Gaming;
using Yagl.Graphics;
using Yagl.Input;
using Yagl.Windowing;

namespace Yagl.Demo
{
    public class TestGame : Game
    {
        public TestGame()
        {
            Window.Title = "YAGL Demo Project";
            Window.Decorations = Decorations.Default;
            Window.ClientWidth = 800;
            Window.ClientHeight = 600;
            Window.ResizeMode = ResizeMode.Resizable;
        }
        
        protected override void Initialize()
        {
        }

        protected override void LoadContent()
        {
        }

        protected override void Update(Time time)
        {
            for (var i = 32; i < 256; i++)
            {
                var keyCode = (KeyCode) i;
                var key = Keyboard.Keys[keyCode];
                if (key.Event != KeyEvent.None)
                    Console.WriteLine($"{key.Code} {key.Event}.");
            }

            if (Keyboard.IsKeyPressed(KeyCode.Escape))
                Exit();
        }

        protected override void Draw(Time time)
        {
            GL.ClearColor(0.75f, 0.35f, 0.0f, 1.0f);  // Yellow.
            GL.Clear(16384);

            // Draw a triangle:
            GL.Begin(GL.TRIANGLES);
            GL.Color3f(1.0f, 0.0f, 0.0f);
            GL.Vertex3f(-0.5f, -0.5f, 0);
            GL.Color3f(0.0f, 1.0f, 0.0f);
            GL.Vertex3f(0.5f, 0.0f, 0);
            GL.Color3f(0.0f, 0.0f, 1.0f);
            GL.Vertex3f(0.0f, 0.5f, 0);
            GL.End();
        }

        protected override void UnloadContent()
        {
        }

        protected override void ShutDown()
        {
        }
    }
}
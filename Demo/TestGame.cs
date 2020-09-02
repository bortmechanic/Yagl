/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using Yagl.Components;
using Yagl.Gaming;
using Yagl.Graphics;
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
            if (time.TotalElapsed.TotalSeconds > 10)
                Exit();
        }

        protected override void Draw(Time time)
        {
            Gl.ClearColor(0.75f, 0.35f, 0.0f, 1.0f);  // Yellow.
            Gl.Clear(16384);

            // Draw a triangle:
            Gl.Begin(Gl.TRIANGLES);
            Gl.Color3f(1.0f, 0.0f, 0.0f);
            Gl.Vertex3f(-0.5f, -0.5f, 0);
            Gl.Color3f(0.0f, 1.0f, 0.0f);
            Gl.Vertex3f(0.5f, 0.0f, 0);
            Gl.Color3f(0.0f, 0.0f, 1.0f);
            Gl.Vertex3f(0.0f, 0.5f, 0);
            Gl.End();
        }

        protected override void UnloadContent()
        {
        }

        protected override void ShutDown()
        {
        }
    }
}
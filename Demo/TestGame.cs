/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using Yagl.Audio;
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

        private uint _audioSource;
        private uint _audioBuffer;

        protected override void Initialize()
        {
            AL.Listener3f(AL.POSITION, 0, 0, 1);
            AL.Listener3f(AL.VELOCITY, 0, 0, 0);
            AL.Listener3f(AL.ORIENTATION, 0, 0, -1);
            
            var audioSources = new uint[1];
            AL.GenSources(1, audioSources);
            _audioSource = audioSources[0];
            AL.Sourcef(_audioSource, AL.PITCH, 1);
            AL.Sourcef(_audioSource, AL.GAIN, 1);
            AL.Source3f(_audioSource, AL.POSITION, 0, 0, 0);
            AL.Source3f(_audioSource, AL.VELOCITY, 0, 0, 0);
            AL.Sourcei(_audioSource, AL.LOOPING, AL.FALSE);
            
            var audioBuffers = new uint[1];
            AL.GenBuffers(1, audioBuffers);
            _audioBuffer = audioBuffers[0];
            var wav = WavData.Load("test.wav");
            AL.BufferData(_audioBuffer, wav.Format, wav.Data, (uint)wav.Data.Length, wav.Freqency);
            AL.Sourcei(_audioSource, AL.BUFFER, (int)_audioBuffer);
        }

        protected override void LoadContent()
        {
        }

        protected override void Update(Time time)
        {
            if (Keyboard.GetKeyEvent(KeyCode.P) == KeyEvent.Pressed)
            {
                AL.SourcePlay(_audioSource);
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
            AL.DeleteSources(1, new[] {_audioSource});
            AL.DeleteBuffers(1, new[] {_audioBuffer});
        }
    }
}
/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable UnusedMember.Global
// ReSharper disable EventNeverSubscribedTo.Global
// ReSharper disable UnusedType.Global

using System;
using System.Diagnostics;

namespace Yagl
{
    public class GameLoop
    {
        public GameLoopType Type { get; set; }
            
        private readonly Stopwatch _timer;
        private bool _exitRequested;

        public GameLoop()
        {
            _timer = new Stopwatch();
        }
        
        public void Run()
        {
            _timer.Restart();
            var checkPoint = _timer.Elapsed;

            Initialize?.Invoke();
            while (!_exitRequested)
            {
                var totalTime = _timer.Elapsed;
                var elapsed = totalTime - checkPoint;
                checkPoint = totalTime;
                GetUserInput?.Invoke();
                Update?.Invoke(elapsed, totalTime);
                Draw?.Invoke(elapsed, totalTime);
            }
            ShutDown?.Invoke();
        }

        public event InitializeDelegate Initialize;
        public event GetUserInputDelegate GetUserInput;
        public event UpdateDelegate Update;
        public event DrawDelegate Draw;
        public event ShutDownDelegate ShutDown;

        public delegate void InitializeDelegate();
        public delegate void GetUserInputDelegate();
        public delegate void UpdateDelegate(TimeSpan elapsed, TimeSpan totalElapsed);
        public delegate void DrawDelegate(TimeSpan elapsed, TimeSpan totalElapsed);
        public delegate void ShutDownDelegate();

        public void Exit()
        {
            _exitRequested = true;
        }
    }
}
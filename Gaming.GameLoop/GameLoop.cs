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
using System.Threading;

namespace Yagl.Gaming
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
            while (true)
            {
                var totalElapsed = _timer.Elapsed;
                var elapsed = totalElapsed - checkPoint;
                checkPoint = totalElapsed;
                Update?.Invoke(elapsed, totalElapsed);
                if (_exitRequested) break;
                Draw?.Invoke(elapsed, totalElapsed);
                Thread.Sleep(5);
            }
            ShutDown?.Invoke();
        }

        public event InitializeDelegate Initialize;
        public event UpdateDelegate Update;
        public event DrawDelegate Draw;
        public event ShutDownDelegate ShutDown;

        public delegate void InitializeDelegate();
        public delegate void UpdateDelegate(TimeSpan elapsed, TimeSpan totalElapsed);
        public delegate void DrawDelegate(TimeSpan elapsed, TimeSpan totalElapsed);
        public delegate void ShutDownDelegate();

        public void Exit()
        {
            _exitRequested = true;
        }
    }
}
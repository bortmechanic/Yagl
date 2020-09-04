/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable UnusedMember.Global

using System;

namespace Yagl.Input
{
    public class Keys
    {
        private readonly int _offset;
        private readonly int _size;
        private readonly KeyState[] _states;
        private readonly KeyEvent[] _events;
        private readonly Key[] _keys;

        public Keys(int offset, int size)
        {
            _offset = offset;
            _size = size;
            _states = new KeyState[size];
            _events = new KeyEvent[size];
            _keys = new Key[size];
            for (var i = 0; i < _size; i++)
                _keys[i] = new Key((KeyCode)(i+ _offset), this);
        }

        private int KeyCodeToIndex(KeyCode key)
        {
            var index = (int) key - _offset;
            if (index < 0 || index >= _size)
                throw new InvalidOperationException();
            return index;
        }
        
        public Key this[KeyCode key] => _keys[KeyCodeToIndex(key)];

        internal KeyState GetKeyState(KeyCode key) => _states[KeyCodeToIndex(key)];

        internal KeyEvent GetKeyEvent(KeyCode key) => _events[KeyCodeToIndex(key)];

        internal bool IsKeyPressed(KeyCode key) => _states[KeyCodeToIndex(key)] == KeyState.Pressed;

        public void ClearEvents()
        {
            for (var i = 0; i < _size; i++)
                _events[i] = KeyEvent.None;
        }

        public void ProcessEvent(KeyCode key, KeyEvent evnt)
        {
            var i = KeyCodeToIndex(key);
            _events[i] = evnt;
            if (evnt == KeyEvent.Pressed)
                _states[i] = KeyState.Pressed;
            else if (evnt == KeyEvent.Released)
                _states[i] = KeyState.Released;
        }
    }
}
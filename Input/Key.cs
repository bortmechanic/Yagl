/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global

namespace Yagl.Input
{
    public class Key
    {
        internal Key(KeyCode code, Keys keys)
        {
            Code = code;
            _keys = keys;
        }

        private readonly Keys _keys;

        public KeyCode Code { get; }
        public KeyState State => _keys.GetKeyState(Code);
        public KeyEvent Event => _keys.GetKeyEvent(Code);
    }
}
/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global

using System;
using GLFW;

namespace Yagl.Input
{
    public static class Keyboard
    {
        public static void Init(Window window)
        {
            Glfw.SetKeyCallback(window, KeyCallback);
        }

        public static readonly Keys Keys = new Keys(32, 224);

        public static KeyState GetKeyState(KeyCode key) => Keys.GetKeyState(key);

        public static KeyEvent GetKeyEvent(KeyCode key) => Keys.GetKeyEvent(key);

        public static bool IsKeyPressed(KeyCode key) => Keys.IsKeyPressed(key);

        private static void KeyCallback(IntPtr window, GLFW.Keys key, int scanCode, InputState state, ModifierKeys mods)
        {
            var keyCode = KeyMap.Get(key);
            var evnt = KeyMap.Get(state);
            Keys.ProcessEvent(keyCode, evnt);
        }
    }
}
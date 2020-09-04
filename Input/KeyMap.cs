/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

namespace Yagl.Input
{
    internal static class KeyMap
    {
        private static readonly KeyCode[] Map;
        private static readonly KeyEvent[] EventMap;

        static KeyMap()
        {
            Map = new KeyCode[349];
            Map[(int) GLFW.Keys.Space] = KeyCode.Space;
            Map[(int) GLFW.Keys.Apostrophe] = KeyCode.Apostrophe;
            Map[(int) GLFW.Keys.Comma] = KeyCode.Comma;
            Map[(int) GLFW.Keys.Minus] = KeyCode.Hyphen;
            Map[(int) GLFW.Keys.Period] = KeyCode.Period;
            Map[(int) GLFW.Keys.Slash] = KeyCode.Slash;
            Map[(int) GLFW.Keys.Alpha0] = KeyCode.D0;
            Map[(int) GLFW.Keys.Alpha1] = KeyCode.D1;
            Map[(int) GLFW.Keys.Alpha2] = KeyCode.D2;
            Map[(int) GLFW.Keys.Alpha3] = KeyCode.D3;
            Map[(int) GLFW.Keys.Alpha4] = KeyCode.D4;
            Map[(int) GLFW.Keys.Alpha5] = KeyCode.D5;
            Map[(int) GLFW.Keys.Alpha6] = KeyCode.D6;
            Map[(int) GLFW.Keys.Alpha7] = KeyCode.D7;
            Map[(int) GLFW.Keys.Alpha8] = KeyCode.D8;
            Map[(int) GLFW.Keys.Alpha9] = KeyCode.D9;
            Map[(int) GLFW.Keys.SemiColon] = KeyCode.SemiColon;
            Map[(int) GLFW.Keys.Equal] = KeyCode.Equal;
            Map[(int) GLFW.Keys.A] = KeyCode.A;
            Map[(int) GLFW.Keys.B] = KeyCode.B;
            Map[(int) GLFW.Keys.C] = KeyCode.C;
            Map[(int) GLFW.Keys.D] = KeyCode.D;
            Map[(int) GLFW.Keys.E] = KeyCode.E;
            Map[(int) GLFW.Keys.F] = KeyCode.F;
            Map[(int) GLFW.Keys.G] = KeyCode.G;
            Map[(int) GLFW.Keys.H] = KeyCode.H;
            Map[(int) GLFW.Keys.I] = KeyCode.I;
            Map[(int) GLFW.Keys.J] = KeyCode.J;
            Map[(int) GLFW.Keys.K] = KeyCode.K;
            Map[(int) GLFW.Keys.L] = KeyCode.L;
            Map[(int) GLFW.Keys.M] = KeyCode.M;
            Map[(int) GLFW.Keys.N] = KeyCode.N;
            Map[(int) GLFW.Keys.O] = KeyCode.O;
            Map[(int) GLFW.Keys.P] = KeyCode.P;
            Map[(int) GLFW.Keys.Q] = KeyCode.Q;
            Map[(int) GLFW.Keys.R] = KeyCode.R;
            Map[(int) GLFW.Keys.S] = KeyCode.S;
            Map[(int) GLFW.Keys.T] = KeyCode.T;
            Map[(int) GLFW.Keys.U] = KeyCode.U;
            Map[(int) GLFW.Keys.V] = KeyCode.V;
            Map[(int) GLFW.Keys.W] = KeyCode.W;
            Map[(int) GLFW.Keys.X] = KeyCode.X;
            Map[(int) GLFW.Keys.Y] = KeyCode.Y;
            Map[(int) GLFW.Keys.Z] = KeyCode.Z;
            Map[(int) GLFW.Keys.LeftBracket] = KeyCode.LeftBracket;
            Map[(int) GLFW.Keys.Backslash] = KeyCode.BackSlash;
            Map[(int) GLFW.Keys.RightBracket] = KeyCode.RightBracket;
            Map[(int) GLFW.Keys.GraveAccent] = KeyCode.GraveAccent;
            Map[(int) GLFW.Keys.World1] = KeyCode.Tilde;
            Map[(int) GLFW.Keys.World2] = KeyCode.None;
            Map[(int) GLFW.Keys.Escape] = KeyCode.Escape;
            Map[(int) GLFW.Keys.Enter] = KeyCode.Enter;
            Map[(int) GLFW.Keys.Tab] = KeyCode.Tab;
            Map[(int) GLFW.Keys.Backspace] = KeyCode.Backspace;
            Map[(int) GLFW.Keys.Insert] = KeyCode.Insert;
            Map[(int) GLFW.Keys.Delete] = KeyCode.Delete;
            Map[(int) GLFW.Keys.Right] = KeyCode.Right;
            Map[(int) GLFW.Keys.Left] = KeyCode.Left;
            Map[(int) GLFW.Keys.Down] = KeyCode.Down;
            Map[(int) GLFW.Keys.Up] = KeyCode.Up;
            Map[(int) GLFW.Keys.PageUp] = KeyCode.PageUp;
            Map[(int) GLFW.Keys.PageDown] = KeyCode.PageDown;
            Map[(int) GLFW.Keys.Home] = KeyCode.Home;
            Map[(int) GLFW.Keys.End] = KeyCode.End;
            Map[(int) GLFW.Keys.CapsLock] = KeyCode.CapsLock;
            Map[(int) GLFW.Keys.ScrollLock] = KeyCode.ScrollLock;
            Map[(int) GLFW.Keys.NumLock] = KeyCode.NumLock;
            Map[(int) GLFW.Keys.PrintScreen] = KeyCode.PrintScreen;
            Map[(int) GLFW.Keys.Pause] = KeyCode.Pause;
            Map[(int) GLFW.Keys.F1] = KeyCode.F1;
            Map[(int) GLFW.Keys.F2] = KeyCode.F2;
            Map[(int) GLFW.Keys.F3] = KeyCode.F3;
            Map[(int) GLFW.Keys.F4] = KeyCode.F4;
            Map[(int) GLFW.Keys.F5] = KeyCode.F5;
            Map[(int) GLFW.Keys.F6] = KeyCode.F6;
            Map[(int) GLFW.Keys.F7] = KeyCode.F7;
            Map[(int) GLFW.Keys.F8] = KeyCode.F8;
            Map[(int) GLFW.Keys.F9] = KeyCode.F9;
            Map[(int) GLFW.Keys.F10] = KeyCode.F10;
            Map[(int) GLFW.Keys.F11] = KeyCode.F11;
            Map[(int) GLFW.Keys.F12] = KeyCode.F12;
            Map[(int) GLFW.Keys.F13] = KeyCode.F13;
            Map[(int) GLFW.Keys.F14] = KeyCode.F14;
            Map[(int) GLFW.Keys.F15] = KeyCode.F15;
            Map[(int) GLFW.Keys.F16] = KeyCode.F16;
            Map[(int) GLFW.Keys.F17] = KeyCode.F17;
            Map[(int) GLFW.Keys.F18] = KeyCode.F18;
            Map[(int) GLFW.Keys.F19] = KeyCode.F19;
            Map[(int) GLFW.Keys.F20] = KeyCode.F20;
            Map[(int) GLFW.Keys.F21] = KeyCode.F21;
            Map[(int) GLFW.Keys.F22] = KeyCode.F22;
            Map[(int) GLFW.Keys.F23] = KeyCode.F23;
            Map[(int) GLFW.Keys.F24] = KeyCode.F24;
            Map[(int) GLFW.Keys.F25] = KeyCode.None;
            Map[(int) GLFW.Keys.Numpad0] = KeyCode.NumD0;
            Map[(int) GLFW.Keys.Numpad1] = KeyCode.NumD1;
            Map[(int) GLFW.Keys.Numpad2] = KeyCode.NumD2;
            Map[(int) GLFW.Keys.Numpad3] = KeyCode.NumD3;
            Map[(int) GLFW.Keys.Numpad4] = KeyCode.NumD4;
            Map[(int) GLFW.Keys.Numpad5] = KeyCode.NumD5;
            Map[(int) GLFW.Keys.Numpad6] = KeyCode.NumD6;
            Map[(int) GLFW.Keys.Numpad7] = KeyCode.NumD7;
            Map[(int) GLFW.Keys.Numpad8] = KeyCode.NumD8;
            Map[(int) GLFW.Keys.Numpad9] = KeyCode.NumD9;
            Map[(int) GLFW.Keys.NumpadDecimal] = KeyCode.NumDecimal;
            Map[(int) GLFW.Keys.NumpadDivide] = KeyCode.NumDivide;
            Map[(int) GLFW.Keys.NumpadMultiply] = KeyCode.NumMultiply;
            Map[(int) GLFW.Keys.NumpadSubtract] = KeyCode.NumMinus;
            Map[(int) GLFW.Keys.NumpadAdd] = KeyCode.NumPlus;
            Map[(int) GLFW.Keys.NumpadEnter] = KeyCode.NumEnter;
            Map[(int) GLFW.Keys.NumpadEqual] = KeyCode.NumEqual;
            Map[(int) GLFW.Keys.LeftShift] = KeyCode.ShiftLeft;
            Map[(int) GLFW.Keys.LeftControl] = KeyCode.ControlLeft;
            Map[(int) GLFW.Keys.LeftAlt] = KeyCode.AltLeft;
            Map[(int) GLFW.Keys.LeftSuper] = KeyCode.WindowsLeft;
            Map[(int) GLFW.Keys.RightShift] = KeyCode.ShiftRight;
            Map[(int) GLFW.Keys.RightControl] = KeyCode.ControlRight;
            Map[(int) GLFW.Keys.RightAlt] = KeyCode.AltRight;
            Map[(int) GLFW.Keys.RightSuper] = KeyCode.WindowsRight;
            Map[(int) GLFW.Keys.Menu] = KeyCode.Menu;
            
            EventMap = new KeyEvent[3];
            EventMap[(int) GLFW.InputState.Press] = KeyEvent.Pressed;
            EventMap[(int) GLFW.InputState.Release] = KeyEvent.Released;
            EventMap[(int) GLFW.InputState.Repeat] = KeyEvent.Repeated;
        }

        public static KeyCode Get(GLFW.Keys key)
        {
            var i = (int) key;
            if (i < 0 || i > 348) return KeyCode.None;
            return Map[i];
        }

        public static KeyEvent Get(GLFW.InputState state)
        {
            return EventMap[(int)state];
        }
    }
}

/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable UnusedMember.Global

namespace Yagl.Input
{
    public enum KeyCode : byte
    {
        None = 0x00,
        
        // Mouse Buttons 00..07.
        MouseLeft = 0x01,
        MouseRight = 0x02,
        MouseMiddle = 0x03,
        MouseBut4 = 0x04,
        MouseBut5 = 0x05,
        // Reserved 06..07.
        
        // Joystick Buttons 08..1F.
        // Reserved 08..0F.
        JoyBut1 = 0x10,
        JoyBut2 = 0x11,
        JoyBut3 = 0x12,
        JoyBut4 = 0x13,
        JoyBut5 = 0x14,
        JoyBut6 = 0x15,
        JoyBut7 = 0x16,
        JoyBut8 = 0x17,
        JoyBut9 = 0x18,
        JoyBut10 = 0x19,
        JoyBut11 = 0x1A,
        JoyBut12 = 0x1B,
        JoyBut13 = 0x1C,
        JoyBut14 = 0x1D,
        JoyBut15 = 0x1E,
        JoyBut16 = 0x1F,

        // Digits.
        D0 = 0x30,
        D1 = 0x31,
        D2 = 0x32,
        D3 = 0x33,
        D4 = 0x34,
        D5 = 0x35,
        D6 = 0x36,
        D7 = 0x37,
        D8 = 0x38,
        D9 = 0x39,
        
        // Letters.
        Space = 0x20,
        Apostrophe = 0x27,
        Comma = 0x2C,
        Hyphen = 0x2D,
        Period = 0x2E,
        Slash = 0x2F,
        BackSlash = 0x5C,
        
        SemiColon = 0x3B,
        Equal = 0x3D,
        LeftBracket = 0x5B,
        RightBracket = 0x5D,
        Tilde = 0x21,
        GraveAccent = 0x60,

        A = 0x41,
        B = 0x42,
        C = 0x43,
        D = 0x44,
        E = 0x45,
        F = 0x46,
        G = 0x47,
        H = 0x48,
        I = 0x49,
        J = 0x4A,
        K = 0x4B,
        L = 0x4C,
        M = 0x4D,
        N = 0x4E,
        O = 0x4F,
        P = 0x50,
        Q = 0x51,
        R = 0x52,
        S = 0x53,
        T = 0x54,
        U = 0x55,
        V = 0x56,
        W = 0x57,
        X = 0x58,
        Y = 0x59,
        Z = 0x5A,
        
        // Modifiers.
        WindowsLeft = 0x61,
        CommandLeft = 0x61,
        WindowsRight = 0x62,
        CommandRight = 0x62,
        ShiftLeft = 0x63,
        ShiftRight = 0x64,
        ControlLeft = 0x65,
        ControlRight = 0x66,
        AltLeft = 0x67,
        AltRight = 0x68,
        Menu = 0x69,
        // Reserved 6A..6F.
        
        // Function Buttons 70..
        F1 = 0x70,
        F2 = 0x71,
        F3 = 0x72,
        F4 = 0x73,
        F5 = 0x74,
        F6 = 0x75,
        F7 = 0x76,
        F8 = 0x77,
        F9 = 0x78,
        F10 = 0x79,
        F11 = 0x7A,
        F12 = 0x7B,
        F13 = 0x7C,
        F14 = 0x7D,
        F15 = 0x7E,
        F16 = 0x7F,
        F17 = 0x80,
        F18 = 0x81,
        F19 = 0x82,
        F20 = 0x83,
        F21 = 0x84,
        F22 = 0x85,
        F23 = 0x86,
        F24 = 0x87,
            
        // Action Buttons.
        Left = 0x88,
        Up = 0x89,
        Right = 0x8A,
        Down = 0x8B,
        Enter = 0x8C,
        Escape = 0x8D,
        Backspace = 0x8E,
        Delete = 0x8F,
        Tab = 0x90,
        CapsLock = 0x91,
        Pause = 0x92,
        PageUp = 0x93,
        PageDown = 0x94,
        End = 0x95,
        Home = 0x96,
        PrintScreen = 0x97,
        Insert = 0x98,
        ScrollLock = 0x9A,
        NumLock = 0x9B,
        
        // NumPad A0..AF.
        NumD0 = 0xA0,
        NumD1 = 0xA1,
        NumD2 = 0xA2,
        NumD3 = 0xA3,
        NumD4 = 0xA4,
        NumD5 = 0xA5,
        NumD6 = 0xA6,
        NumD7 = 0xA7,
        NumD8 = 0xA8,
        NumD9 = 0xA9,
        NumDecimal = 0xAA,
        NumPlus = 0xAB,
        NumMinus = 0xAC,
        NumMultiply = 0xAD,
        NumDivide = 0xAE,
        NumEnter = 0xAF,
        NumEqual = 0xB0,
        
        // Multimedia and other special keys B1..FF.
        VolumeUp = 0xB1,
        VolumeDown = 0xB2,
        VolumeMute = 0xB3,
        
        MediaNext = 0xB8,
        MediaPrevious = 0xB9,
        MediaStop = 0xBA,
        MediaPlayPause = 0xBB,
        
        BrowserBack = 0xC0,
        BrowserForward = 0xC1,
        BrowserRefresh = 0xC2,
        BrowserStop = 0xC3,
        BrowserSearch = 0xC4,
        BrowserFavorites = 0xC5,
        BrowserHome = 0xC6,

        Browser = 0xD0,
        Mail = 0xD1,
        App1 = 0xD2,
        App2 = 0xD3,
        
    }
}
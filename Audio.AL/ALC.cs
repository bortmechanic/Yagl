/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable CommentTypo
// ReSharper disable IdentifierTypo

using System;
using System.Runtime.InteropServices;

namespace Yagl.Audio
{
    public static class ALC
    {
        private const string Lib = "OpenAL";

        public const /*ALCboolean*/ byte FALSE = 0x00;
        public const /*ALCboolean*/ byte TRUE = 0x01;
        
        public const /*ALCenum*/ uint INVALID = 0x0000;
        public const /*ALCenum*/ uint NO_ERROR = 0x0000;
        public const /*ALCenum*/ uint EXT_CAPTURE = 0x0001;
        public const /*ALCenum*/ uint ENUMERATE_ALL_EXT = 0x0001;
        public const /*ALCenum*/ uint CAPTURE_DEVICE_SPECIFIER = 0x0310;
        public const /*ALCenum*/ uint CAPTURE_DEFAULT_DEVICE_SPECIFIER = 0x0311;
        public const /*ALCenum*/ uint CAPTURE_SAMPLES = 0x0312;
        public const /*ALCenum*/ uint MAJOR_VERSION = 0x1000;
        public const /*ALCenum*/ uint MINOR_VERSION = 0x1001;
        public const /*ALCenum*/ uint ATTRIBUTES_SIZE = 0x1002;
        public const /*ALCenum*/ uint ALL_ATTRIBUTES = 0x1003;
        public const /*ALCenum*/ uint DEFAULT_DEVICE_SPECIFIER = 0x1004;
        public const /*ALCenum*/ uint DEVICE_SPECIFIER = 0x1005;
        public const /*ALCenum*/ uint EXTENSIONS = 0x1006;
        public const /*ALCenum*/ uint FREQUENCY = 0x1007;
        public const /*ALCenum*/ uint REFRESH = 0x1008;
        public const /*ALCenum*/ uint SYNC = 0x1009;
        public const /*ALCenum*/ uint MONO_SOURCES = 0x1010;
        public const /*ALCenum*/ uint STEREO_SOURCES = 0x1011;
        public const /*ALCenum*/ uint DEFAULT_ALL_DEVICES_SPECIFIER = 0x1012;
        public const /*ALCenum*/ uint ALL_DEVICES_SPECIFIER = 0x1013;
        public const /*ALCenum*/ uint INVALID_DEVICE = 0xA001;
        public const /*ALCenum*/ uint INVALID_CONTEXT = 0xA002;
        public const /*ALCenum*/ uint INVALID_ENUM = 0xA003;
        public const /*ALCenum*/ uint INVALID_VALUE = 0xA004;
        public const /*ALCenum*/ uint OUT_OF_MEMORY = 0xA005;


        // CONTEXT MANAGEMENT FUNCTIONS

        [DllImport(Lib, EntryPoint = "alcCreateContext")]
        public static extern /*ALCcontext**/ IntPtr CreateContext( /*ALCdevice **/ IntPtr device, /*const ALCint **/ int[] attrList);

        [DllImport(Lib, EntryPoint = "alcMakeContextCurrent")]
        public static extern /*ALCboolean*/ byte MakeContextCurrent( /*ALCcontext **/ IntPtr context);

        [DllImport(Lib, EntryPoint = "alcProcessContext")]
        public static extern /*ALCvoid*/ void ProcessContext( /*ALCcontext **/ IntPtr context);

        [DllImport(Lib, EntryPoint = "alcSuspendContext")]
        public static extern /*ALCvoid*/ void SuspendContext( /*ALCcontext **/ IntPtr context);

        [DllImport(Lib, EntryPoint = "alcDestroyContext")]
        public static extern /*ALCvoid*/ void DestroyContext( /*ALCcontext **/ IntPtr context);

        [DllImport(Lib, EntryPoint = "alcGetCurrentContext")]
        public static extern /*ALCcontext**/ IntPtr GetCurrentContext( /*ALCvoid*/);

        [DllImport(Lib, EntryPoint = "alcGetContextsDevice")]
        public static extern /*ALCdevice**/ IntPtr GetContextsDevice( /*ALCcontext **/ IntPtr context);
        
        
        // CONTEXT ERROR FUNCTIONS
        
        [DllImport(Lib, EntryPoint = "alcGetError")]
        public static extern /*ALCenum*/ uint GetError( /*ALCdevice **/ IntPtr device);
        
        
        // CONTEXT DEVICE FUNCTIONS
        
        [DllImport(Lib, EntryPoint = "alcOpenDevice")]
        public static extern /*ALCdevice**/ IntPtr OpenDevice( /*const ALCchar **/ string deviceName);

        [DllImport(Lib, EntryPoint = "alcCloseDevice")]
        public static extern /*ALCboolean*/ byte CloseDevice( /*ALCdevice **/ IntPtr device);
        
        
        // CONTEXT EXTENSION FUNCTIONS
        
        [DllImport(Lib, EntryPoint = "alcIsExtensionPresent")]
        public static extern /*ALCboolean*/ byte IsExtensionPresent( /*ALCdevice **/ IntPtr device, /*const ALCchar **/ string extname);

        [DllImport(Lib, EntryPoint = "alcGetProcAddress")]
        public static extern /*void**/ IntPtr GetProcAddress( /*ALCdevice **/ IntPtr device, /*const ALCchar **/ string funcName);

        [DllImport(Lib, EntryPoint = "alcGetEnumValue")]
        public static extern /*ALCenum*/ uint GetEnumValue( /*ALCdevice **/ IntPtr device, /*const ALCchar **/ string enumName);

        
        // CONTEXT STATE FUNCTIONS
        
        [DllImport(Lib, EntryPoint = "alcGetString")]
        public static extern /*const ALCchar **/ string GetString( /*ALCdevice **/ IntPtr device, /*ALCenum*/ uint param);

        [DllImport(Lib, EntryPoint = "alcGetIntegerv")]
        public static extern /*ALCvoid*/ void GetIntegerv( /*ALCdevice **/ IntPtr device, /*ALCenum*/ uint param, /*ALCsizei*/ uint size, /*ALCint **/ int[] values);

        
        // CONTEXT CAPTURE FUNCTIONS
        
        [DllImport(Lib, EntryPoint = "alcCaptureOpenDevice")]
        public static extern /*ALCdevice**/ IntPtr CaptureOpenDevice( /*const ALCchar **/ string deviceName, /*ALCuint*/ uint frequency, /*ALCenum*/ uint format, /*ALCsizei*/ uint bufferSize);

        [DllImport(Lib, EntryPoint = "alcCaptureCloseDevice")]
        public static extern /*ALCboolean*/ byte CaptureCloseDevice( /*ALCdevice **/ IntPtr device);

        [DllImport(Lib, EntryPoint = "alcCaptureStart")]
        public static extern /*ALCvoid*/ void CaptureStart( /*ALCdevice **/ IntPtr device);

        [DllImport(Lib, EntryPoint = "alcCaptureStop")]
        public static extern /*ALCvoid*/ void CaptureStop( /*ALCdevice **/ IntPtr device);

        [DllImport(Lib, EntryPoint = "alcCaptureSamples")]
        public static extern /*ALCvoid*/ void CaptureSamples( /*ALCdevice **/ IntPtr device, /*ALCvoid **/ byte[] buffer, /*ALCsizei*/ uint samples);
        
    }
}
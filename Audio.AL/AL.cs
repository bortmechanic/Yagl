/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedType.Global
// ReSharper disable IdentifierTypo
// ReSharper disable UnusedMember.Global
// ReSharper disable CommentTypo
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

namespace Yagl.Audio
{
    public static class AL
    {
        private const string Lib = "OpenAL";
        
        public const /*ALbollean*/ byte FALSE = 0x00;
        public const /*ALbollean*/ byte TRUE = 0x01;
        
        public const /*ALenum*/ uint NONE = 0x0000;
        public const /*ALenum*/ uint NO_ERROR = 0x0000;
        public const /*ALenum*/ uint SOURCE_RELATIVE = 0x202;
        public const /*ALenum*/ uint CONE_INNER_ANGLE = 0x1001;
        public const /*ALenum*/ uint CONE_OUTER_ANGLE = 0x1002;
        public const /*ALenum*/ uint PITCH = 0x1003;
        public const /*ALenum*/ uint POSITION = 0x1004;
        public const /*ALenum*/ uint DIRECTION = 0x1005;
        public const /*ALenum*/ uint VELOCITY = 0x1006;
        public const /*ALenum*/ uint LOOPING = 0x1007;
        public const /*ALenum*/ uint BUFFER = 0x1009;
        public const /*ALenum*/ uint GAIN = 0x100A;
        public const /*ALenum*/ uint MIN_GAIN = 0x100D;
        public const /*ALenum*/ uint MAX_GAIN = 0x100E;
        public const /*ALenum*/ uint ORIENTATION = 0x100F;
        public const /*ALenum*/ uint SOURCE_STATE = 0x1010;
        public const /*ALenum*/ uint INITIAL = 0x1011;
        public const /*ALenum*/ uint PLAYING = 0x1012;
        public const /*ALenum*/ uint PAUSED = 0x1013;
        public const /*ALenum*/ uint STOPPED = 0x1014;
        public const /*ALenum*/ uint BUFFERS_QUEUED = 0x1015;
        public const /*ALenum*/ uint BUFFERS_PROCESSED = 0x1016;
        public const /*ALenum*/ uint REFERENCE_DISTANCE = 0x1020;
        public const /*ALenum*/ uint ROLLOFF_FACTOR = 0x1021;
        public const /*ALenum*/ uint CONE_OUTER_GAIN = 0x1022;
        public const /*ALenum*/ uint MAX_DISTANCE = 0x1023;
        public const /*ALenum*/ uint SEC_OFFSET = 0x1024;
        public const /*ALenum*/ uint SAMPLE_OFFSET = 0x1025;
        public const /*ALenum*/ uint BYTE_OFFSET = 0x1026;
        public const /*ALenum*/ uint SOURCE_TYPE = 0x1027;
        public const /*ALenum*/ uint STATIC = 0x1028;
        public const /*ALenum*/ uint STREAMING = 0x1029;
        public const /*ALenum*/ uint UNDETERMINED = 0x1030;
        public const /*ALenum*/ uint FORMAT_MONO8 = 0x1100;
        public const /*ALenum*/ uint FORMAT_MONO16 = 0x1101;
        public const /*ALenum*/ uint FORMAT_STEREO8 = 0x1102;
        public const /*ALenum*/ uint FORMAT_STEREO16 = 0x1103;
        public const /*ALenum*/ uint FREQUENCY = 0x2001;
        public const /*ALenum*/ uint BITS = 0x2002;
        public const /*ALenum*/ uint CHANNELS = 0x2003;
        public const /*ALenum*/ uint SIZE = 0x2004;
        public const /*ALenum*/ uint UNUSED = 0x2010;
        public const /*ALenum*/ uint PENDING = 0x2011;
        public const /*ALenum*/ uint PROCESSED = 0x2012;
        public const /*ALenum*/ uint INVALID_NAME = 0xA001;
        public const /*ALenum*/ uint INVALID_ENUM = 0xA002;
        public const /*ALenum*/ uint INVALID_VALUE = 0xA003;
        public const /*ALenum*/ uint INVALID_OPERATION = 0xA004;
        public const /*ALenum*/ uint OUT_OF_MEMORY = 0xA005;
        public const /*ALenum*/ uint VENDOR = 0xB001;
        public const /*ALenum*/ uint VERSION = 0xB002;
        public const /*ALenum*/ uint RENDERER = 0xB003;
        public const /*ALenum*/ uint EXTENSIONS = 0xB004;
        public const /*ALenum*/ uint DOPPLER_FACTOR = 0xC000;
        public const /*ALenum*/ uint SPEED_OF_SOUND = 0xC003;
        public const /*ALenum*/ uint DISTANCE_MODEL = 0xD000;
        public const /*ALenum*/ uint INVERSE_DISTANCE = 0xD001;
        public const /*ALenum*/ uint INVERSE_DISTANCE_CLAMPED = 0xD002;
        public const /*ALenum*/ uint LINEAR_DISTANCE = 0xD003;
        public const /*ALenum*/ uint LINEAR_DISTANCE_CLAMPED = 0xD004;
        public const /*ALenum*/ uint EXPONENT_DISTANCE = 0xD005;
        public const /*ALenum*/ uint EXPONENT_DISTANCE_CLAMPED = 0xD006;
        public const /*ALenum*/ uint INVALID = uint.MaxValue; // -1.
        

        // BUFFER FUNCTIONS
        
        [DllImport(Lib, EntryPoint = "alGenBuffers")]
        public static extern /*ALvoid*/ void GenBuffers( /*ALsizei*/ uint n, /*ALuint **/ uint[] buffers);

        [DllImport(Lib, EntryPoint = "alDeleteBuffers")]
        public static extern /*ALvoid*/ void DeleteBuffers( /*ALsizei*/ uint n, /*const ALuint **/ uint[] buffers);
        
        [DllImport(Lib, EntryPoint = "alIsBuffer")]
        public static extern /*ALboolean*/ byte IsBuffer( /*ALuint*/ uint buffer);

        [DllImport(Lib, EntryPoint = "alBufferData")]
        public static extern /*ALvoid*/ void BufferData( /*ALuint*/ uint buffer, /*ALenum*/ uint format, /*const ALvoid **/ byte[] data, /*ALsizei*/ uint size, /*ALsizei*/ uint freq);

        [DllImport(Lib, EntryPoint = "alBufferf")]
        public static extern /*ALvoid*/ void Bufferf( /*ALuint*/ uint buffer, /*ALenum*/ uint param, /*ALfloat*/ float value);

        [DllImport(Lib, EntryPoint = "alBuffer3f")]
        public static extern /*ALvoid*/ void Buffer3f( /*ALuint*/ uint buffer, /*ALenum*/ uint param, /*ALfloat*/ float value1, /*ALfloat*/ float value2, /*ALfloat*/ float value3);

        [DllImport(Lib, EntryPoint = "alBufferfv")]
        public static extern /*ALvoid*/ void Bufferfv( /*ALuint*/ uint buffer, /*ALenum*/ uint param, /*const ALfloat **/ float[] values);

        [DllImport(Lib, EntryPoint = "alBufferi")]
        public static extern /*ALvoid*/ void Bufferi( /*ALuint*/ uint buffer, /*ALenum*/ uint param, /*ALint*/ int value);

        [DllImport(Lib, EntryPoint = "alBuffer3i")]
        public static extern /*ALvoid*/ void Buffer3i( /*ALuint*/ uint buffer, /*ALenum*/ uint param, /*ALint*/ int value1, /*ALint*/ int value2, /*ALint*/ int value3);

        [DllImport(Lib, EntryPoint = "alBufferiv")]
        public static extern /*ALvoid*/ void Bufferiv( /*ALuint*/ uint buffer, /*ALenum*/ uint param, /*const ALint **/ int[] values);

        [DllImport(Lib, EntryPoint = "alGetBufferf")]
        public static extern /*ALvoid*/ void GetBufferf( /*ALuint*/ uint buffer, /*ALenum*/ uint param, /*ALfloat **/ float[] value);

        [DllImport(Lib, EntryPoint = "alGetBuffer3f")]
        public static extern /*ALvoid*/ void GetBuffer3f( /*ALuint*/ uint buffer, /*ALenum*/ uint param, /*ALfloat **/ float[] value1, /*ALfloat **/ float[] value2, /*ALfloat **/ float[] value3);

        [DllImport(Lib, EntryPoint = "alGetBufferfv")]
        public static extern /*ALvoid*/ void GetBufferfv( /*ALuint*/ uint buffer, /*ALenum*/ uint param, /*ALfloat **/ float[] values);

        [DllImport(Lib, EntryPoint = "alGetBufferi")]
        public static extern /*ALvoid*/ void GetBufferi( /*ALuint*/ uint buffer, /*ALenum*/ uint param, /*ALint **/ int[] value);

        [DllImport(Lib, EntryPoint = "alGetBuffer3i")]
        public static extern /*ALvoid*/ void GetBuffer3i( /*ALuint*/ uint buffer, /*ALenum*/ uint param, /*ALint **/ int[] value1, /*ALint **/ int[] value2, /*ALint **/ int[] value3);

        [DllImport(Lib, EntryPoint = "alGetBufferiv")]
        public static extern /*ALvoid*/ void GetBufferiv( /*ALuint*/ uint buffer, /*ALenum*/ uint param, /*ALint **/ int[] values);

        
        // SOURCE FUNCTIONS

        [DllImport(Lib, EntryPoint = "alGenSources")]
        public static extern /*ALvoid*/ void GenSources( /*ALsizei*/ uint n, /*ALuint **/ uint[] sources);

        [DllImport(Lib, EntryPoint = "alDeleteSources")]
        public static extern /*ALvoid*/ void DeleteSources( /*ALsizei*/ uint n, /*const ALuint **/ uint[] sources);

        [DllImport(Lib, EntryPoint = "alIsSource")]
        public static extern /*ALboolean*/ byte IsSource( /*ALuint*/ uint source);

        [DllImport(Lib, EntryPoint = "alSourcef")]
        public static extern /*ALvoid*/ void Sourcef( /*ALuint*/ uint source, /*ALenum*/ uint param, /*ALfloat*/ float value);

        [DllImport(Lib, EntryPoint = "alSource3f")]
        public static extern /*ALvoid*/ void Source3f( /*ALuint*/ uint source, /*ALenum*/ uint param, /*ALfloat*/ float value1, /*ALfloat*/ float value2, /*ALfloat*/ float value3);

        [DllImport(Lib, EntryPoint = "alSourcefv")]
        public static extern /*ALvoid*/ void Sourcefv( /*ALuint*/ uint source, /*ALenum*/ uint param, /*const ALfloat **/ float[] values);

        [DllImport(Lib, EntryPoint = "alSourcei")]
        public static extern /*ALvoid*/ void Sourcei( /*ALuint*/ uint source, /*ALenum*/ uint param, /*ALint*/ int value);

        [DllImport(Lib, EntryPoint = "alSource3i")]
        public static extern /*ALvoid*/ void Source3i( /*ALuint*/ uint source, /*ALenum*/ uint param, /*ALint*/ int value1, /*ALint*/ int value2, /*ALint*/ int value3);

        [DllImport(Lib, EntryPoint = "alSourceiv")]
        public static extern /*ALvoid*/ void Sourceiv( /*ALuint*/ uint source, /*ALenum*/ uint param, /*const ALint **/ int[] values);

        [DllImport(Lib, EntryPoint = "alGetSourcef")]
        public static extern /*ALvoid*/ void GetSourcef( /*ALuint*/ uint source, /*ALenum*/ uint param, /*ALfloat **/ float[] value);

        [DllImport(Lib, EntryPoint = "alGetSource3f")]
        public static extern /*ALvoid*/ void GetSource3f( /*ALuint*/ uint source, /*ALenum*/ uint param, /*ALfloat **/ float[] value1, /*ALfloat **/ float[] value2, /*ALfloat **/ float[] value3);

        [DllImport(Lib, EntryPoint = "alGetSourcefv")]
        public static extern /*ALvoid*/ void GetSourcefv( /*ALuint*/ uint source, /*ALenum*/ uint param, /*ALfloat **/ float[] values);

        [DllImport(Lib, EntryPoint = "alGetSourcei")]
        public static extern /*ALvoid*/ void GetSourcei( /*ALuint*/ uint source, /*ALenum*/ uint param, /*ALint **/ int[] value);

        [DllImport(Lib, EntryPoint = "alGetSource3i")]
        public static extern /*ALvoid*/ void GetSource3i( /*ALuint*/ uint source, /*ALenum*/ uint param, /*ALint **/ int[] value1, /*ALint **/ int[] value2, /*ALint **/ int[] value3);

        [DllImport(Lib, EntryPoint = "alGetSourceiv")]
        public static extern /*ALvoid*/ void GetSourceiv( /*ALuint*/ uint source, /*ALenum*/ uint param, /*ALint **/ int[] values);

        [DllImport(Lib, EntryPoint = "alSourcePlay")]
        public static extern /*ALvoid*/ void SourcePlay( /*ALuint*/ uint source);
        
        [DllImport(Lib, EntryPoint = "alSourcePlayv")]
        public static extern /*ALvoid*/ void SourcePlayv( /*ALsizei*/ uint n, /*const ALuint **/ uint[] sources);
        
        [DllImport(Lib, EntryPoint = "alSourcePause")]
        public static extern /*ALvoid*/ void SourcePause( /*ALuint*/ uint source);
        
        [DllImport(Lib, EntryPoint = "alSourcePausev")]
        public static extern /*ALvoid*/ void SourcePausev( /*ALsizei*/ uint n, /*const ALuint **/ uint[] sources);
        
        [DllImport(Lib, EntryPoint = "alSourceStop")]
        public static extern /*ALvoid*/ void SourceStop( /*ALuint*/ uint source);

        [DllImport(Lib, EntryPoint = "alSourceStopv")]
        public static extern /*ALvoid*/ void SourceStopv( /*ALsizei*/ uint n, /*const ALuint **/ uint[] sources);
        
        [DllImport(Lib, EntryPoint = "alSourceRewind")]
        public static extern /*ALvoid*/ void SourceRewind( /*ALuint*/ uint source);

        [DllImport(Lib, EntryPoint = "alSourceRewindv")]
        public static extern /*ALvoid*/ void SourceRewindv( /*ALsizei*/ uint n, /*const ALuint **/ uint[] sources);
        
        [DllImport(Lib, EntryPoint = "alSourceQueueBuffers")]
        public static extern /*ALvoid*/ void SourceQueueBuffers( /*ALuint*/ uint source, /*ALsizei*/ uint nb, /*const ALuint **/ uint[] buffers);

        [DllImport(Lib, EntryPoint = "alSourceUnqueueBuffers")]
        public static extern /*ALvoid*/ void SourceUnqueueBuffers( /*ALuint*/ uint source, /*ALsizei*/ uint nb, /*ALuint **/ uint[] buffers);
        
        
        // LISTENER FUNCTIONS
        
        [DllImport(Lib, EntryPoint = "alListenerf")]
        public static extern /*ALvoid*/ void Listenerf( /*ALenum*/ uint param, /*ALfloat*/ float value);

        [DllImport(Lib, EntryPoint = "alListener3f")]
        public static extern /*ALvoid*/ void Listener3f( /*ALenum*/ uint param, /*ALfloat*/ float value1, /*ALfloat*/ float value2, /*ALfloat*/ float value3);

        [DllImport(Lib, EntryPoint = "alListenerfv")]
        public static extern /*ALvoid*/ void Listenerfv( /*ALenum*/ uint param, /*const ALfloat **/ float[] values);

        [DllImport(Lib, EntryPoint = "alListeneri")]
        public static extern /*ALvoid*/ void Listeneri( /*ALenum*/ uint param, /*ALint*/ int value);

        [DllImport(Lib, EntryPoint = "alListener3i")]
        public static extern /*ALvoid*/ void Listener3i( /*ALenum*/ uint param, /*ALint*/ int value1, /*ALint*/ int value2, /*ALint*/ int value3);

        [DllImport(Lib, EntryPoint = "alListeneriv")]
        public static extern /*ALvoid*/ void Listeneriv( /*ALenum*/ uint param, /*const ALint **/ int[] values);

        [DllImport(Lib, EntryPoint = "alGetListenerf")]
        public static extern /*ALvoid*/ void GetListenerf( /*ALenum*/ uint param, /*ALfloat **/ float[] value);

        [DllImport(Lib, EntryPoint = "alGetListener3f")]
        public static extern /*ALvoid*/ void GetListener3f( /*ALenum*/ uint param, /*ALfloat **/ float[] value1, /*ALfloat **/ float[] value2, /*ALfloat **/ float[] value3);

        [DllImport(Lib, EntryPoint = "alGetListenerfv")]
        public static extern /*ALvoid*/ void GetListenerfv( /*ALenum*/ uint param, /*ALfloat **/ float[] values);

        [DllImport(Lib, EntryPoint = "alGetListeneri")]
        public static extern /*ALvoid*/ void GetListeneri( /*ALenum*/ uint param, /*ALint **/ int[] value);

        [DllImport(Lib, EntryPoint = "alGetListener3i")]
        public static extern /*ALvoid*/ void GetListener3i( /*ALenum*/ uint param, /*ALint **/ int[] value1, /*ALint **/ int[] value2, /*ALint **/ int[] value3);

        [DllImport(Lib, EntryPoint = "alGetListeneriv")]
        public static extern /*ALvoid*/ void GetListeneriv( /*ALenum*/ uint param, /*ALint **/ int[] values);
        
        
        // STATE FUNCTIONS
        
        [DllImport(Lib, EntryPoint = "alEnable")]
        public static extern /*ALvoid*/ void Enable( /*ALenum*/ uint capability);

        [DllImport(Lib, EntryPoint = "alDisable")]
        public static extern /*ALvoid*/ void Disable( /*ALenum*/ uint capability);

        [DllImport(Lib, EntryPoint = "alIsEnabled")]
        public static extern /*ALboolean*/ byte IsEnabled( /*ALenum*/ uint capability);

        [DllImport(Lib, EntryPoint = "alGetBoolean")]
        public static extern /*ALboolean*/ byte GetBoolean( /*ALenum*/ uint param);
        
        [DllImport(Lib, EntryPoint = "alGetDouble")]
        public static extern /*ALdouble*/ double GetDouble( /*ALenum*/ uint param);
        
        [DllImport(Lib, EntryPoint = "alGetFloat")]
        public static extern /*ALfloat*/ float GetFloat( /*ALenum*/ uint param);

        [DllImport(Lib, EntryPoint = "alGetInteger")]
        public static extern /*ALint*/ int GetInteger( /*ALenum*/ uint param);
        
        [DllImport(Lib, EntryPoint = "alGetBooleanv")]
        public static extern /*ALvoid*/ void GetBooleanv( /*ALenum*/ uint param, /*ALboolean **/ bool[] values);

        [DllImport(Lib, EntryPoint = "alGetDoublev")]
        public static extern /*ALvoid*/ void GetDoublev( /*ALenum*/ uint param, /*ALdouble **/ double[] values);
        
        [DllImport(Lib, EntryPoint = "alGetFloatv")]
        public static extern /*ALvoid*/ void GetFloatv( /*ALenum*/ uint param, /*ALfloat **/ float[] values);
        
        [DllImport(Lib, EntryPoint = "alGetIntegerv")]
        public static extern /*ALvoid*/ void GetIntegerv( /*ALenum*/ uint param, /*ALint **/ int[] values);
        
        [DllImport(Lib, EntryPoint = "alGetString")]
        public static extern /*const ALchar **/ string GetString( /*ALenum*/ uint param);

        [DllImport(Lib, EntryPoint = "alDistanceModel")]
        public static extern /*ALvoid*/ void DistanceModel( /*ALenum*/ uint distanceModel);

        [DllImport(Lib, EntryPoint = "alDopplerFactor")]
        public static extern /*ALvoid*/ void DopplerFactor( /*ALfloat*/ float value);
        
        [DllImport(Lib, EntryPoint = "alSpeedOfSound")]
        public static extern /*ALvoid*/ void SpeedOfSound( /*ALfloat*/ float value);
        
        
        // ERROR FUNCTIONS
        
        [DllImport(Lib, EntryPoint = "alGetError")]
        public static extern /*ALenum*/ uint GetError( /*void*/);
        
        
        // EXTENSION FUNCTIONS
        
        [DllImport(Lib, EntryPoint = "alIsExtensionPresent")]
        public static extern /*ALboolean*/ byte IsExtensionPresent( /*const ALchar **/ string extname);

        [DllImport(Lib, EntryPoint = "alGetProcAddress")]
        public static extern /*void**/ IntPtr GetProcAddress( /*const ALchar **/ string fname);

        [DllImport(Lib, EntryPoint = "alGetEnumValue")]
        public static extern /*ALenum*/ uint GetEnumValue( /*const ALchar **/ string ename);
        
    }
}
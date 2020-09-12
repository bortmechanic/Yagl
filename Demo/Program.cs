/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

namespace Yagl.Demo
{
    internal static class Program
    {
        private static void Main()
        {
            Utils.NativeLibResolver.Configure(typeof(GLFW.Glfw).Assembly, "glfw", "glfw3.dll", "libglfw.so.3", "libglfw.3.dylib");
            Utils.NativeLibResolver.Configure(typeof(Audio.AL).Assembly, "OpenAL", "OpenAL32.dll", "libopenal.so", "/System/Library/Frameworks/OpenAL.framework/OpenAL");
            using var game = new TestGame();
            game.Run();
        }
    }
}
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
            Windowing.NativeLibLoader.NetCore3.LibLoader.Init();
            using var game = new TestGame();
            game.Run();
        }
    }
}
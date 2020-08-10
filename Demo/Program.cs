using System;
using Yagl.Windowing;

namespace Demo
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("YAGL library demo project.");

            Console.Write("Initializing native library resolver... ");
            NativeLibraryResolver.Initialize();
            Console.WriteLine("OK");
            
            Console.Write("Creating Window... ");
            using var window = new Window();
            window.Title = "YAGL Demo Project";
            window.Width = 800;
            window.Height = 600;
            window.Top = 50;
            window.Left = 100;
            Console.WriteLine("OK");
            
            Console.WriteLine("Running the program.");
            window.Run();
            
            Console.WriteLine("The program has completed. Exiting...");
        }
    }
}
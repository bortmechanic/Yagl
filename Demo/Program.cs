using System;
using Yagl.Windowing;

namespace Demo
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Yagl library demo project.");

            Console.Write("Initializing native library resolver... ");
            NativeLibraryResolver.Initialize();
            Console.WriteLine("OK");
            
            Console.Write("Creating Window... ");
            using var window = new Window();
            Console.WriteLine("OK");
            
            Console.WriteLine("Running the program.");
            window.Run();
            
            Console.WriteLine("The program has completed. Exiting...");
        }
    }
}
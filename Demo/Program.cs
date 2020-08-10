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
            window.ClientWidth = 800;
            window.ClientHeight = 600;
            window.Top = 50;
            window.Left = 100;
            window.ResizeMode = ResizeMode.Resizable;
            window.Activate();
            window.Activated += (sender, e) => 
                Console.WriteLine($"Window \"{window.Title}\" Activated."); 
            window.DeActivated += (sender, e) => 
                Console.WriteLine($"Window \"{window.Title}\" DeActivated.");
            window.SizeChanged += (sender, e) =>
                Console.WriteLine($"Window resized. Size: {e.Width}x{e.Height}px, Client: {e.ClientWidth}x{e.ClientHeight}px.");
            window.RePaint += (sender, e) =>
                Console.WriteLine($"Window repaint.");
                Console.WriteLine("OK");
            
            Console.WriteLine("Running the program.");
            window.Run();
            
            Console.WriteLine("The program has completed. Exiting...");
        }
    }
}
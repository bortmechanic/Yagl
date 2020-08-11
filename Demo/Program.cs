using System;
using Yagl.Windowing;

namespace Yagl.Demo
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("YAGL library demo project.");

            Console.Write("Initializing native library resolver... ");
            Windowing.NativeLibLoader.NetCore3.LibLoader.Init();
            Console.WriteLine("OK");
            
            Console.Write("Creating Window... ");
            using var window = new Window
            {
                Title = "YAGL Demo Project",
                Decorations = Decorations.Default,
                ClientWidth = 800,
                ClientHeight = 600,
                Top = 50,
                Left = 100,
                ResizeMode = ResizeMode.Resizable
            };
            window.Activate();
            window.Activated += (sender, e) => 
                Console.WriteLine($"Window \"{(sender as Window)?.Title}\" Activated."); 
            window.DeActivated += (sender, e) => 
                Console.WriteLine($"Window \"{(sender as Window)?.Title}\" DeActivated.");
            window.SizeChanged += (sender, e) =>
                Console.WriteLine($"Window resized. Size: {e.Width}x{e.Height}px, Client: {e.ClientWidth}x{e.ClientHeight}px.");
            window.RePaint += (sender, e) =>
                Console.WriteLine("Window repaint.");
            window.Closing += (sender, e) =>
                Console.WriteLine("Window is about to Close.");
            window.Closed += (sender, e) =>
                Console.WriteLine("Window is Closed.");

            Console.WriteLine("OK");
            
            Console.WriteLine("Running the program.");
            window.Run();

            Console.WriteLine("The program has completed. Exiting...");
        }
    }
}
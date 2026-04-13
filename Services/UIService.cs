using System;
using System.IO;

namespace CyberSecurityBot.Services
{
    public class UIService
    {
        public void ShowBanner()
        {
            try
            {
                string path = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "Assets",
                    "ascii-art.txt"
                );

                if (File.Exists(path))
                {
                    string ascii = File.ReadAllText(path);

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(ascii);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("ASCII art file not found!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading ASCII art: " + ex.Message);
            }
        }
    }
}
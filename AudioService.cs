using System;
using System.IO;
using System.Media;

namespace CyberSecurityBot.Services
{
    public class AudioService
    {
        public void PlayGreeting()
        {
            try
            {
                string path = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "Assets",
                    "welcome.wav"
                );

                Console.WriteLine("Loading audio...");

                if (!File.Exists(path))
                {
                    Console.WriteLine("Audio file not found at: " + path);
                    return;
                }

                SoundPlayer player = new SoundPlayer(path);
                player.PlaySync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Audio error: " + ex.Message);
            }
        }
    }
}
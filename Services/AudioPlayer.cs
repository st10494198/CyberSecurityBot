using System;
using System.Media;

namespace CyberSecurityBot.Services
{
    public class AudioPlayer
    {
        public void PlayGreeting()
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "Assets\\welcome.wav";

                Console.WriteLine("Loading audio...");

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
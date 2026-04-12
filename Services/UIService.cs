using System;

namespace CyberSecurityBot.Services
{
    public class UIService
    {
        public void ShowBanner()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("==================================");
            Console.WriteLine(" CYBERSECURITY AWARENESS BOT");
            Console.WriteLine("==================================");
            Console.WriteLine(" Stay safe online 🔐");
            Console.WriteLine("==================================");

            Console.ResetColor();
        }
    }
}
using CyberSecurityBot.Models;
using CyberSecurityBot.Services;

class Program
{
    static void Main(string[] args)
    {
        AudioService audio = new AudioService();
        UIService ui = new UIService();
        ChatService chat = new ChatService();

        UserProfile user = new UserProfile();

        // Voice greeting
        audio.PlayGreeting();

        // Banner
        ui.ShowBanner();

        // Get user name
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n===============================");
        Console.WriteLine(" Welcome to Cyber Guard 🔐");
        Console.WriteLine("===============================\n");
        Console.ResetColor();

        Console.Write("Enter your name: ");
        user.Name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(user.Name))
        {
            user.Name = "User";
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nWelcome {user.Name}! 👋");
        Console.WriteLine("You can ask me about:");
        Console.WriteLine("- Password safety");
        Console.WriteLine("- Phishing");
        Console.WriteLine("- Safe browsing");
        Console.ResetColor();

        Console.WriteLine("\nType 'exit' to quit.\n");

        // Chat loop
        while (true)
        {
            Console.Write($"{user.Name}: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Bot: Please type something so I can help you.");
                continue;
            }

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Bot: Goodbye! Stay safe online.");
                break;
            }

            string response = chat.GetResponse(input);
            Console.WriteLine("Bot: " + response);
        }
    }
}


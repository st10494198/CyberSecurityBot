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
        Console.Write("Enter your name: ");
        user.Name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(user.Name))
        {
            user.Name = "User";
        }

        Console.WriteLine($"\nWelcome {user.Name}! Ask me anything about cybersecurity.\n");

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


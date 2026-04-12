namespace CyberSecurityBot.Services
{
    public class ChatService
    {
        public string GetResponse(string input)
        {
            input = input.ToLower();

            if (input.Contains("password"))
                return "Use strong passwords with numbers and symbols.";

            if (input.Contains("phishing"))
                return "Be careful of fake emails asking for personal info.";

            if (input.Contains("purpose"))
                return "I help you learn cybersecurity safety.";

            if (input.Contains("safe browsing"))
                return "Avoid clicking unknown links.";

            return "I didn't understand that. Try asking about passwords or phishing.";
        }
    }
}
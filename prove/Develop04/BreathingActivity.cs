using System.Data.SqlTypes;

public class BreathingActivity: Activity
{
    private List<string> _breathingMessages = new List<string>()
    {
        "\nBreathe in...",
        "\nNow Breathe out..."
    };

    public BreathingActivity( string startingMessage, string description) : base(startingMessage, description)
    {
    }

    public void DisplayBreathingMessages()
    {
        for (int i= int.Parse(_duration)/2/4; i > 0; i --)
        {
            foreach (string message in _breathingMessages) 
            {
                Console.Write($"{message}");
                
                for (int countdown= 4; countdown > 0; countdown --)
                {
                    Console.Write(countdown);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
            }
        }
    }
}
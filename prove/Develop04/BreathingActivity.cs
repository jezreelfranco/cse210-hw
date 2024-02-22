using System.Data.SqlTypes;

public class BreathingActivity: Activity
{
    private List<string> _breathingMessages = new List<string>()
    {
        "Breathe in...",
        "Breathe out..."
    };

    public BreathingActivity(string startingMessage, string description, string duration) : base(startingMessage, description, duration)
    {
    }

    public bool DisplayBreathingMessages()
    {
        foreach (string message in _breathingMessages)
        {
            Console.WriteLine(message);
            Thread.Sleep(Convert.ToInt32(_duration + 000));
        }
        return true;
    }
}
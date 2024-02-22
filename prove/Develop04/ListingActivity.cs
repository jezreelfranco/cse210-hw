public class ListingActivity: Activity
{
    private List<string> _prompts = new List<string>(){
        "Who are the people that you appreciate? ",
        "What are personal strengths of yours? ",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month? ",
        "Who are some of your personal heroes? "
    };
    public ListingActivity(string startingMessage, string description, string duration) : base(startingMessage, description, duration)
    {
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();

        foreach(string prompt in _prompts)
        {
            int index = random.Next(_prompts.Count);
            Console.WriteLine(prompt[index]);
        }
    }
}
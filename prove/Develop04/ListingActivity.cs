public class ListingActivity: Activity
{
    private string _randomPrompt;
    private List<string> _prompts = new List<string>(){
        "Who are the people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _total = new List<string>();

    private List<string> _itemList = new List<string>{};
    public ListingActivity(string startingMessage, string description) : base(startingMessage, description)
    {
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count());
        _randomPrompt = _prompts[index];
        Console.WriteLine("\nList as many responses as you can to the following prompt: ");
        Console.WriteLine($"\n--- {_randomPrompt} ---\n");
        GetBeginningCountdown();
        Console.WriteLine(" ");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(int.Parse(_duration));

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            _total.Add(response);
            
            Thread.Sleep(_pause);
            _itemList.Add(response);

            i ++;

            if (i >=  int.Parse(_duration))
            {
                i = 0;
            }
        }
        
    }

    public void GetItemList()
    {
        // Console.WriteLine($"\nYour responses to '{_randomPrompt}': ");

        // foreach (string item in _itemList)
        // {
        //     Console.WriteLine(item);
        // }

        Console.WriteLine($"You listed {_total.Count()} items! ");
    }
}
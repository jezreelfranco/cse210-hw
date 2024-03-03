public class ReflectionActivity: Activity
{
    private List<string> _prompts = new List<string> 
    {
        "Think of a time when you stood up for someone. ",
        "Think of a time when you did something really difficult. ",
        "Think of a time when you helped someone in need. ",
        "Think of a time when you did something truly selfless. "
    };

    private List<string> _questions = new List<string> 
    {
        "Why was this experience meaningful to you? ",
        "Have you ever done anything like this before? ",
        "How did you get started? ",
        "How did you feel when it was complete? ",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience? ", 
        "What could you learn from this experience that applies to other situtations? ",
        "What did you learn about yourself through this experience? ",
        "How can you keep this experience in mind in the future? "
    };

    public ReflectionActivity(string startingMessage, string description) : base(startingMessage, description)
    {
    }

    public void GetRandomPrompt()
    {
        // Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count());
        Console.WriteLine($"--- {_prompts[promptIndex]} ---");
    }

    public void GetReflectionQuestions()
    {
        Console.WriteLine("\nWhen you have something in mind, press enter to continue. ");
        string input = Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they relate to your experience. ");
        Console.WriteLine(GetBeginningCountdown());
        Console.Clear();

        // for (int i = int.Parse(_duration); i > 0; i--)
        // {
        //     Console.Write("You may begin in:", i); //need to add countdown 
        //     Console.Write(GetBeginningCountdown());
        //     Thread.Sleep(500);
        //     Console.WriteLine("\b \b");
        // }

        Random random = new Random ();
        int questionIndex = random.Next(_questions.Count());
        int questionIndex2 = random.Next(_questions.Count());
      
            Console.Write($"\n{_questions[questionIndex]}");
            GetSpinningAnimtionforReflection();

            Console.Write($"\n{_questions[questionIndex2]}");  //need to put the countdown here too
            GetSpinningAnimtionforReflection();
    }

}
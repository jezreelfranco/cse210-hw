public class FiveSensesActivity : Activity
{
    private string _listen;
    private string _look = " "; 
    private string _smell;
    private string _touch;
    private string _feeling;

    private List<string> _responses = new List<string> ();

    public FiveSensesActivity (string startingMessage, string description) : base(startingMessage, description)
    {
    }

    public string GetListen()
    {
        Console.WriteLine(" ");
        Console.Write("\nTake a few seconds and listen to your surroundings. . . ");
        for (int countdown = int.Parse(_duration)/4 ; countdown > 0; countdown --)
            {
                Console.Write(countdown);
                Thread.Sleep(1000);
                Console.Write("\b \b");
             }

        Console.WriteLine("\nName one thing that you can hear when you listen with your ears: ");
        _listen = Console.ReadLine();
        _responses.Add(_listen);
        return _listen;
    }

    public string GetLook()
    {
        Console.WriteLine(" ");
        Console.Write("Very good! \nNow take a look at your surroundings. . .");
        for (int countdown = int.Parse(_duration)/4 ; countdown > 0; countdown --)
            {
                Console.Write(countdown);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

        Console.WriteLine("\nName one thing that catches you attention when you look around: ");
        _look = Console.ReadLine();
        _responses.Add(_look);
        return _look;
    }

    public string GetTouch()
    {
        Console.WriteLine(" ");
        Console.Write("\nAlmost done! \nNow reach out and touch something . . .");
        
        for (int countdown = int.Parse(_duration)/4 ; countdown > 0; countdown --)
            {
                Console.Write(countdown);
                Thread.Sleep(1000);
                Console.Write("\b \b");
             }

        Console.WriteLine("\nName one thing you touched: ");
        _touch = Console.ReadLine();
        _responses.Add(_touch);
        return _touch;
    }

    public string GetSmell()
    {
        Console.WriteLine(" ");
        Console.Write("\nNicely done! \nNow take a deep breath. . . ");
        for (int countdown = int.Parse(_duration)/4 ; countdown > 0; countdown --)
            {
                Console.Write(countdown);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

        Console.WriteLine("\nName one scent you smelled: ");
        _smell = Console.ReadLine();
        _responses.Add(_smell);
        return _smell;
    }

    public string GetFeeling()
    {
        Console.WriteLine(" ");
        Console.Write("\nLast one! \nNow take a a moment and reflect on how you're feeling. . .");
        for (int countdown = int.Parse(_duration)/4 ; countdown > 0; countdown --)
            {
                Console.Write(countdown);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

        Console.WriteLine("\nList how you are feeling: ");
        _feeling = Console.ReadLine();
        _responses.Add(_feeling);
        return _feeling;
    }

    public void GetFiveSenses()
    {
        Console.WriteLine($"\nYour responses to each five senses prompt:");

        foreach (string response in _responses)
        {
            Console.WriteLine(response);
        }
    }

}

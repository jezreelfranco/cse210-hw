using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

public class Activity
{
    protected string _name = " ";
    protected string _staringMessage = " ";
    protected string _description = " ";
    protected string _duration;

    protected List<string> pausingAnimation = new List<string>(){
        "|",
        "/",
        "-",
        "\\",
        "|",
        "/",
        "-",
        "\\",
    
    };
    protected int _pause; 
    // private string _finishingMessage = "\nWell Done!";

    public Activity(string startingMessage, string description) // int duration)
    {
        _staringMessage = startingMessage;
        _description = description;
       // _duration = duration;
    }

    public string GetActivityName()
    {
        return _name;
    }
    
    public void SetActivityName(string name)
    {
        _name = name;
    }

    public string GetStartingMessage()
    {
        // Console.Clear();
        return _staringMessage;
    }
    public string GetDecription()
    {
        return _description;
    }

    public void GetSpinningAnimation()
    {
        foreach(string s in pausingAnimation)
        {
            Console.Write (s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void GetSpinningAnimtionforReflection()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(int.Parse(_duration)/2);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = pausingAnimation[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i ++;

            if (i >= pausingAnimation.Count)
            {
                i = 0;
            }
        }
    }

    public void GetDuration()
    {
        Console.WriteLine("How long, in seconds, would you like this session to last? ");
        _duration  = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Get ready ...");
    }

    public void GetPauseTime()
    {
        _pause = int.Parse(_duration);

        if (_pause > 0 && _pause < 10)
        {
            _pause = int.Parse(_duration) * 1000;
        }
        if(_pause >= 10 && _pause < 90)
        {
            _pause = int.Parse(_duration) * 100;
        }
        if(_pause >= 100)
        {
            _pause = int.Parse(_duration) * 10;
        }

        Console.WriteLine(_pause);
    }

    public void SetPause(int pause)
    {
        _pause = pause;
    }
    public string GetBeginningCountdown()
    {
        Console.Write("You may begin in: ");

        for (int i= 5; i > 0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        return "";
    }
    public void GetFinishingMessage()
    {
        Console.WriteLine("\nWell Done!!\n");
        GetSpinningAnimation();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}. \n");
        GetSpinningAnimation();
        Console.Clear();
    }
}

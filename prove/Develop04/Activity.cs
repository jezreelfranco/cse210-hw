using System.Runtime.InteropServices.Marshalling;

public class Activity
{
    protected string _staringMessage = " ";
    protected string _description = " ";
    protected string _duration;
    private string _finishingMessage = " ";

    public Activity(string startingMessage, string description, string duration)
    {
        _staringMessage = startingMessage;
        _description = description;
        _duration = duration;
    }

    public string GetStartingMessage()
    {
        return _staringMessage;
    }
    public string GetDecription()
    {
        return _description;
    }

    public int GetPause()
    {
        Console.WriteLine("How long, in seconds, would you like this session? ");
        string _duration = Console.ReadLine();
        return Convert.ToInt32(_duration);
    }
    public string GetFinishingMessage()
    {
        return _finishingMessage;
    }
}

using System.Reflection.Metadata.Ecma335;

public  class Goal
{
    protected List<string> _goals = new List<string>();
    protected List<string> _description = new List<string> ();
    protected int _points = 0;
    protected bool _isComplete = false;

    public virtual void GetGoals()
    {   
        Console.WriteLine("What is the name of your goal? ");
        string goal = Console.ReadLine();
        _goals.Add(goal);

        Console.WriteLine("What is a short description of it? ");
        string description = Console.ReadLine();
        _description.Add(description);

        Console.WriteLine("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }

    public virtual void GetTotalPoints()
    {
        Console.WriteLine("You have " + _points + " points.\n");
    }

    public virtual void DisplayGoals()
    {
        foreach (string goal in _goals)
        {
            Console.Write($"\n[ ] " + Convert.ToString(goal));
        }
            foreach (string description in _description)
            {
                Console.Write(" (" + Convert.ToString(description )+ ")\n");
            }
    }

    public virtual bool IsComplete()
    {
        return _isComplete;
    }
}
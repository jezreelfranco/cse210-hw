public  class Goal
{
    protected List<string> _goals = new List<string>();
    protected string _description;
    protected int _points = 0;

    public virtual void GetGoals()
    {
        Console.WriteLine("What is the name of your goal? ");
        string goal = Console.ReadLine();
        _goals.Add(goal);

        Console.WriteLine("What is a short description of it? ");
        _description = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }

    public virtual int GetTotalPoints()
    {
        return _points = 0;
        // return "\n You have" + _points + "points.\n";
    }

    public virtual void DisplayGoals()
    {
        Console.WriteLine("The goals are: ");
        
        foreach (string goal in _goals)
        {
            Console.WriteLine(goal);
        }
    }
}
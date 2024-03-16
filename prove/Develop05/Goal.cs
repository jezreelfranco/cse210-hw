using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Goal
{
    protected List<string> _goals = new List<string> ();
    protected List<string> _description = new List<string> ();
    protected int _points = 0;
    protected bool _isComplete = false;

    public Goal ()
    {
    }

    public virtual string GetGoal ()
    {
        return Convert.ToString(_goals);
    }

    public virtual string GetDescription()
    {
        return Convert.ToString(_description);
    }

    public virtual void SetGoals()
    {   
        Console.WriteLine("What is the name of your goal? ");
        string goals = Console.ReadLine();
        _goals.Add(goals);
    }

    public virtual void SetDescription()
    {
        Console.WriteLine("What is a short description of it? ");
        string description = Console.ReadLine();
        _description.Add(description);
    }

    public virtual void SetPoints()
    {
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
                Console.Write(" (" + Convert.ToString(description)+ ")\n");
            }
    }

    public virtual void SaveToFile()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName, true))                      // "using" statements makes sure it automatically closes the file, runs code only within {}
        {
            // for (int i= 0; i < _goals.Count; i ++)
            // {
                foreach (string goal in _goals)
                {
                    outputFile.Write($"\n[ ] " + Convert.ToString(goal));
                }
                    foreach (string description in _description)
                    {
                        outputFile.Write(" (" + Convert.ToString(description)+ ")\n");
                    }
           // }
        }
    }

    public void LoadFile()
    {      
        Console.WriteLine("What is the filename?");                                        //have to recall and ask the user for filename
        string findFileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(findFileName);                        //creates list of line from saved entry file
        
        foreach (string line in lines)                                                     // iterates through each line                 
        {
            Console.WriteLine(line);                                                       //displays each entry line
        }
    }

    public virtual bool IsComplete()
    {
        while (false)
        {
        }
        return _isComplete;
    }
}
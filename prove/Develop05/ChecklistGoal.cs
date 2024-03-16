public class ChecklistGoal : Goal
{
    private int _frequency;
    private int _bonus;

    public ChecklistGoal()
    {
        // _frequency = frequency;
        // _bonus = bonus;
    }
    public override void SetPoints()
    {
        Console.WriteLine("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        _frequency = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"What is the bonus for accomplishing it {_frequency} times? ");
        _bonus = Convert.ToInt32(Console.ReadLine());
    }

    public override void DisplayGoals()
    {   

        foreach (string goal in _goals)
        {
            Console.Write($"\n[ ] " + Convert.ToString(goal));
        }
            foreach (string description in _description)
            {
                Console.Write(" (" + Convert.ToString(description)+ ") -- Currently completed 0/" + _frequency + "\n");
            }
        // return Convert.ToString(_goals + Convert.ToString(_description));
    }
    public override void SaveToFile()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

         Console.WriteLine("The goals are: \n");

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
                        outputFile.Write(" (" + Convert.ToString(description)+ ") -- Currently completed 0/" + _frequency + "\n");
                    }
           // }
        }
    }
}


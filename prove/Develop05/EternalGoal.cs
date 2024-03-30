using System.Diagnostics;

public class EternalGoal: Goal
{   
    public EternalGoal ()
    {
    }

    public override int CalculatePoints()
    {
        int total = CalculatePoints() + _points;
        return total;
    }

    public override void GetCompletedPoints()
    {
        Goal goals = new Goal();
        EternalGoal eternalGoal = new EternalGoal();

        int goalOne = goals.GetPoints();
        int goalTwo = eternalGoal.GetPoints();

        Console.WriteLine("one: "  + goalOne);
        int total = goalOne + goalTwo;

        Console.WriteLine("this is the value for totatl " +total);
        
        Console.WriteLine("Congraduations! You have earned " + total + "points!\n"); 
    
    }
}
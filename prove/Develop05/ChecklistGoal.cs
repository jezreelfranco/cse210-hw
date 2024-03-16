public class ChecklistGoal : Goal
{
    private int _frequency;
    private int _bonus;

    public override void GetGoals()
    {
        base.GetGoals();
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        _frequency = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"What is the bonus for accomplishing it {_frequency} times? ");
        _bonus = Convert.ToInt32(Console.ReadLine());
    }
}


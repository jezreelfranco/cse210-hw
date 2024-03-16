using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Goal goals = new Goal();
        ChecklistGoal checklistGoal = new ChecklistGoal();
    
        while (true)
        {

            goals.GetTotalPoints();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goals");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.WriteLine("Select a choice from the menu: ");
            string userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    Console.WriteLine("The types of Goals are: ");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");

                    string goalPicked = Console.ReadLine();

                        if (goalPicked == "1")
                        {
                            goals.GetGoals();
                            goals.GetTotalPoints();
                        }
                        if (goalPicked == "2")
                        {
                            goals.GetGoals();
                            goals.GetTotalPoints();
                        }
                        if (goalPicked == "3")
                        {
                            checklistGoal.GetGoals();
                            goals.GetTotalPoints();
                        }
                }
                if (userChoice == "2")
                {
                    // List<Goal> goalsList = new List<Goal>();
                    // goalsList.Add(new Goal());
                    // goalsList.Add(new EternalGoal());
                    // goalsList.Add(new ChecklistGoal());

                    // Console.WriteLine("The goals are: ");

                    // foreach (Goal goal in goalsList)
                    // {
                    //     string singlegoal = goal.DisplayGoals();
                    //     Console.WriteLine(singlegoal);
                    // }
                    goals.DisplayGoals();

                }
                if (userChoice == "3")
                {
                }
                if (userChoice == "4")
                {
                }
                if (userChoice == "5")
                {
                }
                if (userChoice == "6")
                    break;
        }
    }
} 
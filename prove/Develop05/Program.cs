using System;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Goal goals = new Goal();
        EternalGoal eternalGoal = new EternalGoal();
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
                            goals.SetGoals();
                            goals.SetDescription();
                            goals.SetPoints();
                            goals.GetTotalPoints();
                        }
                        if (goalPicked == "2")
                        {
                            eternalGoal.SetGoals();
                            eternalGoal.SetDescription();
                            eternalGoal.SetPoints();
                            goals.GetTotalPoints();
                        }
                        if (goalPicked == "3")
                        {
                            checklistGoal.SetGoals();
                            checklistGoal.SetDescription();
                            checklistGoal.SetPoints();
                            goals.GetTotalPoints();
                        }
                }
                if (userChoice == "2")
                {
                    goals.DisplayGoals();
                    eternalGoal.DisplayGoals();
                    checklistGoal.DisplayGoals();
                }
                if (userChoice == "3")
                {
                    goals.SaveToFile();
                    eternalGoal.SaveToFile();
                    checklistGoal.SaveToFile();
                }
                if (userChoice == "4")
                {
                    Console.WriteLine("The goals are: \n");
                    goals.LoadFile();
                }
                if (userChoice == "5")
                {
                }
                if (userChoice == "6")
                    break;
        }
    }
} 
using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Menu Options:");
        // Console.WriteLine("1. Create New Goals");
        // Console.WriteLine("2. Save Goals");
        // Console.WriteLine("3. Save Goals");
        // Console.WriteLine("4. Load Goals");
        // Console.WriteLine("5. Record Event");
        // Console.WriteLine("6. Quit");

        // Console.WriteLine("Select a choice from the menu: ");
        // string userChoice = Console.ReadLine();

        Goal goals = new Goal();
        

        while (true)// (userChoice != "5")
        {
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
                            goals.GetGoals();
                            goals.GetTotalPoints();
                        }
                }
                else if (userChoice == "2")
                {
                    goals.GetGoals();
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
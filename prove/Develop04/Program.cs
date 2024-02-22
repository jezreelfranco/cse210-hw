using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Welcome to the Breathing Activity \n", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. \n", "How long, in seconds, would you like for your session? ");
                Console.WriteLine(breathingActivity.GetStartingMessage());
                Console.WriteLine(breathingActivity.GetDecription());
                Console.WriteLine(breathingActivity.GetFinishingMessage());
                Console.WriteLine(breathingActivity.GetPause());
                Console.WriteLine(breathingActivity.DisplayBreathingMessages());
            }
            else if (choice == "2")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity("Welcome to the Reflection Activity \n", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. \n","How long, in seconds, would you like for your session? ");
                Console.WriteLine(reflectionActivity.GetStartingMessage());
                Console.WriteLine(reflectionActivity.GetDecription());
                Console.WriteLine(reflectionActivity.GetFinishingMessage());
                Console.WriteLine(reflectionActivity.GetPause());
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity("Welcome to the Listing Activity!\n ","This activity will help you reflect on the good things in you rlife by having you list as many things as you can in a certain time. \n", "How long, in seconds, would you like for your session? ");
                Console.WriteLine(listingActivity.GetStartingMessage());
                Console.WriteLine(listingActivity.GetDecription());
                Console.WriteLine(listingActivity.GetPause());
            }
            else if (choice == "4")
            {
                break;
            }
        }
    }
}



using System;
using System.Dynamic;
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
            Console.WriteLine("4. Five Senses Activity");
            Console.WriteLine("5 Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            Console.Clear();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Welcome to the Breathing Activity \n", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. \n");
                Console.WriteLine(breathingActivity.GetStartingMessage());
                Console.WriteLine(breathingActivity.GetDecription());
                breathingActivity.GetDuration();
                breathingActivity.GetSpinningAnimation();
                breathingActivity.DisplayBreathingMessages();
                breathingActivity.SetActivityName("Breathing Activity");
                breathingActivity.GetSpinningAnimation();
                breathingActivity.GetFinishingMessage();
            }

            else if (choice == "2")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity("Welcome to the Reflection Activity \n", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. \n");
                Console.WriteLine(reflectionActivity.GetStartingMessage());
                Console.WriteLine(reflectionActivity.GetDecription());
                reflectionActivity.GetDuration();
                reflectionActivity.GetSpinningAnimation();
                reflectionActivity.GetRandomPrompt();
                reflectionActivity.GetReflectionQuestions();
                reflectionActivity.SetActivityName("Reflection Activity");
                reflectionActivity.GetFinishingMessage();
            }

            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity("Welcome to the Listing Activity!\n ","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain time. \n");
                Console.WriteLine(listingActivity.GetStartingMessage());
                Console.WriteLine(listingActivity.GetDecription());
                listingActivity.GetDuration();
                listingActivity.GetSpinningAnimation();
                listingActivity.GetRandomPrompt();
                listingActivity.GetItemList();
                listingActivity.SetActivityName("Listing Activity");
                listingActivity.GetFinishingMessage();
            }
            else if (choice =="4")
            {
                FiveSensesActivity fiveSensesActivity = new FiveSensesActivity("Welcome to the Five Senses Activity!\n", "This activity will help you clear your mind and unwind as you focus on listening, looking, smelling, touching, and feeling. \n ");
                Console.WriteLine(fiveSensesActivity.GetStartingMessage());
                Console.WriteLine(fiveSensesActivity.GetDecription());
                Console.WriteLine(fiveSensesActivity.GetStartingMessage());
                fiveSensesActivity.GetDuration();
                fiveSensesActivity.GetSpinningAnimation();
                fiveSensesActivity.GetBeginningCountdown();
                fiveSensesActivity.GetListen();
                fiveSensesActivity.GetLook();
                fiveSensesActivity.GetTouch();
                fiveSensesActivity.GetSmell();
                fiveSensesActivity.GetFeeling();
                fiveSensesActivity.GetFiveSenses();
                fiveSensesActivity.SetActivityName("Five Senses Activity");
                fiveSensesActivity.GetFinishingMessage();
                // fiveSensesActivity.GetSpinningAnimation();
                // fiveSensesActivity.GetFinishingMessage();
            }
            else if (choice == "5")
            {
                break;
            }
        }
    }
}
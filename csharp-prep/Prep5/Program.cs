using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

/// ASSIGNMENT 5
/// displays welcome message
        // void DisplayMessage()
        // {
        //     Console.WriteLine("Welcome to the program!");
        // }
/// NEED TO CALL "DISPLAYMESSAGE();" TO DISPLAY THE MESSAGE
        // DisplayMessage();

/// prompts user's name
        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();

// prompts user's favorite number
        Console.WriteLine("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int favorite_number = int.Parse(input);

// Square number
        int favNumberSquared = (favorite_number*favorite_number);

/// Display result
        void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
            Console.WriteLine($"{userName}, the square of your number is {favNumberSquared}");
        }
        DisplayMessage();
    }
}
// 
using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
         // string concatanaiton 
            // Console.WriteLine("Your name is" + lastName + ", " + firstName + lastName);
            // ctrl + / = comments out highlighted area
        
        // in ternmina - "cd ... " -> dotnet run
            }
}
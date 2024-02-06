using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction first = new Fraction();                 // fill in paramters according number or parameters in each class constructor
        Console.WriteLine(first.GetFractionString());

        Fraction second = new Fraction ();               // add in values to the class parameters
        second.SetNumerator(1);                          //first set variable to a value 
        Console.WriteLine(second.GetNumerator());        //second, display using "Console.WriteLine" followed by "get" method
        
        Fraction third = new Fraction (5);
        third.SetNumerator(5);
        third.SetDenominator(1);
        Console.WriteLine(third.GetFractionString());    // Console.WriteLine(third.GetNumerator());
        Console.WriteLine(third.GetDecimalValue());      // Console.WriteLine(third.GetDenominator());                           

        Fraction fourth = new Fraction (3, 4);
        {
        fourth.SetNumerator(3);
        fourth.SetDenominator(4);
        Console.WriteLine(fourth.GetFractionString());
        Console.WriteLine(fourth.GetDecimalValue());
        }

        Fraction fifth = new Fraction (1, 3);
        {
        fifth.SetNumerator(1);
        fifth.SetDenominator(3);
        Console.WriteLine(fifth.GetFractionString());
        Console.WriteLine(fifth.GetDecimalValue());
        }
    }
}
// MUST refer to the library at the top
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

    // PART 1 REQUIREMENT
        List<int> numbers = new List<int>();

        int userNumber = -1;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        while (userNumber!= 0)
        
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
            string givenNumber = Console.ReadLine();
            userNumber = int.Parse(givenNumber);

            // adding numbers to the list
            numbers.Add(userNumber);
        }

        // CORE REQURIEMENT 1: SUM
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum} ");

        // CORE REQUIREMENT 2: AVERAGE
        int average = sum / numbers.Count + 1;
        Console.WriteLine(average);

        // CORE REQUIREMENT 3: MAXIMUM
       int maximum = numbers[0];
       foreach (int number in numbers)
       {
        if (number > maximum)
        {
            maximum = number;
        }
       }

        Console.WriteLine($"The largest number is: {maximum}");
        
        // double average = sum / numbers.Count;
        // Console.WriteLine($"The average is: {average}");

        // CORE REQUIREMENT 2: AVERAGE
        // float avg = ((int)(sum)) / numbers.Count;
        // Console.Write($"The average is {avg}: ");

        // // CORE REQUIREMENT 3: MAX

        // numbers.Sort();
        // var max = numbers [1];

        // Console.WriteLine($"The mac is: {max}" );

    }
        
}
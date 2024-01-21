using System;
using System.Globalization;

Console.WriteLine("Hello Prep3 World!");

// ask the user for the magic number
Console.WriteLine("What is the magic number? ");
string input = Console.ReadLine();
int magicNumber = int.Parse(input);

// PART 1 & 2 ask user for their guess
// Console.WriteLine("What is your guess? ");
// string input2 = Console.ReadLine();
// int userGuess = int.Parse(input2);

// PART 3: Random Number Generator
Random randomGenerator = new Random();
int magicNumberGenerated = randomGenerator.Next(1, 101);

int guess = -1;

// PART TWO: looping through
// HIGHER than actual number
 while (guess != magicNumberGenerated)
{
    // ask user for their guess
    Console.WriteLine("What is your guess? ");
    guess = int.Parse(Console.ReadLine());
        
    if (guess > magicNumberGenerated)
    {
        Console.WriteLine("Lower");

    }
 //LOWER      
    else if (guess < magicNumberGenerated)
    {
        Console.WriteLine("Higher");
    }
    else
    {
        Console.WriteLine("You guessed it right!");
    }

     }

    // PART ONE: HIGHER than actual number:
        //if (userGuess > magicNumber)
//         {
//             Console.WriteLine("Lower");

//             Console.WriteLine("What is your guess?");
//             string guess2 = Console.ReadLine();
//             int.Parse(guess2);
//         }
//     // PART ONE: LOWER than magic number
//         else if (userGuess < magicNumber)
//         {
//             Console.WriteLine("Higher");
//         }
//     // PART ONE: guess right!
//         else
//         {
//             Console.WriteLine("You guessed it right! ");
//         }
//     }
// }
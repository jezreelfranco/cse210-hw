using System;
using System.Reflection.Metadata.Ecma335;
// Exceeding requirement
// ADDED user input for mood within entry class


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string userChoice = "1";

        Console.WriteLine("Welcome to the journal program!");

        while (userChoice != "5")
        {
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
    
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    PromptGenerator _prompt = new PromptGenerator();
                    string prompt = _prompt.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    
                    Entry entry = new Entry();
                    entry.DisplayMoods();
                
                    
                    entry._prompt = prompt;                       
                    entry._response = response;
                    entry._dateTime = DateTime.Now;;
                    // entry._mood = mood; //added mood

                    journal._entries.Add(entry);  
                    // journal._entries.Add(_mood);  //added mood
                                                  // calling "journal" list from above, ".entries" accesses entry list above, then "Adds" the list of (entries)
                    break;
                case"2": //display
                    foreach(Entry userEntry in journal._entries)                                        // for each(Class classNickname in nameOfList)
                    {
                        Console.WriteLine($"{userEntry._dateTime} - {userEntry._prompt}");
                        Console.WriteLine($"{userEntry._response}");
                        Console.WriteLine($"Mood Today: {userEntry._rate}");
                        Console.WriteLine("");
                    }
                    break;
                case "3": //load
                    Console.WriteLine("What is the filename?");                                        //have to recall and ask the user for filename
                    string findFilename = Console.ReadLine();
                    
                    string[] lines = System.IO.File.ReadAllLines(findFilename);                        //creates list of line from saved entry file
                    foreach (string line in lines)                                                     // iterates through each line                 
                    {
                        Console.WriteLine(line);                                                       //displays each entry line
                    }
                    break;
                case "4": //save
                    Console.WriteLine("What is the filename?");
                    string filename = Console.ReadLine(); 

                     using (StreamWriter outputFile = new StreamWriter(filename))                      // "using" statements makes sure it automatically closes the file, runs code only within {}
                    {
                        foreach(Entry userEntry in journal._entries)                                   // iterate through the list of entries from case "2"
                        {
                                outputFile.WriteLine($"{userEntry._dateTime} - {userEntry._prompt}");  //use "outputFile" to refer to class 
                                outputFile.WriteLine($"{userEntry._response}");
                                outputFile.WriteLine($"Mood Today: {userEntry._rate}");
                                outputFile.WriteLine("");
                        }
                    }
                    break;
                case "5":
                    Console.WriteLine("Quit");
                    break;
                default:
                    Console.WriteLine("Please enter a number beteen 1 and 5. ");
                    break;
            }
        }
     }
}





// List<string> prompts = new List<string>();

                    // prompts.Add("What was the best part of my day?");
                    // prompts.Add("How were my prayers answered today?");
                    // prompts.Add("How did I serve someone today?");
                    // prompts.Add("What made me laugh today?");
                    // prompts.Add("What am I grateful for today?");

                    // Random randomprompt = new Random();
                    // int prompt = randomprompt.Next(prompts.Count);
                    
                    // Console.WriteLine($"{prompts[prompt]}");

                    // List<string> responses = new List<string>(); //need a new list to save responses, does this need to be here or in the second
                    // string _response =Console.ReadLine();
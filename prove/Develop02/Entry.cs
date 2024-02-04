using System;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _prompt;
    public DateTime _dateTime;
    public string _response;

    public int _mood;
    public string _rate = "";

    // public List<PromptGenerator> _prompts = new List<PromptGenerator>();

    public Entry()
    {

    }


    public void DisplayMoods()                   //instance of the promptgenerator class
        {
            Console.WriteLine("How are you feeling today?\n 1. Awful \n 2. Meh \n 3. Just Fine \n 4. Good \n 5. Great!");
            _mood = int.Parse(Console.ReadLine());
            if(_mood == 1)
            {
                _rate = "Awful";
            }
            else if(_mood == 2)
            {
                _rate = "Meh";
            }
            else if(_mood == 3)
            {
                _rate = "Just Fine";
            }
            else if(_mood == 4)
            {
                _rate = "Good";
            }
            else if(_mood == 5)
            {
                _rate = "Great!";
            }
            else
            {
                Console.WriteLine("not valid");
            }
        }
    // public static void SaveToFile(List<Entry> entries)
    //  {
    //       Console.WriteLine("What is the filename? "); //retrieves user input
    //       string filename = Console.ReadLine();        //saves user's filename into variable

    //       using (StreamWriter outputFile = new StreamWriter(filename)) // "using" statements makes sure it automatically closes the file, runs code only within {}
    //       {
    //            foreach(Entry entry in entries) // iterate through the list of entries
    //            {
    //                 outputFile.WriteLine();
    //            }
    //       }

    //  }
    
    // public void DisplayEntry()
    // {
    //     foreach (PromptGenerator prompt in _prompts) //trying for each loop
    //     {
    //         Console.WriteLine($"{_dateTime} - {_prompts}");
    //         Console.WriteLine($"{_response}");
    //         // prompt.DisplayPrompt();
    //         // Console.WriteLine($"{_dateTime}-{prompt.DisplayPrompt}");
    //     }

    //     Console.WriteLine($"{_dateTime} - {_prompts}");
    //     Console.WriteLine($"{_response}");
}

using System;

public class PromptGenerator
{
    public string[] _prompts = new string[]
    {
        "What was the best part of my day?",
        "How were my prayers answered today?",
        "How did I serve someone today?",
        "What made me laugh today?",
        "What am I grateful for today?"
    };

    public string GetRandomPrompt()                   //instance of the promptgenerator class
    {
        Random random = new Random();    
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }

}
    // public string _prompts = "";   //create variable
    // public string _response = ""; //added this for testing purposes
    
//     public PromptGenerator()
//     {
//     }

//     public void DisplayPrompt()
//     {
//         Console.WriteLine($"{_prompts}"); //display the random prompts for the user
//         // testing purposes = Console.WriteLine($"{_response}");
//     }
// }
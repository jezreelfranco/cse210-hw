using System;
using System.Net.Quic;
using System.Runtime.InteropServices.Marshalling;

class Program
{ 
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        scripture.Reference_and_word();

        Console.WriteLine("\n Press Enter to continue or type 'quit' to finish: ");
        string user_input =Console.ReadLine();

            while (user_input != "quit")
            {
                // Console.Clear();
                Console.WriteLine("\n Press Enter to continue or type 'quit' to finish: ");
                string input =Console.ReadLine();

                scripture.HideWords();

                if (input == "quit")
                {
                    break;
                }
            }
    }
        
}
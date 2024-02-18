using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> _words1 = new List<string> { "This", "is", "a", "sentence" };
        List<string> _blanks = new List<string> { "_____", "__", "_", "________" };

        Random random = new Random();

        for (int i = 0; i < _blanks.Count; i++)
        {
        int randomIndex = random.Next(0, _blanks.Count);
        string randomBlank = _blanks[randomIndex];

        int wordIndex = randomIndex; 

        _words1.RemoveAt(randomIndex);
        _words1.Insert(wordIndex, randomBlank);
        }

        string combined_text_and_blanks = string.Join(" ", _words1);
        Console.WriteLine(combined_text_and_blanks);
        
    }
}



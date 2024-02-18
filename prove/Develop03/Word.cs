using System.Dynamic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

public class Word
{
    private List<string> _words1 = new List<string>(){
        "For", "God", "so", "loved", "the", "world", ",", "that", "he",
        "gave", "his", "only", "begotten", "Son", ",", "that", "whosoever", 
        "believeth", "in", "him", "should", "not", "perish", ",", "but", 
        "have", "everlasting", "life"};

    private List<string> _blanks = new List<string>(){
        "___", "___", "__", "_____", "___", "_____", "_", "____", "__",
        "____", "___", "____", "________", "___", "_", "____", "_________",
        "_________", "__", "___", "______", "___", "______", "_", "___", 
        "____", "____________", "____"
    };
    
    public Word()
    {
    }

    public Word(List<string> words)
    {
        _words1 = words;
    }

    public void GetWordsShown()
    {
        string combined_text = String.Join( " ", _words1.ToArray());
        Console.WriteLine (combined_text);
    }

    public void GetHiddenWord()
    {
        Random random = new Random();
    
        // Console.WriteLine("\n Press Enter to continue or type 'quit' to finish: ");
        // string input =Console.ReadLine();

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

    public void ShowText()
    {
        string combined_text_and_blanks = String.Join(" ", _words1.ToArray());
        Console.WriteLine(combined_text_and_blanks);
    }

    public string GetIsHidden()
    {
        string combined_blanks = String.Join(" ", _blanks.ToArray());
        Console.WriteLine(combined_blanks);

        return "";
    }
}
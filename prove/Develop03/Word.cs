public class Word
{
    private List<string> _words1 = new List<string>(){
        "For", "God", "so", "loved", "the", "world", ",", "that", "he",
        "gave", "his", "only", "begotten", "Son", ",", "that", "whosoever", 
        "believeth", "in", "him", "should", "not", "perish", ",", "but", 
        "have", "everlasting", "life"};

    private List<string> _blanks1 = new List<string>(){
        "___", "___", "__", "_____", "___", "_____", "_", "____", "__",
        "____", "___", "____", "________", "___", "_", "____", "_________",
        "_________", "__", "___", "______", "___", "______", "_", "___", 
        "____", "____________", "____"
    };

    private List<string> _words2 = new List<string>(){
        "Trust", "in", "the", "Lord", "with", "all", "thine", "heart", "_", 
        "lean", "not", "unto", "thine", "own", "understanding", ".", "In", 
        "all", "thy", "ways", "acknowledge", "him", "_", "and", "he", "will",
        "direct", "thy", "paths"};
    
    
    public Word()
    {
    }

    public Word(List<string> words)
    {
        _words1 = words;
    }

    public void GetWordsShown1() 
    {
        string combined_text = String.Join( " ", _words1.ToArray());
        Console.WriteLine (combined_text);
    }

    public void GetHiddenWord1()
    {
       Random random = new Random();

        while(true)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to finish: ");
            string input =Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            int randomIndex = random.Next(0, _blanks1.Count);
            string randomBlank = _blanks1[randomIndex];

            int wordIndex = randomIndex; 

            _words1.RemoveAt(randomIndex);
            _words1.Insert(wordIndex, randomBlank);
            
            Console.Clear();

            string combined_text_and_blanks = string.Join(" ", _words1);
            Console.WriteLine($"John 3:16: " + combined_text_and_blanks);  

            // _blanks.RemoveAt(randomIndex);
        }
    }

    public void ShowText1()
    {
        string combined_text_and_blanks = String.Join(" ", _words1.ToArray());
        Console.WriteLine(combined_text_and_blanks);
    }

    public string GetIsHidden1()
    {
        string combined_blanks = String.Join(" ", _blanks1.ToArray());
        Console.WriteLine(combined_blanks);

        return "";
    }

public void GetWordsShown2()
    {
        string combined_text = String.Join( " ", _words2.ToArray());
        Console.WriteLine (combined_text);
    }
}
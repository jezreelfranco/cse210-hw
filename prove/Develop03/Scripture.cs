public class Scripture
{
    // public Scripture(string reference, string word);
    Reference reference1 = new Reference("John", "3", "16");
    Word word1 = new Word();

    // Reference reference2 = new Reference("Proverbs", "3", "5", "6");
    // Console.WriteLine(reference2.GetMultipleReference());
        
    public void Reference_and_word()
    {
        Console.WriteLine(reference1.GetSingleReference());
        word1.GetWordsShown1();
    }

    public void Is_Completely_Hidden()
    {
        Console.WriteLine(reference1.GetSingleReference());
        // word1.GetIsHidden();
    }

    public void HideWords()
    {
        Console.WriteLine(reference1.GetSingleReference());
        word1.GetHiddenWord1();        
    }
}
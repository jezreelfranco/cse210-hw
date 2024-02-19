public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetSingleReference()
    {
        string text = $"{_book} {_chapter}: {_verse}";
        return text;
    }

    public string GetMultipleReference()
    {
        string text = $"{_book} {_chapter}: {_verse}-{_endVerse}";
        return text;
    }
}
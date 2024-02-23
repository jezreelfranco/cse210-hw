public class WritingAssignment: Assignment
{
    private string _title = " ";

    public string GetWritingInfo() 
    {
        return $"{_title} by {_name}";
    }

    public void SetGetWritingInfo(string title, string name)
    {
        _title = title;
        _name = name;
    }
}

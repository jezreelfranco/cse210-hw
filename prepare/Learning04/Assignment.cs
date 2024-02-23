using System.Dynamic;
public class Assignment
{
    protected string _name = "";
    private string _topic = " ";

    public string GetSummary()
    {
        return $"{_name} - {_topic}";
    }

    public void SetSummary(string name, string topic)
    {
        _name = name;
        _topic = topic;
    }
}
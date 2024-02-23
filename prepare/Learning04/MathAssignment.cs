using System.Globalization;
public class MathAssignment: Assignment
{
    private string _section = " ";
    private string _problems = " ";

    // public MathAssignment(string name, string topic, string section, string problems):base()
    // {
    //     _section = section;
    //     _problems = problems;
    // }
    public string GetHomeworkList() 
    {
        return $"{_section} - {_problems}";
    }

    public void SetHomeworkList(string section, string problems)
    {
        _section = section;
        _problems = problems;
    }
}

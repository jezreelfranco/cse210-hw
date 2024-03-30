public class EntertainmentExpense: Expense
{
    List<string> _entertainment = new List<string> ();

    public void GetEntertainmentType()
    {
        Console.WriteLine("What kind of entertainment did you do? (ex: bowling): ");
        string entertainment= Console.ReadLine();
        _entertainment.Add(entertainment);
    }
}
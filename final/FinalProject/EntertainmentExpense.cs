public class EntertainmentExpense: Expense
{
    private string _entertainment;

    public void GetEntertainmentType()
    {
        Console.WriteLine("What kind of entertainment did you do? (ex: bowling): ");
        _entertainment= Console.ReadLine();
    }

    public string ReturnEntertainmentType ()
    {
        return _entertainment;
    }

    public override void SaveExpenses()
    {
        Console.WriteLine("What is the filename you would like to save your expenses to? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            outputFile.WriteLine($"Type of expense: " + _typeOfExpense );
            outputFile.WriteLine("Date: " + _date);
            outputFile.WriteLine("Location: " + _location + "\n");
            
            outputFile.WriteLine("Type of Entertainment:" + _entertainment );

            outputFile.WriteLine($"\nAmount spent: {_amount}\n");
        }
        
        Console.WriteLine("Your expenses have been saved to " + _fileName);
    }
}


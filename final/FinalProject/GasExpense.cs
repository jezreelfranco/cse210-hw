public class GasExpense: Expense
{
    private double _gallons;

    public void GetGallons()
    {
        Console.WriteLine("\nHow many gallons did you get? ");
        _gallons = Convert.ToDouble(Console.ReadLine());
    }

    public double ReturnGallons()
    {
        return _gallons;
    }

    public override void SaveExpenses()
    {
         Console.WriteLine("What is the filename you would like to save your expenses to? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"Type of expense: " + _typeOfExpense );
            outputFile.WriteLine("Date: " + _date);
            outputFile.WriteLine("Location: " + _location + "\n");
            
            outputFile.WriteLine("Gallons: " + _gallons);
            outputFile.WriteLine("The items your purchased at " + _location + "is: ");

            outputFile.WriteLine($"\nAmount spent: {_amount}\n");
        }
        
        Console.WriteLine("Your expenses have been saved to " + fileName);
    }
}

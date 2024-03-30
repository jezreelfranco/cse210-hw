public class GasExpense: Expense
{
    private double _gallons;

    public void GetGallons()
    {
        Console.WriteLine("\nHow many gallons did you get? ");
        _gallons = Convert.ToDouble(Console.ReadLine());
    }
}

using System.Runtime.CompilerServices;

public class Expense
{
    private double _monthlyBudget = 0;
    private string _date;
    private string _location;
    private string _typeOfExpense;

    private List<string> _items = new List<string> ();
    private double _amount = 0;

    public Expense()
    {
    }

    public void SetMonthlyBudget ()
    {
        Console.WriteLine("\nPlease enter this month's monthly budget: ");
        _monthlyBudget = Convert.ToDouble(Console.ReadLine());
    }

     public void ExpenseType()
    {
        Console.WriteLine("Select a category below that best fits this expense: ");
        Console.WriteLine("1. Groceries");
        Console.WriteLine("2. Resturant");
        Console.WriteLine("3. Household");
        Console.WriteLine("4. Gas");
        Console.WriteLine("5. Entertainment");
        Console.WriteLine("6. Apparrel");
        Console.WriteLine("7. Personal");

        string input = Console.ReadLine();

        if (input == "1")
        {
            _typeOfExpense = "Groceries";
        }
        if (input == "2")
        {
            _typeOfExpense = "Resturant";
        }
        if (input == "3")
        {
            _typeOfExpense = "Household";
        }
        if (input == "4")
        {
            _typeOfExpense = "Gas";
        }
        if (input == "5")
        {
            _typeOfExpense = "Entertainment";
        }
        if (input == "6")
        {
            _typeOfExpense = "Apparal";
        }
        if (input == "7")
        {
            _typeOfExpense = "Personal";
        }
    }

    public string GetExpenseType()
    {
        return _typeOfExpense;
    }

    public void SetDate()
    {
        Console.WriteLine("\nEnter the date of the expense?: ");
        _date = Console.ReadLine();
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetLocation()
    {
        Console.WriteLine("\nWhere did you purchase from? ");
        _location = Console.ReadLine();
    }

    public string GetLocation()
    {
        return _location;
    }

    public void SetItems()
    { 
        while (true)
        {
            Console.WriteLine($"\nList the {_typeOfExpense} items you bought and type 'done' when you are finished: ");
            string userInput = Console.ReadLine();

            if (userInput != "done")
            {
                _items.Add(userInput);
            }
            if (userInput == "done")
                break;
        }
    }

    public void Amount()
    {
        Console.WriteLine($"\nWhat was the total amount you spent at {_location}? ");
        _amount = Convert.ToDouble(Console.ReadLine());
    }

    public double CalcualteAmount()
    {
        return _amount;
    }

    public void DisplayItemsAndTotal()
    {
        Console.WriteLine($"\nThe items you bought at {_location} is: ");
        
        foreach (string item in _items)
        {
            Console.WriteLine(item);
        }
    }

    public void GetItems()
    {

        Console.WriteLine($"At {_location} you bought: ");
        foreach (string item in _items)
        {
            Console.WriteLine(item);
        }
    }

    public void SaveExpenses()
    {
        Console.WriteLine("What is the filename you would like to save your expenses to? ");
        string fileName = Console.ReadLine();

        // Expense expense = new Expense();
        // List<Expense> items = new List<Expense>();
        // items.Add(new GroceryExpense());
        // items.Add(new ResturantExpense());
        // items.Add(new HouseholdExpense());
        // items.Add(new GasExpense());
        // items.Add(new EntertainmentExpense());
        // items.Add(new AppararlExpense());
        // items.Add(new PersonalExpense());

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
        //     foreach (Expense item in items)
        //     {
        //         string userItem = expense.DisplayItems();
        //         Console.WriteLine(userItem);
        //     }
            outputFile.WriteLine($"Type of expense ", _typeOfExpense );
            outputFile.WriteLine(_date);
            outputFile.WriteLine(_location);
            outputFile.WriteLine(_items);
        }
    }

    public void LoadFile()
    {
    }

    public double DisplayRemainingBalance ()
    {
        return 0;
    }

}
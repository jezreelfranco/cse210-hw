using System.Runtime.CompilerServices;

public class Expense
{
    private double _monthlyBudget = 0;
    protected string _date;
    protected string _location;
    protected string _typeOfExpense;

    protected List<string> _items = new List<string> ();
    protected double _amount = 0;

    protected string _fileName; 


    public Expense()
    {
    }

    public void SetMonthlyBudget ()
    {
        Console.WriteLine("\nPlease enter this month's monthly budget: ");
        _monthlyBudget = Convert.ToDouble(Console.ReadLine());
    }

    public double ReturnMonthlyBUudget()
    {
        return _monthlyBudget;
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

    public void ReturnItems()
    {
        Console.WriteLine($"{_location} | {_date}");
        foreach(string item in _items)
            {
            Console.WriteLine(item);
            }
        Console.WriteLine($"{_amount}");
    }

    public double DisplayMonthlyExpenses ()
    {
        return _amount;
    }

    public void SetAmount()
    {
        Console.WriteLine("How much money did you spend at " + _location + " ?");
        _amount = Convert.ToDouble(Console.ReadLine());
    }
    public double Amount()
    {
        return _amount;
    }

    public virtual void SaveExpenses()
    {
        Console.WriteLine("What is the filename you would like to save your expenses to? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"Type of expense: " + _typeOfExpense );
            outputFile.WriteLine("Date: " + _date);
            outputFile.WriteLine("Location: " + _location + "\n");
            
            outputFile.WriteLine("The items your purchased at " + _location + "is: ");
            
            foreach(string item in _items)
                {
                outputFile.WriteLine(item);
                }

            outputFile.WriteLine($"\nAmount Spent: {_amount}\n");
        }
        
        Console.WriteLine("Your expenses have been saved to " + fileName);
    }

        public void SetFileName()
        {
            Console.WriteLine("What is the filename you would like to save your expenses to? ");
            _fileName = Console.ReadLine();
        }

        public string GetFileName()
        {
            return _fileName;
        }
        // public virtual void SaveExpenses(string fileName)
        // {
        //     using (StreamWriter outputFile = new StreamWriter(fileName, true))
        //         {
        //             outputFile.WriteLine($"Type of expense: {_typeOfExpense}");
        //             outputFile.WriteLine($"Date: " + _date);
        //             outputFile.WriteLine("Location: " + _location + "\n");

        //             foreach (string item in _items)
        //             {
        //                 outputFile.WriteLine(item);
        //             }

        //             outputFile.WriteLine($"\nAmount Spent: " + _amount + "\n");
        //         }

        //     Console.WriteLine("Your expenses have been saved to " + fileName + "/n");
        // }

        // this works better, but for some reason teh method variables are not showing up correctly...

    public void LoadFile()
    {
        Console.WriteLine("What is the filename?");                                       
        string findFileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(findFileName);                        
        
        foreach (string line in lines)                                                                    
        {
            Console.WriteLine(line);                                                      
        }
    }
}
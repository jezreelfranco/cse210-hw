using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        Expense expense = new Expense();
        GroceryExpense groceryExpense = new GroceryExpense();
        ResturantExpense resturantExpense = new ResturantExpense();
        HouseholdExpense householdExpense = new HouseholdExpense ();
        GasExpense gasExpense = new GasExpense ();
        EntertainmentExpense entertainmentExpense = new EntertainmentExpense();
        AppararlExpense appararlExpense = new AppararlExpense();
        PersonalExpense personalExpense = new PersonalExpense();

        Console.WriteLine("Welcome to your personal expense tracker! /n");
        expense.SetMonthlyBudget();

        while (true)
        {
            Console.WriteLine("Please choose one of the following options below: /n");
            Console.WriteLine("1. Enter an Expense ");
            Console.WriteLine("2. Display Monthly Expenses "); //include total 
            Console.WriteLine("3. Show Remaning Budget ");
            Console.WriteLine("4. Save Expenses ");
            Console.WriteLine("5. Load Expenses ");
            Console.WriteLine("6. Clear Monthly Expenses ");
            Console.WriteLine("7. Exit ");
            string input = Console.ReadLine();

                if(input == "1")
                {
                    expense.ExpenseType();
                    Console.WriteLine(expense.GetExpenseType());

                        if (expense.GetExpenseType() == "Groceries")
                            {
                                Console.WriteLine("This is a Groceries expense.");
                                groceryExpense.SetDate();
                                groceryExpense.SetLocation();
                                groceryExpense.SetItems();
                                groceryExpense.Amount();
                            }
                        if (expense.GetExpenseType() == "Resturant")
                            {
                                Console.WriteLine("This is a Resturaant expense.");
                                resturantExpense.SetDate();
                                resturantExpense.SetLocation();
                                resturantExpense.SetItems();
                                resturantExpense.Amount();
                            }
                            if (expense.GetExpenseType() == "Household")
                            {
                                Console.WriteLine("This is a Hosusehold expense.");
                                householdExpense.SetDate();
                                householdExpense.SetLocation();
                                householdExpense.SetItems();
                                householdExpense.Amount();
                            }
                            if (expense.GetExpenseType() == "Gas")
                            {
                                Console.WriteLine("This is a Gas expense.");
                                gasExpense.SetDate();
                                gasExpense.SetLocation();
                                gasExpense.SetItems();
                                gasExpense.Amount();
                            }
                            if (expense.GetExpenseType() == "Entertainment")
                            {
                                Console.WriteLine("This is a Entertainment expense.");
                                entertainmentExpense.SetDate();
                                entertainmentExpense.SetLocation();
                                entertainmentExpense.SetItems();
                                entertainmentExpense.Amount();
                            }
                            if (expense.GetExpenseType() == "Apparal")
                            {
                                Console.WriteLine("This is a Apparal expense.");
                                appararlExpense.SetDate();
                                appararlExpense.SetLocation();
                                appararlExpense.SetItems();
                                appararlExpense.Amount();
                            }
                            if (expense.GetExpenseType() == "Personal")
                            {
                                Console.WriteLine("This is a Personal expense.");
                                personalExpense.SetDate();
                                personalExpense.SetLocation();
                                personalExpense.SetItems();
                                personalExpense.Amount();
                            }
                }
                if(input == "2")
                {
                    groceryExpense.GetItems();
                    resturantExpense.GetItems();
                    householdExpense.GetItems();
                    gasExpense.GetItems();
                    entertainmentExpense.GetItems();
                    appararlExpense.GetItems();
                    personalExpense.GetItems();

                    Console.WriteLine("For a total of: " , groceryExpense.CalcualteAmount());
                }
                if(input == "3")
                {
                }
                if(input == "4")
                {
                    expense.SaveExpenses();
                }
                if(input == "5")
                {
                }
                if(input == "6")
                {
                }
                if(input == "7")
                    break;
        }
    }
}
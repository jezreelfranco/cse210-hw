using System;
using System.Data.Common;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.FileIO;

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
            Console.WriteLine("6. Exit ");
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
                                groceryExpense.SetAmount();
                            }
                        if (expense.GetExpenseType() == "Resturant")
                            {
                                Console.WriteLine("This is a Resturaant expense.");
                                resturantExpense.SetDate();
                                resturantExpense.SetLocation();
                                resturantExpense.SetItems();
                                resturantExpense.SetAmount();
                            }
                            if (expense.GetExpenseType() == "Household")
                            {
                                Console.WriteLine("This is a Hosusehold expense.");
                                householdExpense.SetDate();
                                householdExpense.SetLocation();
                                householdExpense.SetItems();
                                householdExpense.SetAmount();
                            }
                            if (expense.GetExpenseType() == "Gas")
                            {
                                Console.WriteLine("This is a Gas expense.");
                                gasExpense.SetDate();
                                gasExpense.SetLocation();
                                gasExpense.GetGallons();
                                gasExpense.SetAmount();
                            }
                            if (expense.GetExpenseType() == "Entertainment")
                            {
                                Console.WriteLine("This is a Entertainment expense.");
                                entertainmentExpense.SetDate();
                                entertainmentExpense.SetLocation();
                                entertainmentExpense.GetEntertainmentType();
                                entertainmentExpense.SetAmount();
                            }
                            if (expense.GetExpenseType() == "Apparal")
                            {
                                Console.WriteLine("This is a Apparal expense.");
                                appararlExpense.SetDate();
                                appararlExpense.SetLocation();
                                appararlExpense.SetItems();
                                appararlExpense.SetAmount();
                            }
                            if (expense.GetExpenseType() == "Personal")
                            {
                                Console.WriteLine("This is a Personal expense.");
                                personalExpense.SetDate();
                                personalExpense.SetLocation();
                                personalExpense.SetItems();
                                personalExpense.SetAmount();
                            }
                }
                if(input == "2")
                {
                    Console.WriteLine(groceryExpense.Amount());
                    Console.WriteLine(resturantExpense.Amount());
                    Console.WriteLine(householdExpense.Amount());
                    Console.WriteLine(gasExpense.Amount());
                }
                if(input == "3")
                {
                    double grExpense = groceryExpense.Amount();
                    double rExpense = resturantExpense.Amount();
                    double hExpense = householdExpense.Amount();
                    double gsExpense = gasExpense.Amount();   
                    double pExpense = personalExpense.Amount();
                    double aExpense = appararlExpense.Amount();
                    double eExpense = entertainmentExpense.Amount();

                    double monthlyBudeget = expense.ReturnMonthlyBUudget();

                    double total = grExpense + rExpense + hExpense + gsExpense + pExpense + aExpense + eExpense;
                    double remainingBudget = monthlyBudeget -total;

                    Console.WriteLine("\nThe total amount you've spent is: " + total );
                    Console.WriteLine("Your remaining balance is: " + remainingBudget + "\n");
                }
                if(input == "4")
                {
                    List<Expense> expenses = new List<Expense>();

                    // expenses.Add(new Expense());
                    // expenses.Add(new GroceryExpense());
                    // expenses.Add(new ResturantExpense());

                    // expense.SetFileName();
                    // expense.GetFileName();
                    expense.SaveExpenses();
                    groceryExpense.SaveExpenses();
                    resturantExpense.SaveExpenses();

 
                }
                if(input == "5")
                {
                    expense.LoadFile();
                }
                if(input == "6 ")
                    break;
        }
    }
}
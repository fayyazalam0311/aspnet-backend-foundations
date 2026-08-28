using ExpenseTracker;
using Microsoft.EntityFrameworkCore;

ExpenseDbContext db = new ExpenseDbContext();


Console.WriteLine("***** Expense Tracker Application *****");

bool running = true ;

while (running)
{
    Console.WriteLine("Select an option:\n1. Press 1 for Add Expense\n2. Press 2 for View All Expenses\n3. Press 3 for View Total\n4. Press 4 for View Expenses by Category\n5. Press 5 for Exit");

    int input = Convert.ToInt32(Console.ReadLine());


    if (input == 1)
    {
        Console.WriteLine("Add Expense");
        Console.WriteLine("\nEnter the Title:");
        string title = Console.ReadLine();
        Console.WriteLine("\nEnter the Amount:");
        decimal amount = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("\nEnter the Category:");
        string category = Console.ReadLine();
        Console.WriteLine($"\nDate: {DateTime.Now}");

        Expense NewExpense = new Expense(0, title, amount, category);
        db.Expenses.Add(NewExpense);
        db.SaveChanges();
        Console.WriteLine("Expense added successfully!\n");
    }
    else if (input == 2)
    {
        foreach (Expense e in db.Expenses.ToList())
        {
            Console.WriteLine($"Title: {e.Title}, Amount: Rs.{e.Amount}/-, Category: {e.Category}, Date: {e.Date}");
        }
    }
    else if (input == 3)
    {
        Console.WriteLine("Total Expenses:");
        decimal total = db.Expenses.Sum(e => e.Amount);
        Console.WriteLine($"Total Amount: Rs.{total}/-");
    }
    else if (input == 4)
    {
        Console.WriteLine("Enter the Category:");
        string CategoryInput = Console.ReadLine();

        List<Expense> CategoryOutput = db.Expenses.Where(e => e.Category.ToLower() == CategoryInput.ToLower()).ToList();
        Console.WriteLine($"Expenses for {CategoryInput}category:");
        foreach (Expense e in CategoryOutput)
        {
            Console.WriteLine($"Title: {e.Title}, Amount: Rs.{e.Amount}/-, Date: {e.Date}");
        }
    }
    else if (input == 5)
    {
        Console.WriteLine("Exiting the application. Goodbye!");
        running = false;
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again.");
    }
}
db.Dispose();
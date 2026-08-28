namespace ExpenseTracker
{
    public class Expense
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public Expense(int id, string title, decimal amount, string category)
        {
            Id = id;
            Title = title;
            Amount = amount;
            Category = category;
            Date = DateTime.Now;
        }
    }
}
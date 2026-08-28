using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker
{
    public class ExpenseDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ExpenseTrackerDb;Trusted_Connection=True;");
        }
    }
}
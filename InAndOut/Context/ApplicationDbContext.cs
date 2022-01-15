using InAndOut.Models;
using Microsoft.EntityFrameworkCore;

namespace InAndOut.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }

        public DbSet<ItemModel> Items { get; set; }
        public DbSet<ExpensesModel> Expenses { get; set; }
        public DbSet<ExpensesCategoriesModel> ExpensesCategories { get; set; }
    }
}

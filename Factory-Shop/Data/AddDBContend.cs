using Factory_Shop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Factory_Shop.Data
{
    public class AddDBContend : DbContext
    {
        public AddDBContend(DbContextOptions<AddDBContend> options) : base(options) 
        {
            Database.EnsureCreated();
        }
        
        public DbSet<Materials> Materials { get; set; } 
        public DbSet<Category> Category { get; set; }
              
    }
}

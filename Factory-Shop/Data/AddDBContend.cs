using Factory_Shop.Data.Models;
using Factory_Shop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Factory_Shop.Data
{
    public class AddDBContend : IdentityDbContext
    {
        public AddDBContend(DbContextOptions<AddDBContend> options) : base(options) 
        {
            //Initializing a new class instance and passing it to the base constructor
        }

        public DbSet<UserDataModel> UserData { get; set; }
        public DbSet<Materials> Materials { get; set; } 
        public DbSet<Category> Category { get; set; }
        //Through this propertis, communication with database tables is carried out

    }
}

﻿using Factory_Shop.Data.Models;
using Factory_Shop.Models;
using Microsoft.EntityFrameworkCore;

namespace Factory_Shop.Data
{
    public class AddDBContend : DbContext
    {
        public AddDBContend(DbContextOptions<AddDBContend> options) : base(options) 
        {
            Database.EnsureCreated();
        }

        public DbSet<UserDataModel> UserData { get; set; }
        public DbSet<Materials> Materials { get; set; } 
        public DbSet<Category> Category { get; set; }
              
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyToDo.Models;

namespace MyToDo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ToDo> ToDos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)        
        => optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");
        
    }
}

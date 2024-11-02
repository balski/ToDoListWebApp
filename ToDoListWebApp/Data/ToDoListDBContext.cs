using Microsoft.EntityFrameworkCore;
using ToDoListWebApp.Models;

namespace ToDoListWebApp.Data
{
    public class ToDoListDBContext : DbContext
    {
        //public ToDoListDBContext(DbContextOptions<ToDoListDBContext> option) : base(option)
        //{
        //}

        public DbSet<Users> Users { get; set; }

        public DbSet<Activities> Activities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=ToDoListDB.db");
    }
}

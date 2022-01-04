using System;
using ApiToDoList.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiToDoList.Tools
{
    public class DataContext : DbContext
    { 
        public DbSet<ToDo> Todos { get; set; }
        public DataContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\coursEF;Integrated Security=True");

            //Pour une utilisation avec mysql
            MySqlServerVersion v = new MySqlServerVersion(new System.Version(10, 4, 19));
            optionsBuilder.UseMySql(@"Server=localhost;Database=m2i;Uid=root;Pwd=;", v);
        }
    }
}

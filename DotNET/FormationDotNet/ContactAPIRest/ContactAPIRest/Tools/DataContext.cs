using System;
using ContactAPIRest.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactAPIRest.Tools
{
    public class DataContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
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

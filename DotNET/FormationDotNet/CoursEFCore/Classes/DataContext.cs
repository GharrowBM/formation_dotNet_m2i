using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursEFCore.Classes
{
    public class DataContext : DbContext
    {
        public DbSet<Personne> Personnes { get; set; }

        public DbSet<Ecole> Ecoles { get; set; }

        public DbSet<Formateur> Formateurs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\coursEF;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

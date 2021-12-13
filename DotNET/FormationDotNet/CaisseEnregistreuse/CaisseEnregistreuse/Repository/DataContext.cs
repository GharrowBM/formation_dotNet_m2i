using CaisseEnregistreuse.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseEnregistreuse.Repository
{
    public class DataContext : DbContext
    {
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Vente> Ventes { get; set; }

        private static DataContext instance = null;
        public DataContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\coursEF;Integrated Security=True");
        }

        public static DataContext Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataContext();
                return instance;
            }
        }
    }
}

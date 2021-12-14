using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendezVous.Classes
{
    public class DataContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        public DbSet<RendezVous> RendezVous { get; set; }

        private static DataContext instance = null;
        public DataContext(): base()
        {

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\coursEF;Integrated Security=True");
        }
    }
}

using CorrectionPetiteAnnonce.Models;
using Microsoft.EntityFrameworkCore;

namespace CorrectionPetiteAnnonce.Tools
{
    public class DataContext : DbContext
    {
        public DbSet<Annonce> Annonces { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\coursEF;Integrated Security=True");
        }
    }
}

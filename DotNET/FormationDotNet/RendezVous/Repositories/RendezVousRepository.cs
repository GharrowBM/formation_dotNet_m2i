using Microsoft.EntityFrameworkCore;
using RendezVous.Classes;
using RendezVous.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendezVous.Repositories
{
    public class RendezVousRepository : IRepository<Classes.RendezVous>
    {
        public IEnumerable<Classes.RendezVous> FindAll()
        {
            return DataContext.Instance.RendezVous.Include(r => r.Patient).ToList();
        }

        public Classes.RendezVous FindById(int id)
        {
            return DataContext.Instance.RendezVous.Include(r => r.Patient).FirstOrDefault(r => r.Id == id);
        }

        public bool Save(Classes.RendezVous element)
        {
            DataContext.Instance.RendezVous.Add(element);
            return DataContext.Instance.SaveChanges() > 0;
        }

        public IEnumerable<Classes.RendezVous> Search(Func<Classes.RendezVous, bool> predicate)
        {
            return DataContext.Instance.RendezVous.Include(r => r.Patient).Where(r => predicate(r)).ToList();
        }

        public bool Update(Classes.RendezVous element)
        {
            return DataContext.Instance.SaveChanges() > 0;

        }
    }
}

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
    public class PatientRepository : IRepository<Patient>
    {
        public IEnumerable<Patient> FindAll()
        {
            return DataContext.Instance.Patients.Include(p => p.RendezVous).ToList();
        }

        public Patient FindById(int id)
        {
            return DataContext.Instance.Patients.Include(p => p.RendezVous).FirstOrDefault(p=> p.Id == id);
        }

        public bool Save(Patient element)
        {
            DataContext.Instance.Patients.Add(element);
            return DataContext.Instance.SaveChanges() > 0;
        }

        public IEnumerable<Patient> Search(Func<Patient, bool> predicate)
        {
            return DataContext.Instance.Patients.Include(p => p.RendezVous).Where(p => predicate(p)).ToList();
        }

        public bool Update(Patient element)
        {
            return DataContext.Instance.SaveChanges() > 0;
        }
    }
}

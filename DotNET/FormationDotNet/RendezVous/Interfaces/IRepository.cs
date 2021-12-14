using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendezVous.Interfaces
{
    public interface IRepository<T>
    {
        bool Save(T element);
        bool Update(T element);
        T FindById(int id);   
        IEnumerable<T> FindAll();
        IEnumerable<T> Search(Func<T, bool> predicate);
    }
}

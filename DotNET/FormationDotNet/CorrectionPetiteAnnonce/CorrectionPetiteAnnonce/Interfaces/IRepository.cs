using System;
using System.Collections.Generic;

namespace CorrectionPetiteAnnonce.Interfaces
{
    public interface IRepository<T> 
    {
        T Get(int id);
        List<T> GetAll();
        T Save(T entity);
        List<T> Search(string search); 
    }
}

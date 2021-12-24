using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CorrectionPetiteAnnonce.Interfaces;
using CorrectionPetiteAnnonce.Models;
using CorrectionPetiteAnnonce.Tools;

namespace CorrectionPetiteAnnonce.Repositories
{
    public class UtilisteurRepository : BaseRepository, IRepository<Utilisateur>
    {
        public UtilisteurRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public Utilisateur Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Utilisateur> GetAll()
        {
            throw new NotImplementedException();
        }

        public Utilisateur Save(Utilisateur entity)
        {
            throw new NotImplementedException();
        }

        public List<Utilisateur> Search(Expression<Func<Utilisateur, bool>> searchMethode)
        {
            throw new NotImplementedException();
        }

        public Utilisateur SearchOne(Expression<Func<Utilisateur, bool>> searchMethode)
        {
            return _dataContext.Utilisateurs.SingleOrDefault(searchMethode);
        }
    }
}

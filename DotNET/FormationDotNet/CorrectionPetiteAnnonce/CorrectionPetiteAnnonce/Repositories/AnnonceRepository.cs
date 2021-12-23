using CorrectionPetiteAnnonce.Interfaces;
using CorrectionPetiteAnnonce.Models;
using CorrectionPetiteAnnonce.Tools;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CorrectionPetiteAnnonce.Repositories
{
    public class AnnonceRepository : BaseRepository, IRepository<Annonce>
    {
        public AnnonceRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public Annonce Get(int id)
        {
            return _dataContext.Annonces.Include(a => a.Images).FirstOrDefault(a => a.Id == id);
        }

        public List<Annonce> GetAll()
        {
            return _dataContext.Annonces.Include(a => a.Images).ToList();
        }

        public Annonce Save(Annonce entity)
        {
            _dataContext.Annonces.Add(entity);
            _dataContext.SaveChanges();
            return entity;
        }

        public List<Annonce> Search(Func<Annonce, bool> searchMethode)
        {
            return _dataContext.Annonces.Include(a => a.Images).Where(a => searchMethode(a)).ToList();
        }
    }
}

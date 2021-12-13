using CaisseEnregistreuse.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseEnregistreuse.Repository
{
    public class ProduitRepository : BaseRepository
    {
        public ProduitRepository(DataContext data) : base(data)
        {
        }

        public bool Save(Produit produit)
        {
            _data.Produits.Add(produit);
            return _data.SaveChanges() > 0;
        }

        public Produit GetProduit(int id)
        {
            return _data.Produits.FirstOrDefault(p => p.Id == id);
        }

        public List<Produit> GetProduits()
        {
            return _data.Produits.ToList();
        }
    }
}

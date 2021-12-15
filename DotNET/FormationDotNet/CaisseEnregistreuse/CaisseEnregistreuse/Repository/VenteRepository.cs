using CaisseEnregistreuse.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseEnregistreuse.Repository
{
    public class VenteRepository : BaseRepository
    {
        public VenteRepository(DataContext data) : base(data)
        {
        }

        public async Task<bool> Save(Vente vente)
        {
            _data.Ventes.Add(vente);
            return await _data.SaveChangesAsync() > 0;
        }

        public List<Vente> GetVentes()
        {
            return _data.Ventes.ToList();
        }
    }
}

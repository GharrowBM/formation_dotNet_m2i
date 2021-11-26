using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionTPHotel.Classes
{
    internal class Chambre
    {
        private int id;
        private decimal prix;
        private int nbMax;
        private ChambreStatut statut;

        public int Id { get => id; set => id = value; }
        public decimal Prix { get => prix; set => prix = value; }
        public int NbMax { get => nbMax; set => nbMax = value; }
        public ChambreStatut Statut { get => statut; set => statut = value; }

        public Chambre(decimal prix, int nbMax, ChambreStatut statut)
        {
            Prix = prix;
            NbMax = nbMax;
            Statut = statut;
        }

        public Chambre(int id, decimal prix, int nbMax, ChambreStatut statut) : this(prix, nbMax, statut)
        {
            Id = id;
        }

        public void SwitchStatut()
        {
            if(Statut == ChambreStatut.Libre)
            {
                Statut = ChambreStatut.Occupe;
            }
            else if(Statut == ChambreStatut.Occupe)
            {
                Statut = ChambreStatut.Libre;
            }
        }
    }

    public enum ChambreStatut
    {
        Libre,
        Occupe
    }
}

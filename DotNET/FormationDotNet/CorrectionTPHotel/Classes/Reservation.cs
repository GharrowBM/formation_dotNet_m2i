using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionTPHotel.Classes
{
    internal class Reservation
    {
        private int id;
        private int nbOccup;
        private Client client;
        private List<Chambre> chambreList;
        private ReservationStatut statut;

        public int Id { get => id; set => id = value; }
        public int NbOccup { get => nbOccup; set => nbOccup = value; }
        public ReservationStatut Statut { get => statut; set => statut = value; }
        public Client Client { get => client; set => client = value; }
        public List<Chambre> ChambreList { get => chambreList; set => chambreList = value; }

        public Reservation()
        {
            ChambreList = new List<Chambre>();
        }
    }

    public enum ReservationStatut
    {
        Validee,
        Annulee,
    }
}

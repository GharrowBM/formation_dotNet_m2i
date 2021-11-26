using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionTPHotel.Classes
{
    internal class Hotel
    {
        private string nom;
        private int id;

        public string Nom { get => nom; set => nom = value; }
        public int Id { get => id; set => id = value; }

        public List<Chambre> GetChambres(ChambreStatut statut)
        {
            return null;
        }

        public List<Reservation> GetReservations(ReservationStatut statut)
        {
            return null;
        }

        public Chambre GetChambre(int id)
        {
            return null;
        }

        public Reservation GetReservation(int id)
        {
            return null;
        }

        public Client Getclient(int id)
        {
            return null;
        }

        public Client SaveClient(Client client)
        {
            return null;
        }

        public Chambre SaveChambre(Chambre Chambre)
        {
            return null;
        }

        public Reservation SaveReservation(Reservation reservation)
        {
            return null;
        }

    }
}

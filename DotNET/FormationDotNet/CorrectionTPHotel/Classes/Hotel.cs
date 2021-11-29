using CorrectionTPHotel.DAO;
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

        public Hotel(string nom, bool createChambre)
        {
            Nom = nom;
            if (createChambre)
            {
                Random r = new Random();
                ChambreDAO dao = new ChambreDAO();
                for (int i = 1; i <= 10; i++)
                {
                    Chambre chambre = new Chambre(r.Next(40, 60), r.Next(1, 5), ChambreStatut.Libre);
                    dao.Save(chambre);
                }
            }
        }


        public List<Chambre> GetChambres(ChambreStatut statut)
        {
            ChambreDAO dao =new ChambreDAO();
            return dao.GetByStatut(statut);
        }

        //public List<Reservation> GetReservations(ReservationStatut statut)
        //{
        //    return null;
        //}

        public Chambre GetChambre(int id)
        {
            ChambreDAO dao = new ChambreDAO();
            return dao.Get(id);            
        }

        public Reservation GetReservation(int id)
        {
            ReservationDAO dao =new ReservationDAO();
            return dao.Get(id);
        }

        public Client Getclient(int id)
        {
            ClientDAO dao =new ClientDAO();
            return dao.GetClientById(id);
        }

        public Client SaveClient(Client client)
        {
            ClientDAO dao =new ClientDAO();
            return dao.Save(client);
        }

        //public Chambre SaveChambre(Chambre Chambre)
        //{
        //    return null;
        //}

        public Reservation SaveReservation(Reservation reservation)
        {
            ReservationDAO reservationDAO =new ReservationDAO();
            return reservationDAO.Save(reservation);
        }

    }
}

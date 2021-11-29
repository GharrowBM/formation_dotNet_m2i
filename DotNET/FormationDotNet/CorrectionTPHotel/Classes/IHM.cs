using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionTPHotel.Classes
{
    internal class IHM
    {
        Hotel hotel;

        public void Demarrer()
        {
            ActionCreationHotel();
            string choix;
            do
            {
                MenuPrincipal();
                choix = Console.ReadLine();
                Console.Clear();
                switch (choix)
                {
                    case "1":
                        ActionAjouterReservation();
                        break;
                    case "2":
                        break;
                        default:
                        Environment.Exit(0);
                        break;
                }
            } while (choix != "0");
        }
        private void ActionCreationHotel()
        {
            Console.Write("Merci de saisir le nom de l'hotel : ");
            string nom = Console.ReadLine();
            Console.Write("Création des chambre ? (o/n) : ");
            bool choix = Console.ReadLine() == "o";
            hotel = new Hotel(nom, choix);
            Continue();

        }

        private void MenuPrincipal()
        {
            Console.WriteLine("1-- Ajouter réservation");
            Console.WriteLine("2-- Annuler réservation");
        }

        private Client ActionAjouterClient()
        {
            Client client = default(Client);
            Console.WriteLine("Un nouveau client ? (o/n) ");
            bool choix = Console.ReadLine() == "o";
            if(choix)
            {
                Console.Write("Nom : ");
                string nom = Console.ReadLine();
                Console.Write("Prénom : ");
                string prenom = Console.ReadLine();
                Console.Write("Téléphone : ");
                string telephone = Console.ReadLine();
                client = new Client(nom, prenom, telephone);
                hotel.SaveClient(client);
            }else
            {
                Console.Write("Numéro du client : ");
                if(Int32.TryParse(Console.ReadLine(), out int n))
                {
                    client = hotel.Getclient(n);
                }
            }
            if(client == default(Client))
            {
                AfficherErreur("Erreur création client");
            }
            return client;

        }

        private void ActionAjouterReservation()
        {
            Reservation reservation = new Reservation();
            reservation.Client = ActionAjouterClient();
            if(reservation.Client != default(Client))
            {
                Console.Write("Le nombre occup max : ");
                if(Int32.TryParse(Console.ReadLine(), out int n))
                {
                    int compteur = n;
                    do
                    {
                        ActionAfficherChambres(hotel.GetChambres(ChambreStatut.Libre));
                        Console.Write("Le numéro de la chambre à ajouter dans la réservation : ");
                        if(Int32.TryParse(Console.ReadLine(),out int numeroChambre))
                        {
                            Chambre chambre = hotel.GetChambre(numeroChambre);
                            chambre.SwitchStatut();
                            reservation.ChambreList.Add(chambre);
                            compteur -= chambre.NbMax;
                        }
                        Continue();
                    }while(compteur > 0);
                    hotel.SaveReservation(reservation);
                    Console.WriteLine("La réservation a été ajoutée");
                    Continue();
                }
            }
        }

        private void ActionAfficherRervation()
        {

        }

        private void ActionAfficherChambres(List<Chambre> chambres)
        {
            foreach(Chambre chambre in chambres)
            {
                Console.WriteLine(chambre.ToString());
            }
        }

        private void Continue()
        {
            Console.WriteLine("Une touche pour continuer.....");
            Console.ReadLine();
            Console.Clear();
        }

        private void AfficherErreur(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ForegroundColor= ConsoleColor.White;
        }
    }
}

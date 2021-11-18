using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaireVersion1.Classes
{
    internal class Banque
    {
        List<Compte> comptes;

        public Banque()
        {
            comptes = new List<Compte>();
        }

        public Client CreerClient(string nom, string prenom, string telephone)
        {
            return null;
        }

        public Compte CreationCompte(Client client, decimal solde)
        {
            return null;
        } 

        public Compte RechercherCompte(int id)
        {
            return null;
        }
    }
}

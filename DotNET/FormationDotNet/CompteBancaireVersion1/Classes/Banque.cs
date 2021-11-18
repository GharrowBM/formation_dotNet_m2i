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
            bool exist = false;
            foreach(Compte compte in comptes)
            {
                if(compte.Client.Telephone == telephone)
                {
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                return new Client(nom, prenom, telephone); 
            }
            return default(Client);
        }

        public Compte CreationCompte(Client client, decimal soldeInitial, string type)
        {
            Compte compte;
            if(type == "3")
            {
                compte = new CompteEpargne();
            }
            else if(type == "2")
            {
                compte = new ComptePayant();
            }
            else
            {
                compte = new Compte();
            }
            compte.Client = client;
            compte.Depot(new Operation(soldeInitial));
            comptes.Add(compte);
            return compte;
        } 

        public Compte RechercherCompte(int id)
        {
            Compte compte = default(Compte);
            foreach(Compte c in comptes)
            {
                if(c.Id == id)
                {
                    compte = c;
                    break;
                }
            }
            return compte;
        }
    }
}

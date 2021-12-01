using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaireVersion1.Classes
{
    public class Banque
    {
        List<Compte> comptes;

        public Banque()
        {
            comptes = new List<Compte>();
        }

        public Client CreerClient(string nom, string prenom, string telephone)
        {
            //On verifie dans la base de données
            //bool exist = false;
            //foreach(Compte compte in comptes)
            //{
            //    if(compte.Client.Telephone == telephone)
            //    {
            //        exist = true;
            //        break;
            //    }
            //}
            if (!Client.ClientExist(telephone))
            {
                Client client = new Client(nom, prenom, telephone);
                if(client.Save())
                {
                    return client;
                }
                return default(Client);
                
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
            //enregister le compte dans la base
            if(compte.Save())
            {
                compte.Depot(new Operation(soldeInitial));
            }
            //comptes.Add(compte);
            return compte;
        } 

        public Compte RechercherCompte(int id)
        {
            //Compte compte = default(Compte);
            //foreach(Compte c in comptes)
            //{
            //    if(c.Id == id)
            //    {
            //        compte = c;
            //        break;
            //    }
            //}
            //return compte;
            return Compte.GetCompte(id);
        }
    }
}

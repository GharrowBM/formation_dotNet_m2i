using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaireVersion1.Classes
{
    internal class IHM
    {
        Banque banque;

        public IHM()
        {
            banque = new Banque();
        }
        public void Demarrer()
        {
            string choix;
            do
            {
                MenuPrincipal();
                choix = Console.ReadLine();
                Console.Clear();
                switch(choix)
                {
                    case "1":
                        ActionCreationCompte();
                        break;
                    case "2":
                        ActionDepot();
                        break;
                    case "3":
                        ActionRetrait();
                        break;
                    case "4":
                        ActionAffichageCompte();
                        break;
                    case "5":
                        ActionCalculeInteret();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }                
            }while(choix != "0");
        }

        private void MenuPrincipal()
        {
            Console.WriteLine("1--Créer un compte");
            Console.WriteLine("2--Effectuer un dépôt");
            Console.WriteLine("3--Effectuer un retrait");
            Console.WriteLine("4--Afficher un compte");
            Console.WriteLine("5--Calcule Interet d'un compte");
            Console.WriteLine("0--Quitter");
        }

        private void ActionCreationCompte()
        {
            Console.Clear();
            Console.WriteLine("Information du client : ");
            Console.Write("Merci de saisir le nom : ");
            string nom = Console.ReadLine();
            Console.Write("Merci de saisir le prénom : ");
            string prenom = Console.ReadLine();
            Console.Write("Merci de saisir le téléphone : ");
            string telephone = Console.ReadLine();
            Client client = banque.CreerClient(nom, prenom, telephone);
            if(client != default(Client))
            {
                Console.Clear();
                Console.Write("Solde initial du compte : ");
                decimal solde = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("1- Compte Courant");
                Console.WriteLine("2- Compte Payant");
                Console.WriteLine("3- Compte Epargne");
                string choix = Console.ReadLine();
                Compte compte = banque.CreationCompte(client, solde, choix);
                if(compte != default(Compte))
                {
                    compte.ADecouvert += NotificationCompteADecouvert;
                    Console.WriteLine($"Compte crée avec le numéro {compte.Id}");
                }
                else
                {
                    Console.WriteLine("Erreur création compte");

                }
            }
            else
            {
                Console.WriteLine("Client existe déjà");
            }
        }

        private void ActionDepot()
        {
            Compte compte = RechercheCompte();
            if(compte != default(Compte))
            {
                Console.Clear();
                Console.Write("Merci de saisir le montant du depot : ");
                decimal montant = Convert.ToDecimal(Console.ReadLine());    
                Operation operation = new Operation(montant);
                if(compte.Depot(operation))
                {
                    Console.WriteLine($"Dépôt effecuté, nouveau solde est de {compte.Solde}");
                }
                else
                {
                    Console.WriteLine("Erreur dépôt");
                }
            }
        }
        private void ActionRetrait()
        {
            Compte compte = RechercheCompte();
            if (compte != default(Compte))
            {
                Console.Clear();
                Console.Write("Merci de saisir le montant du retrait : ");
                decimal montant = Convert.ToDecimal(Console.ReadLine());
                Operation operation = new Operation(montant*-1);
                if (compte.Retrait(operation))
                {
                    Console.WriteLine($"Retrait effecuté, nouveau solde est de {compte.Solde}");
                }
                else
                {
                    Console.WriteLine("Erreur retrait");
                }
            }
        }

        private void ActionAffichageCompte()
        {
            Compte compte = RechercheCompte();
            if (compte != default(Compte))
            {
                Console.Clear();
                Console.WriteLine(compte.Client);
                Console.WriteLine($"Solde : {compte.Solde}");
                Console.WriteLine("Liste des opérations:");
                foreach(Operation op in compte.Operations)
                {
                    Console.WriteLine(op);
                }
            }
        }

        private Compte RechercheCompte()
        {
            Console.Clear();
            Console.Write("Merci de saisir le numéro de compte : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Compte compte = banque.RechercherCompte(id);
            if(compte == default(Compte))
            {
                Console.WriteLine("Aucun compte avec ce numéro");
            }
            return compte;
        }

        private void NotificationCompteADecouvert(int id, decimal solde)
        {
            Console.WriteLine($"Le compte {id} est à decouvert de {solde} euros");
        }
        private void ActionCalculeInteret()
        {
            Compte compte = RechercheCompte();
            if(compte != default(Compte))
            {
                //CompteEpargne compteEpargne = (CompteEpargne)compte;
                //CompteEpargne compteEpargne = compte as CompteEpargne;
                //On peut convertir avec is
                if(compte is CompteEpargne compteEpargne)
                {
                    if(compteEpargne.CalculeInteret())
                    {
                        Console.WriteLine($"Intert calculé, nouveau solde est de {compteEpargne.Solde}");
                    }
                }
            }
        }
    }
}

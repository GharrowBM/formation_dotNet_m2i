using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumNouvelle.Classes
{
    internal class IHM
    {
        private Forum forum;
        private Moderateur moderateur;
        private Abonne abonne;

        public void Demarrer()
        {
            CreationForum();
            Console.Clear();
            CreationModerateur();
            string choix;
            do
            {
                MenuPrincipal();
                choix = Console.ReadLine();
                switch(choix)
                {
                    case "1":
                        ActionsModerateur();
                        break;
                    case "2":
                        ActionsAbonne();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }while(choix != "0");
        }

        private void CreationForum()
        {
            Console.WriteLine("Première étape - Création du Forum");
            Console.Write("Le nom de votre Forum : ");
            string nom = Console.ReadLine();
            Console.Write("Le nombre max de nouvelles : ");
            int nbMaxNouvelles = Convert.ToInt32(Console.ReadLine());
            Console.Write("Le nombre max d'abonnés : ");
            int nbMaxAbonnes = Convert.ToInt32(Console.ReadLine());
            forum = new Forum(nom, nbMaxNouvelles, nbMaxAbonnes);
        }

        private void CreationModerateur()
        {
            Console.WriteLine("Deuxième étape - Ajout d'un modérateur à votre Forum");
            Console.Write("Le nom de votre modérateur : ");
            string nomModerateur = Console.ReadLine();
            Console.Write("Le prénom de votre modérateur : ");
            string prenomModerateur = Console.ReadLine();
            Console.Write("L'age de votre modérateur : ");
            int age = Convert.ToInt32(Console.ReadLine());
            moderateur = new Moderateur(nomModerateur, prenomModerateur, age, forum);
        }

        private void MenuPrincipal()
        {
            Console.WriteLine("1-- Moderateur");
            Console.WriteLine("2-- Abonne");
        }

        private void MenuAbonne()
        {
            Console.WriteLine("0-- Quitter");
            Console.WriteLine("1-- Ajouter une nouvelle");
            Console.WriteLine("2-- Lister les nouvelles");
            Console.WriteLine("3-- Répondre à une nouvelle");
        }

        private void MenuModerateur()
        {
            MenuAbonne();
            Console.WriteLine("4-- Ajouter un abonne");
            Console.WriteLine("5-- Lister les abonnes");
            Console.WriteLine("6-- Bannir abonné");
            Console.WriteLine("7-- Supprimer nouvelle");
        }

        private void ActionsModerateur()
        {
            abonne = moderateur;
            string choix;
            do
            {
                MenuModerateur();
                choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        ActionAjouterNouvelle();
                        break;
                    case "2":
                        ActionListerNouvelles();
                        break;
                    case "3":
                        ActionRepondreNouvelle();
                        break;
                    case "4":
                        ActionAjouterAbonne();
                        break;
                    case "5":
                        ActionListerAbonnes();
                        break;
                    case "6":
                        ActionBannirAbonne();
                        break;
                    case "7":
                        ActionSupprimerNouvelle();
                        break;
                }
            }while (choix!= "0");
        }

        private void ActionsAbonne()
        {
            //Chercher Abonne
            
            string choix;
            do
            {
                MenuAbonne();
                choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        ActionAjouterNouvelle();
                        break;
                    case "2":
                        ActionListerNouvelles();
                        break;
                    case "3":
                        ActionRepondreNouvelle();
                        break;
                    
                }
            } while (choix != "0");
        }


        private void ActionAjouterNouvelle()
        {

        }

        private void ActionListerNouvelles()
        {

        }

        private void ActionRepondreNouvelle()
        {

        }

        private void ActionAjouterAbonne()
        {

        }

        private void ActionListerAbonnes()
        {

        }

        private void ActionBannirAbonne()
        {

        }
        private void ActionSupprimerNouvelle()
        {

        }
    }
}

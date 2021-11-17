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
                Console.Clear();
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
                Console.Clear();
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
            Console.Write("Index de l'abonné : ");
            int index = Convert.ToInt32(Console.ReadLine());
            abonne = forum.RechercherAbonne(index);
            if(abonne != default(Abonne))
            {
                string choix;
                do
                {
                    MenuAbonne();
                    choix = Console.ReadLine();
                    Console.Clear();
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
            }else
            {
                Console.WriteLine("Aucun abonné avec cet id");
            }
            
        }


        private void ActionAjouterNouvelle()
        {
            Console.Write("Merci de saisir le sujet de la nouvelle : ");
            string sujet = Console.ReadLine();
            Console.Write("Merci de saisir le contenu de la nouvelle : ");
            string contenu = Console.ReadLine();
            Nouvelle nouvelle = abonne.CreerNouvelle(sujet, contenu);
            if(abonne.DeposerNouvelle(nouvelle))
            {
                Console.WriteLine("Nouvelle ajoutée");
            }
            else
            {
                Console.WriteLine("Impossible d'ajouter la nouvelle");
            }
        }

        private void ActionListerNouvelles()
        {
            abonne.ListerNouvelle();
        }

        private void ActionRepondreNouvelle()
        {
            ActionListerNouvelles();
            Console.Write("L'id  de la nouvelle : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Nouvelle nouvelle = abonne.ConsulterNouvelle(id);
            if(nouvelle != default(Nouvelle))
            {
                Console.Write("Merci de saisir la réponse : ");
                string reponse = Console.ReadLine();
                if(abonne.RepondreANouvelle(nouvelle, reponse))
                {
                    Console.WriteLine("Votre réponse a été ajoutée");
                }
                else
                {
                    Console.WriteLine("Erreur de réponse à une nouvelle ");
                }
            }
            else
            {
                Console.WriteLine("Aucune nouvelle avec cet id");
            }
        }

        private void ActionAjouterAbonne()
        {
            Console.Write("Merci de saisir le nom de l'abonné : ");
            string nom = Console.ReadLine();
            Console.Write("Merci de saisir le prénom de l'abonné : ");
            string prenom = Console.ReadLine();
            Console.Write("Merci de saisir l'age de l'abonné : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if(moderateur.AjouterAbonne(new Abonne(nom, prenom, age, forum)))
            {
                Console.WriteLine("Abonné ajouté");
            }
            else
            {
                Console.WriteLine("Erreur ajout abonné");
            }
        }

        private void ActionListerAbonnes()
        {
            moderateur.ListerAbonnes();
        }

        private void ActionBannirAbonne()
        {
            ActionListerAbonnes();
            Console.Write("L'index de l'abonné à bannir");
            int index = Convert.ToInt32(Console.ReadLine());
            Abonne a = forum.RechercherAbonne(index);
            if(a != default(Abonne))
            {
                if (moderateur.BannirAbonne(a))
                {
                    Console.WriteLine("l'abonné n'est plus la");
                }
                else
                {
                    Console.WriteLine("Erreur pour bannir l'abonné");
                }
            }
            else
            {
                Console.WriteLine("Aucun abonné avec cet id");
            }
        }
        private void ActionSupprimerNouvelle()
        {
            ActionListerNouvelles();
            Console.Write("L'id  de la nouvelle : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Nouvelle nouvelle = moderateur.ConsulterNouvelle(id);
            if (nouvelle != default(Nouvelle))
            {
                if (moderateur.SupprimerNouvelle(nouvelle))
                {
                    Console.WriteLine("Nouvelle supprimée");
                }
                else
                {
                    Console.WriteLine("Erreur suppression nouvelle");
                }
            }
            else
            {
                Console.WriteLine("Aucune nouvelle avec cet id");
            }

        }
    }
}

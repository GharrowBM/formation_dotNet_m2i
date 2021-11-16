using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpSalarie.Classes
{
    internal class IHM
    {
        private Salarie[] salaries;
        private int compteur = 0;
        public IHM(int nbSalarie)
        {
            salaries = new Salarie[nbSalarie];
        }
        public void Demarrer()
        {
            string choix;
            do
            {
                AfficherMenu();
                choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        ActionAjouterSalarie();
                        break;
                    case "2":
                        ActionAfficherSalaries();
                        break;
                    case "3":
                        ActionAfficherTotalSalaire();
                        break;
                    case "4":
                        ActionAfficherNbSalaries();
                        break;
                    case "5":
                        ActionRechercheSalarie();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            } while (choix != "0");
        }


        private void AfficherMenu()
        {
            Console.WriteLine("1-- Ajouter un salarié");
            Console.WriteLine("2-- Afficher les salariés");
            Console.WriteLine("3-- Afficher total salaires");
            Console.WriteLine("4-- Afficher nombre salarié");
            Console.WriteLine("5-- Recherche salarié");
        }

        private void AfficherMenuTypeEmploye()
        {
            Console.WriteLine("1-- Salarié");
            Console.WriteLine("2-- Commercial");
        }

        private void ActionAjouterSalarie()
        {
            Console.WriteLine("----Ajout d'un salarié----");
            Console.Write("Merci de saisir le nom du salairé : ");
            string nom = Console.ReadLine();
            Console.Write("Merci de saisir le matricule du salairé : ");
            string matricule = Console.ReadLine();
            Console.Write("Merci de saisir le service du salairé : ");
            string service = Console.ReadLine();
            Console.Write("Merci de saisir le categorie du salairé : ");
            string categorie = Console.ReadLine();
            Console.Write("Merci de saisir le salaire du salairé : ");
            decimal salaire = Convert.ToDecimal(Console.ReadLine());
            AfficherMenuTypeEmploye();
            string type = Console.ReadLine();
            Salarie s = null;
            if (type == "1")
            {
                s = new Salarie(matricule, categorie, salaire, service, nom);
                //if(compteur < salaries.Length - 1)
                //{
                //    salaries[compteur] = s;
                //    compteur++;
                //}
                //else
                //{
                //    Console.WriteLine("Il n'y a plus d'argent pour recruter");
                //}
            }
            else if(type == "2")
            {
                Console.Write("Merci de saisir le chiffre d'affaire : ");
                decimal chiffreAffaire = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Merci de saisir la commission en % : ");
                decimal commission = Convert.ToDecimal(Console.ReadLine());
                s = new Commercial(matricule, categorie, salaire, service, nom, chiffreAffaire, commission);
                //if (compteur < salaries.Length - 1)
                //{
                //    salaries[compteur] = s;
                //    compteur++;
                //}
                //else
                //{
                //    Console.WriteLine("Il n'y a plus d'argent pour recruter");
                //}
            }

            if(s != null)
            {
                if (compteur < salaries.Length - 1)
                {
                    salaries[compteur] = s;
                    compteur++;
                }
                else
                {
                    Console.WriteLine("Il n'y a plus d'argent pour recruter");
                }
            }
        }

        private void ActionAfficherSalaries()
        {
            Console.WriteLine("----Afficher les salarié----");
            foreach(Salarie salarie in salaries)
            {
                if(salarie != default(Salarie))
                    Console.WriteLine(salarie.AfficherSalaire());
            }
        }

        private void ActionAfficherTotalSalaire()
        {
            Console.WriteLine("----Afficher total des salaires----");
            Console.WriteLine(Salarie.TotalSalaire + " euros");
        }

        private void ActionAfficherNbSalaries()
        {
            Console.WriteLine("----Afficher le nombre des salariés----");
            Console.WriteLine(Salarie.NbSalaries);
        }

        private void ActionRechercheSalarie()
        {
            Console.Write("Merci de saisir le nom : ");
            string nom = Console.ReadLine();
            bool found = false;
            foreach(Salarie s in salaries)
            {
                if(s != default(Salarie))
                {
                    if(s.Nom == nom)
                    {
                        found = true;
                        Console.WriteLine(s.AfficherSalaire());
                        break;
                    }
                }
            }
            if (!found)
                Console.WriteLine("Aucun salarié avec ce nom");
        }
    }
}

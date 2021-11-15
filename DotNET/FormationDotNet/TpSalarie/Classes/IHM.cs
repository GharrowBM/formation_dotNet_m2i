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
            Salarie s = new Salarie(matricule, categorie, salaire, service, nom);
            if(compteur < salaries.Length - 1)
            {
                salaries[compteur] = s;
                compteur++;
            }
            else
            {
                Console.WriteLine("Il n'y a plus d'argent pour recruter");
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
    }
}

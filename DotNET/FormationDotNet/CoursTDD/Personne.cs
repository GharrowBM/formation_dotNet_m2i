using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTDD
{
    public class Personne
    {
        private string nom;
        private string prenom;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        
        public static List<Personne> personnes = new List<Personne>()
        {
            new Personne("toto", "tata"),
            new Personne("minet", "titi"),
        };

        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public static Personne RechercherPersonne(string nom)
        {
            Personne personne = default(Personne);
            foreach(Personne person in personnes)
            {
                if(person.Nom == nom)
                {
                    personne = person;
                    break;
                }
            }
            return personne;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumNouvelle.Classes
{
    internal class Abonne
    {
        private string nom;
        private string prenom;
        private int age;
        private Forum forum;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Age { get => age; set => age = value; }


        public Abonne(string nom, string prenom, int age, Forum forum)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }

        public Nouvelle CreerNouvelle(string sujet, string contenu)
        {
            return new Nouvelle(sujet, contenu);
        }

        public bool DeposerNouvelle(Nouvelle nouvelle)
        {
            //A coder
            return false;
        }

        public bool RepondreANouvelle(Nouvelle nouvelle, string reponse)
        {
            //A Coder
            return false;
        }

        public void ListerNouvelle()
        {
            //A Coder
        }

        public void ConsulterNouvelle(int index)
        {
            //A Coder
        }
    }
}

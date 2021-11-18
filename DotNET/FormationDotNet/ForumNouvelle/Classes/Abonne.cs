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
        protected Forum forum;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Age { get => age; set => age = value; }


        public Abonne(string nom, string prenom, int age, Forum forum)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            this.forum = forum;
        }

        public Nouvelle CreerNouvelle(string sujet, string contenu)
        {
            return new Nouvelle(sujet, contenu);
        }

        public bool DeposerNouvelle(Nouvelle nouvelle)
        {
            //A coder
            //if(forum.CompteurNouvelles < forum.Nouvelles.Length - 1)
            //{
            //    forum.Nouvelles[forum.CompteurNouvelles++] = nouvelle;
            //    //forum.CompteurNouvelles++;
            //    return true;
            //}
            //return false;
            forum.Nouvelles.Add(nouvelle);
            return true;
        }

        public bool RepondreANouvelle(Nouvelle nouvelle, string reponse)
        {
            //A Coder
            Nouvelle reponseNouvelle = CreerNouvelle(nouvelle.Sujet, reponse);
            return DeposerNouvelle(reponseNouvelle);
        }

        public void ListerNouvelle()
        {
            foreach(Nouvelle n in forum.Nouvelles)
            {
                if(n != default(Nouvelle))
                Console.WriteLine(n);
            }
        }

        public Nouvelle ConsulterNouvelle(int index)
        {
            if(index >= 0 && index < forum.Nouvelles.Count)
            {
                return forum.Nouvelles[index];
            }
            return default(Nouvelle);
        }

        public override bool Equals(object abonne)
        {
            return Nom == ((Abonne)abonne).Nom && Prenom== ((Abonne)abonne).Prenom;
        }

        public override string ToString()
        {
            return $"Nom : {Nom}, Prénom : {Prenom}, Age : {Age}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumNouvelle.Classes
{
    internal class Forum
    {
        private string nom;
        private DateTime dateCreation;
        //private Abonne[] abonnes;
        //private Nouvelle[] nouvelles;
        private List<Abonne> abonnes;
        private List<Nouvelle> nouvelles;
       // private Moderateur moderateur;
        private int compteurNouvelles;
        private int compteurAbonnes;

        public int CompteurNouvelles { get => compteurNouvelles; set => compteurNouvelles = value; }
        public int CompteurAbonnes { get => compteurAbonnes; set => compteurAbonnes = value; }
        public List<Abonne> Abonnes { get => abonnes; set => abonnes = value; }
        public List<Nouvelle> Nouvelles { get => nouvelles; set => nouvelles = value; }
        //public Moderateur Moderateur { get => moderateur; set => moderateur = value; }
        public string Nom { get => nom; set => nom = value; }
        public DateTime DateCreation { get => dateCreation; set => dateCreation = value; }

        public Forum(string nom, int tailleMaxNouvelle, int tailleMaxAbonne)
        {
            Nom = nom;
            DateCreation = DateTime.Now;
            //Moderateur = new Moderateur()
            //Nouvelles = new Nouvelle[tailleMaxNouvelle];
            //Abonnes = new Abonne[tailleMaxAbonne];
            Nouvelles = new List<Nouvelle>();
            Abonnes = new List<Abonne>();
            CompteurAbonnes = 0;
            CompteurNouvelles = 0;
        }

        public Abonne RechercherAbonne(int index)
        {
            if(index >= 0 && index < Abonnes.Count)
            {
                return Abonnes[index];
            }
            return default(Abonne);
        }
    }
}

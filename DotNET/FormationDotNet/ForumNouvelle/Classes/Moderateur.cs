using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumNouvelle.Classes
{
    internal class Moderateur : Abonne
    {
        public Moderateur(string nom, string prenom, int age, Forum forum) : base(nom, prenom, age, forum)
        {
        }

        public bool AjouterAbonne(Abonne abonne)
        {
            if(forum.CompteurAbonnes < forum.Abonnes.Length - 1)
            {
                forum.Abonnes[forum.CompteurAbonnes++] = abonne;
                return true;
            }
            return false;
        }

        public bool BannirAbonne(Abonne abonne)
        {
            bool done = false;
            for(int i = 0; i < forum.Abonnes.Length; i++)
            {
                if(forum.Abonnes[i].Equals(abonne))
                {
                    forum.Abonnes[i] = default(Abonne);
                    for(int j = i+1; j < forum.Abonnes.Length; j++)
                    {
                        forum.Abonnes[j-1] = forum.Abonnes[j];
                    }
                    done = true;
                    forum.CompteurAbonnes--;
                }
            }
            return done;
        }
        public bool SupprimerNouvelle(Nouvelle nouvelle)
        {
            return false;
        }

        public void ListerAbonnes()
        {

        }
    }
}

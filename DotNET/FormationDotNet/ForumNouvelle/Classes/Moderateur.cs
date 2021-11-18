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
            //if(forum.CompteurAbonnes < forum.Abonnes.Length - 1)
            //{
            //    forum.Abonnes[forum.CompteurAbonnes++] = abonne;
            //    return true;
            //}
            //return false;
            forum.Abonnes.Add(abonne);
            return true;
        }

        public bool BannirAbonne(Abonne abonne)
        {
            //bool done = false;
            //for(int i = 0; i < forum.Abonnes.Length; i++)
            //{
            //    if(forum.Abonnes[i] != default(Abonne) && forum.Abonnes[i].Equals(abonne))
            //    {
            //        forum.Abonnes[i] = default(Abonne);
            //        for(int j = i+1; j < forum.Abonnes.Length; j++)
            //        {
            //            forum.Abonnes[j-1] = forum.Abonnes[j];
            //        }
            //        done = true;
            //        forum.CompteurAbonnes--;
            //    }
            //}
            //return done;
            return forum.Abonnes.Remove(abonne);
        }
        public bool SupprimerNouvelle(Nouvelle nouvelle)
        {
            //bool done = false;
            //for(int i = 0; i< forum.Nouvelles.Length; i++)
            //{
            //    if (forum.Nouvelles[i] != default(Nouvelle) && forum.Nouvelles[i].Equals(nouvelle))
            //    {
            //        forum.Nouvelles[i] = default(Nouvelle);
            //        for (int j = i + 1; j < forum.Nouvelles.Length; j++)
            //        {
            //            forum.Nouvelles[j - 1] = forum.Nouvelles[j];
            //        }
            //        done=true;
            //        forum.CompteurNouvelles--;
            //    }
            //}
            //return done;
            return forum.Nouvelles.Remove(nouvelle);
        }

        public void ListerAbonnes()
        {
            foreach(Abonne a in forum.Abonnes)
            {
                if(a != default(Abonne))
                Console.WriteLine(a);
            }
        }
    }
}

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
            return false;
        }

        public bool BannirAbonne(Abonne abonne)
        {
            return false;
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

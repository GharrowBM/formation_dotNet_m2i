using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumNouvelle.Classes
{
    internal class Nouvelle
    {
        private string sujet;
        private string contenu;

        public string Sujet { get => sujet; set => sujet = value; }
        public string Contenu { get => contenu; set => contenu = value; }

        public Nouvelle(string sujet, string contenu)
        {
            Sujet = sujet;
            Contenu = contenu;
        }
    }
}

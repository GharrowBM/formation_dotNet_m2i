using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWPFMVVM.Models
{
    internal class Personne
    {
        private string nom;
        private string prenom;
        private string telephone;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Telephone { get => telephone; set => telephone = value; }

        public Personne()
        {

        }
        public Personne(string nom, string prenom, string telephone)
        {
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
        }
    }
}

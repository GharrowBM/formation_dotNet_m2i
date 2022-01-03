using System;
namespace coursAPI.Models
{
    public class Personne
    {
        private string nom;
        private string prenom;
        public Personne()
        {
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
    }
}

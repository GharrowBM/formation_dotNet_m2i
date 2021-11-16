using System;
namespace CoursPOO.Classes
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


        protected void AfficherInfo()
        {
            Console.WriteLine($"Le nom est {Nom} et le prénom est {Prenom}");
        }
    }
}

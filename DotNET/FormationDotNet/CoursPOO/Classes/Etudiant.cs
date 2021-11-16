using System;
namespace CoursPOO.Classes
{
    public class Etudiant : Personne
    {
        private int niveau;
        public Etudiant()
        {
        }

        public int Niveau { get => niveau; set => niveau = value; }

        public void AfficherAvecNiveau()
        {
            AfficherInfo();
            Console.WriteLine($"Le niveau est de {Niveau}");
        }
    }
}

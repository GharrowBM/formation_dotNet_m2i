using System;
namespace CoursPOO.Classes
{
    public class Etudiant : Personne
    {
        private int niveau;
        public Etudiant()
        {
        }

        public Etudiant(string n, string p, int ni) : base(n,p)
        {
            //Nom = n;
            //Prenom = p;
            Niveau = ni;
        }

        public int Niveau { get => niveau; set => niveau = value; }

        public void AfficherAvecNiveau()
        {
            AfficherInfo();
            Console.WriteLine($"Le niveau est de {Niveau}");
        }


        //pour ré-ecrire une méthode de la classe mère. => on peut utiliser deux mots clés, le premier override
        public override void Marcher()
        {
            //base.Marcher();
            Console.WriteLine($"Je suis un étudiant qui marche avec niveau {Niveau}");
        }
    }
}

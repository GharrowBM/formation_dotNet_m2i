using System;
namespace CoursPOO.Classes
{
    public abstract class Personne
    {
        private string nom;
        private string prenom;
        private int age;
        public Personne()
        {
        }


        public Personne(string n, string p)
        {
            Nom = n;
            Prenom = p;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Age
        {
            get => age; set
            {
                if (value >= 0 && value < 110)
                    age = value;
                else
                    //throw new Exception("Erreur de saisi d'age");
                    throw new AgeException();
            }
        }

        public abstract void Afficher();
        protected void AfficherInfo()
        {
            Console.WriteLine($"Le nom est {Nom} et le prénom est {Prenom}");
        }

        //Pour authoriser les classes enfants à réecrire une méthode, il faut que la méthode soit en virtual
        public virtual void Marcher()
        {
            Console.WriteLine("Je suis une personne qui marche");
        }
    }
}

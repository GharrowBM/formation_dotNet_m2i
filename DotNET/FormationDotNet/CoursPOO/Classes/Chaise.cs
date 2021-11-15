using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursPOO.Classes
{
    internal class Chaise
    {
        private static int nbChaise = 0;
        private int nbPieds;
        private string couleur;
        private string materiel;

        public Chaise()
        {
            nbChaise++;
        }

        public Chaise(int nbPieds, string couleur, string materiel)
        {
            this.NbPieds = nbPieds;
            this.Couleur = couleur;
            this.Materiel = materiel;
            nbChaise++;
        }

        public void Afficher()
        {
            Console.WriteLine($"Je suis une chaise, avec {nbPieds} pieds en {Materiel} et de couleur {Couleur}");
        }

        //public int GetNbPieds()
        //{
        //    //Logique métier
        //    return nbPieds;
        //}
        //public void SetNbPieds(int n)
        //{
        //    //Logique métier
        //    nbPieds = n;
        //}

        //<=> par des propriétés
        public int NbPieds
        {
            get
            {
                //Logique metier
                return nbPieds;
            }
            set
            {
                //Logique metier
                nbPieds = value;
            }
        }

        public string Couleur { get => couleur; set => couleur = value; }
        public string Materiel { get => materiel; set => materiel = value; }
        public static int NbChaise { get => nbChaise;}
    }
}

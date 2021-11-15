using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursPOO.Classes
{
    internal class Chaise
    {
        public int nbPieds;
        public string couleur;
        public string materiel;

        public Chaise()
        {

        }

        public Chaise(int nbPieds, string couleur, string materiel)
        {
            this.nbPieds = nbPieds;
            this.couleur = couleur;
            this.materiel = materiel;
        }

        public void Afficher()
        {
            Console.WriteLine($"Je suis une chaise, avec {nbPieds} pieds en {materiel} et de couleur {couleur}");
        }
    }
}

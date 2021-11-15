using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursPOO
{
    internal class Avion
    {
        public string couleur;
        public int nbPlaces;

        //Constructeur

        public Avion()
        {

        }
        public Avion(string c, int n)
        {
            //Action a executer pendant la construction de votre objet
            couleur = c;
            nbPlaces = n;

        }
        public string Voler()
        {
            //Console.WriteLine($"L'avion de couleur {couleur} et avec un nombre de places {nbPlaces} a volé");
            return $"L'avion de couleur {couleur} et avec un nombre de places {nbPlaces} a volé";
        }
    }
}

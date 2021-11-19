using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoursPOO.Interfaces;

namespace CoursPOO
{
    internal class Avion : IVolant
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

        public void Atterrir()
        {
            Console.WriteLine("Un avion qui atterrit");
        }

        public void Decoller()
        {
            Console.WriteLine("Un avion qui decolle");
        }

        //public string Voler()
        //{
        //    //Console.WriteLine($"L'avion de couleur {couleur} et avec un nombre de places {nbPlaces} a volé");
        //    return $"L'avion de couleur {couleur} et avec un nombre de places {nbPlaces} a volé";
        //}

        public void Voler()
        {
            Console.WriteLine("Un avion qui vole");
        }


        public void SpecialAvion()
        {
            Console.WriteLine("Special avion");
        }
    }
}

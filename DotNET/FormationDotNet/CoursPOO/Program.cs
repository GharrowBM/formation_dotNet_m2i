﻿using CoursPOO;
//using CoursPOO.AirBus;
//using CoursPOO.Boeing;
using System;
namespace CoursPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avion avion1 = new Avion("rouge", 189);
            //avion1.nbPlaces = 189;
            //avion1.couleur = "rouge";
            Console.WriteLine(avion1.nbPlaces);
            Console.WriteLine(avion1.couleur);
            string result = avion1.Voler();
            Console.WriteLine(result);
            Console.WriteLine(avion1.GetType());
        }
    }
}

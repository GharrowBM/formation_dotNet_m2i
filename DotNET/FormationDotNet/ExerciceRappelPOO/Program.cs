using ExerciceRappelPOO.Classes;
using System;

namespace ExerciceRappelPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture laguna = new Voiture("Laguna", "Renault", 30);
            laguna.Rouler(25);
            laguna.Rouler(10);
        }
    }
}

using System;

namespace Exercice05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Veuillez saisir un nombre : ");
            double premierNombre = Convert.ToDouble(Console.ReadLine());
            Console.Write("Veuillez saisir un nombre : ");
            double deuxiemeNombre = Convert.ToDouble(Console.ReadLine());
            double resultat = premierNombre + deuxiemeNombre;
            Console.WriteLine("La somme de ces deux nombre est : " + resultat + "\n");
        }
    }
}

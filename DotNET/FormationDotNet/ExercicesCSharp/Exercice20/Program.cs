using System;

namespace Exercice20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Je compte jusqu'à 10 --- \n");
            Console.WriteLine("Je commence à compter :");

            // Permet de faire une boucle itérative allant jusqu'à 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\t"+i);
            }
            Console.WriteLine("Super ! Je sais compter jusqu'à 10 !\n");
           
            Console.WriteLine("Appuyez sur Entrer pour fermer le programme...");
            Console.Read();
        }
    }
}

using System;

namespace Exercice21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Menus et sous-menus --- \n");
            Console.WriteLine("Table des matières :\n");

            // Permet de faire une boucle itérative allant jusqu'à 10
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("\tChapitre " + i);
                for(int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("\t\t-Partie " + i + "." + j);
                }
            }
            Console.WriteLine("");

            Console.WriteLine("Appuyez sur Entrer pour fermer le programme...");
            Console.Read();
        }
    }
}

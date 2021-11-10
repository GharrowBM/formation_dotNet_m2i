using System;

namespace Exercice22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Les tables de multiplication --- \n");
            

            // Permet de faire une boucle itérative allant jusqu'à 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Table de " + i + " : ");

                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("\t- " + i + " x " + j + " = " + (i * j));
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            Console.WriteLine("Appuyez sur Entrer pour fermer le programme...");
            Console.Read();
        }
    }
}

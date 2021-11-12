using System;
using System.Linq;
namespace Exercice36
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab;
            int taille, temp;
            double somme = 0;
            Console.WriteLine("*** Tableaux des notes ***");
            Console.Write("Combien de notes comportera le tableau ? ");
            taille = Convert.ToInt32(Console.ReadLine());
            tab = new int[taille];


            Console.WriteLine($"Merci de saisir les {taille} notes.");

            for (int i = 0; i < taille; i++)
            {
                do
                {
                    Console.Write($"\tNote {i + 1} : ");
                    temp = Convert.ToInt32(Console.ReadLine());
                    if (temp >= 0 && temp <= 20)
                        tab[i] = temp;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Erreur, merci de saisir une note entre 0 et 20");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                } while (!(temp >= 0 && temp <= 20));
            }

            Console.WriteLine("\n---Liste des notes ---");
            for (int i = 0; i < taille; i++)
            {
                Console.Write($"La note {i + 1} est de : {tab[i]}/20\n");
                somme += tab[i];
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n--- La note max est {tab.Min()}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"--- La note min est {tab.Max()}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"--- La note moy est {Math.Round(somme / taille, 1)}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

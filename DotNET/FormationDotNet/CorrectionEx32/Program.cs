using System;

namespace CorrectionEx32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merci de saisir la taille du tableau : ");
            int taille = Convert.ToInt32(Console.ReadLine());
            int[] tabEntier = new int[taille];
            for (int i = 0; i < taille; i++)
            {
                Console.Write($"Merci de saisir la valeur de la case {i+1} : ");
                tabEntier[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("=====Le contenu du tableau====");
            for(int i = 0;i < tabEntier.Length; i++)
            {
                Console.WriteLine(tabEntier[i]);
            }
        }
    }
}

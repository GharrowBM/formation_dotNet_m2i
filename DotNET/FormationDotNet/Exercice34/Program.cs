using System;

namespace Exercice34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merci de saisir la taille du tableau : ");
            int taille = Convert.ToInt32(Console.ReadLine());
            int[] tabEntier = new int[taille];
            Random random = new Random();
            int nbPair = 0;
            for (int i = 0; i < taille; i++)
            {
               
                tabEntier[i] = random.Next(1,1001);
            }
            Console.WriteLine("=====Le contenu du tableau====");
            for (int i = 0; i < tabEntier.Length; i++)
            {
                string result = tabEntier[i].ToString();
                if(tabEntier[i]%2 == 0)
                {
                    nbPair++;
                    result += " Pair ";
                }else
                {
                    result += " Impair ";
                }
                //result += (tabEntier[i]%2 == 0) ? " Pair " : "Impair";
                Console.WriteLine(result);
            }
            Console.WriteLine($"Le nombre de chiffre pair est de : {nbPair}");
            Console.WriteLine($"Le nombre de chiffre impair est de : {taille-nbPair}");
        }
    }
}

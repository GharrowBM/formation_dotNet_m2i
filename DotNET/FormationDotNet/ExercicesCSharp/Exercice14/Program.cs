using System;

namespace Exercice14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Quelle taille dois-je prendre ? --- \n");
            Console.Write("Entrez votre taille (en cm) : ");
            int taille = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez votre poids (en kg) : ");
            int poids = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(" ");
            if (taille >= 145 && taille < 169 && poids >= 43 && poids <= 47 ||
                taille >= 145 && taille < 166 && poids >= 48 && poids <= 53 ||
                taille >= 145 && taille < 163 && poids >= 54 && poids <= 59 ||
                taille >= 145 && taille < 160 && poids >= 60 && poids <= 65)
            {
                Console.WriteLine("Prennez la taille 1.\n");
            }
            else if (taille >= 166 && taille < 183 && poids >= 48 && poids <= 53 ||
                    taille >= 163 && taille < 178 && poids >= 54 && poids <= 59 ||
                    taille >= 145 && taille < 175 && poids >= 60 && poids <= 65 ||
                    taille >= 145 && taille < 172 && poids >= 66 && poids <= 71)
            {
                Console.WriteLine("Prennez la taille 2.\n");
            }
            else if (taille >= 178 && taille <= 183 && poids >= 54 && poids <= 59 ||
                         taille >= 175 && taille <= 183 && poids >= 60 && poids <= 65 ||
                         taille >= 172 && taille <= 183 && poids >= 66 && poids <= 71 ||
                         taille >= 163 && taille <= 183 && poids >= 72 && poids <= 77)
            {
                Console.WriteLine("Prennez la taille 3.\n");
            }
            else
            {
                Console.WriteLine("Aucune taille ne vous correspond.\n");
            }

            Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
            Console.Read();
        }
    }
}

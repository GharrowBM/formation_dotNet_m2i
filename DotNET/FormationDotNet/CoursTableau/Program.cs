using System;

namespace CoursTableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region création de tableau
            int[] tabAvecValeur = new int[] { 10, 3 };
            int[] tabEntier = new int[10];
            //Pour afficher le contenu d'un tableau avec une boucle for
            for(int i = 0; i < tabEntier.Length; i++)
            {
                tabEntier[i] = (i+1)*2;
               // Console.WriteLine(tabEntier[i]);
            }
            //Afficher le tableau avec la boucle foreach
            foreach(int element in tabEntier)
            {
                Console.WriteLine(element);
            }
            #endregion
        }
    }
}

﻿using System;

namespace CoursTableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region création de tableau
            int[] tabEntier = new int[10];
            //Pour afficher le contenu d'un tableau avec une boucle for
            for(int i = 0; i < tabEntier.Length; i++)
            {
                tabEntier[i] = (i+1)*2;
                Console.WriteLine(tabEntier[i]);
            }
            #endregion
        }
    }
}

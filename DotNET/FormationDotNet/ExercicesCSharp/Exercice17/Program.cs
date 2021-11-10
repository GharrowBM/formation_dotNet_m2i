using System;

namespace Exercice17
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Déclaration variable
            string choix;
            #endregion

            #region Récupération choix utilisateur
            Console.WriteLine("--- Quelle boisson souhaitez-vous?\n");
            Console.WriteLine("Liste des boissons disponibles :");
            Console.WriteLine("\t1)Eau Plate");
            Console.WriteLine("\t2)Eau Gazeuse");
            Console.WriteLine("\t3)Coca-Cola");
            Console.WriteLine("\t4)Fanta");
            Console.WriteLine("\t5)Sprite");
            Console.WriteLine("\t6)Orangina");
            Console.WriteLine("\t7)7Up");
            Console.Write("Faites votre choix (1 à 7) : ");
            choix = Console.ReadLine();
            #endregion

            #region Switch pour tester la saisie utilisateur et afficher le résultat
            Console.WriteLine("");
            switch (choix)
            {
                case "1": Console.WriteLine("Votre eau plate est servie...\n"); break;
                case "2": Console.WriteLine("Votre eau gazeuse est servie...\n"); break;
                case "3": Console.WriteLine("Votre Coca-Cola est servi...\n"); break;
                case "4": Console.WriteLine("Votre Fanta est servi...\n"); break;
                case "5": Console.WriteLine("Votre Sprite est servi...\n"); break;
                case "6": Console.WriteLine("Votre Orangina est servi...\n"); break;
                case "7": Console.WriteLine("Votre 7Up est servi...\n"); break;
                default: Console.WriteLine("Mauvais choix !\n"); break;
            }
            #endregion

            Console.WriteLine("Appuyez sur enter pour fermer le programme...");
            Console.Read();
        }
    }
}

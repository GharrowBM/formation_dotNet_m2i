using System;

namespace Exercice10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- La lettre est-elle une voyelle ? --- \n");

            #region Avec strcture If-Else et Char
            Console.Write("Entrez une lettre : ");
            char lettre = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

            if (lettre == 'A' || lettre == 'E' || lettre == 'I' || lettre == 'O' || lettre == 'U' || lettre == 'Y')
                Console.WriteLine("Cette lettre est une voyelle !\n");
            else
                Console.WriteLine("Cette lettre est une consonne !\n");

            #endregion

            #region Avec contains            
            Console.Write("Entrez une lettre : ");
            string letter = Console.ReadLine().ToUpper();
            string chaine = "AEIOUY";
            if(letter.Length == 1)
            {
                if (chaine.Contains(lettre))
                    Console.WriteLine("Cette lettre est une voyelle !\n");
                else
                    Console.WriteLine("Cette lettre est une consonne !\n");
            }
            else
            {
                Console.WriteLine("Veuillez saisir une seule lettre!\n");
            }
            #endregion
        }
    }
}

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
            char lettre = Convert.ToChar(Console.ReadLine().ToUpper());

            if (lettre == 'A' || lettre == 'E' || lettre == 'I' || lettre == 'O' || lettre == 'U' || lettre == 'Y')
                Console.WriteLine("Cette lettre est une voyelle !\n");
            else
                Console.WriteLine("Cette lettre est une consonne !\n");

            #endregion

            #region Avec contains            

            string chaine = "AEIOUY";
            string resultat;

            resultat = chaine.Contains(lettre) ? "Cette lettre est une voyelle !\n" : "Cette lettre est une consonne !\n";

            Console.WriteLine(resultat);
            #endregion
        }
    }
}

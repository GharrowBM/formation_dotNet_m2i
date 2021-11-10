using System;

namespace MethodeTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string chaine = "20";


            #region Avec type Int
            //string affichage = "";
            //int age;

            //if (int.TryParse(chaine, out age))
            //{
            //    Console.WriteLine("La convertion a réussie, age vaut {0}", age);
            //}
            //else
            //{
            //    Console.WriteLine("La convertion a echouée");
            //}

            //Sugar Syntaxe
            //affichage = int.TryParse(chaine, out age) ? $"La convertion a réussie, age vaut {age}" : "La convertion à echouée";
            //Console.WriteLine(affichage);
            #endregion


            #region Avec type double
            //double nb;

            if (double.TryParse(chaine, out double nb))
                Console.WriteLine("La convertion a réussie, age vaut {0}", nb);
            else
                Console.WriteLine("La convertion a echouée");


            Console.WriteLine(nb);
            #endregion


        }
    }
}

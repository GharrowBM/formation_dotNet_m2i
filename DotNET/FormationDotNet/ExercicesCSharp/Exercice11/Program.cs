using System;

namespace Exercice11
{
    class Program
    {
        static void Main(string[] args)
        {

            //#region Version If...Else Simple
            //Console.WriteLine("--- Le nombre est-il divisible par...? --- \n");

            //Console.Write("Entrez un chiffre/nombre entier : ");
            //int nombre = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Entrez le chiffre/nombre diviseur : ");
            //int diviseur = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(" ");

            //if (diviseur != 0)
            //{
            //    if (nombre % diviseur == 0)
            //        Console.WriteLine($"Le chiffre/nombre { nombre } est divisible par { diviseur }\n");
            //    else
            //        Console.WriteLine($"Le chiffre/nombre { nombre } n'est pas divisible par { diviseur }\n");
            //}
            //else
            //    Console.WriteLine($"Division par { diviseur } impossible \n");
            //#endregion


            #region Version If...Else Imbriquées
            string resultat;
            Console.WriteLine("--- Le nombre est-il divisible par...? --- \n");
            Console.Write("Entrez un chiffre/nombre entier : ");
            int nombre1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entrez le chiffre/nombre diviseur : ");
            int diviseur1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            if (diviseur1 != 0)
            {
                if (nombre1 > 9)
                {
                    if (nombre1 % diviseur1 == 0)
                        resultat = $"Le nombre { nombre1 } est divisible par { diviseur1 }\n";
                    else
                        resultat = $"Le nombre { nombre1 } n'est pas divisible par { diviseur1 }\n";
                }
                else
                {
                    if (nombre1 % diviseur1 == 0)
                        resultat = $"Le chiffre { nombre1 } est divisible par { diviseur1 }\n";
                    else
                        resultat = $"Le chiffre { nombre1 } n'est pas divisible par { diviseur1 }\n";
                }
                Console.WriteLine(resultat);
            }
            else
            {
                Console.WriteLine($"Division par { diviseur1 } impossible \n");
            }
            #endregion
        }
    }
}

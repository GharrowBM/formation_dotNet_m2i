using System;

namespace Exercice9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Calcul des intérêts --- \n");
            Console.Write("Entrez Capital de départ (en Euros) : ");
            double capitalDepart = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez le taux d'intérêt (en %) : ");
            double tauxIntéret = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Entrez la durée de l'épargne (en années) : ");
            double duree = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            double capitalFinal = Math.Round(capitalDepart * Math.Pow(1 + (tauxIntéret / 100), duree),2);
            double interets = Math.Round(capitalFinal - capitalDepart,2);
            Console.WriteLine("Le montant des intérêts sera de " + interets + " Euros après " + duree + " ans");
            Console.WriteLine("Le capital final sera de " + capitalFinal + " Euros\n");
            
            Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
            Console.Read();
        }
    }
}

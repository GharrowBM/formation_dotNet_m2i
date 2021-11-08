using System;

namespace Exercice04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Veuillez saisir votre nom : ");
            string nom = Console.ReadLine();
            Console.Write("Veuillez saisir votre prénom : ");
            string prenom = Console.ReadLine();
            Console.Write("Veuillez saisir votre âge : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bonjour " + prenom + " " + nom + ", vous avez " + age + " ans\n");
            Console.WriteLine($"Bonjour {prenom} {nom} ,vous avez {age} ans\n");
            Console.WriteLine("Bonjour {0} {1} ,vous avez {2} ans\n",prenom,nom,age);
            
        }
    }
}

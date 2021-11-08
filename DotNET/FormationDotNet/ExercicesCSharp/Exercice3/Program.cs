using System;

namespace Exercice03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Veuillez saisir votre nom : ");
            string nom = Console.ReadLine();
            Console.Write("Veuillez saisir votre prénom : ");
            string prenom = Console.ReadLine();
            Console.WriteLine("Bonjour " + prenom + " " + nom + "\n");
            Console.WriteLine($"Bonjour {prenom} {nom} \n");
            Console.WriteLine("Bonjour {0} {1} \n", prenom, nom);
        }
    }
}

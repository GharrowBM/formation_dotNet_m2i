using System;

namespace Exercice28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre = 0;
            Random r = new Random();
            int count = 0;
            int nbMystere = r.Next(1, 51);
            while (nombre != nbMystere)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Merci de saisir un nombre : ");
                nombre = Convert.ToInt32(Console.ReadLine());
                if(nombre > nbMystere)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Plus petit");
                    count++;
                }
                else if(nombre < nbMystere)
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Plus grand");
                    count++;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Bravo ! en {count} essai");
        }
    }
}

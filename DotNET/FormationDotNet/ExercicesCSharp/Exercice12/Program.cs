using System;

namespace Exercice12
{
    class Program
    {
        static void Main(string[] args)
        {
            // if...else imbriquées
            Console.WriteLine("--- Dans quelle catégorie mon enfant est-il...? --- \n");
            Console.Write("Entrez l'âge de votre enfant : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            if (age < 3)
            {
                Console.WriteLine("Votre enfant est trop jeune pour pratiquer !\n");
            }            
            else
            {
                if (age >= 3 && age <= 6)
                {
                    Console.WriteLine("Votre enfant est dans la catégorie \"Baby\" !\n");
                }
                else
                {
                    if (age >= 7 && age <= 8)
                    {
                        Console.WriteLine("Votre enfant est dans la catégorie \"Poussin\" !\n");
                    }
                    else
                    {
                        if (age >= 9 && age <= 10)
                        {
                            Console.WriteLine("Votre enfant est dans la catégorie \"Pupille\" !\n");
                        }
                        else
                        {
                            if (age >= 11 && age <= 12)
                            {
                                Console.WriteLine("Votre enfant est dans la catégorie \"Minime\" !\n");
                            }
                            else
                            {
                                if (age >= 13 && age <= 17)
                                {
                                    Console.WriteLine("Votre enfant est dans la catégorie \"Cadet\" !\n");
                                }
                                else
                                    Console.WriteLine("Mais ce n'est plus un enfant !\n");
                            }
                        }
                    }
                }
            }


            Console.WriteLine("Appuyez sur Enter pour fermer le programme...");
            Console.Read();
        }
    }
}

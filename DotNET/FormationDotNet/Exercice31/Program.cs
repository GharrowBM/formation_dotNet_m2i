using System;

namespace Exercice31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double note, max = 0, min = 0, somme = 0;
            int nombre = 0;

            string choix;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1- Saisir les notes");
                Console.WriteLine("2- La plus grande note");
                Console.WriteLine("3- La plus petite note");
                Console.WriteLine("4- La moyenne");
                Console.WriteLine("0- Quitter");
                Console.Write("Merci de saisir votre choix : ");
                choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        do
                        {
                            Console.Write("Merci de saisir une note : ");
                            note = Convert.ToDouble(Console.ReadLine());
                            if (note >= 0 && note <= 20)
                            {

                                nombre++;
                                somme += note;
                                if (nombre == 1)
                                {
                                    min = note;
                                    max = note;
                                }
                                else
                                {
                                    if (note > max)
                                    {
                                        max = note;
                                    }
                                    else if (note < min)
                                    {
                                        note = min;
                                    }
                                }
                            }
                            else if (note != 999)
                            {
                                Console.WriteLine("Merci de saisir une note entre 0 et 20");
                            }
                        } while (note != 999);
                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"La note max est de {max}");
                        break;
                    case "3":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"La note min est de {min}");
                        break;
                    case "4":
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"La note moyenne est de {somme / nombre}");
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Merci de choisir un menu ");
                        break;
                }
            } while (choix != "0");
        }
    }
}

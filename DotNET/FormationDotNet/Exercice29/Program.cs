using System;

namespace Exercice29
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double note, max = 0, min = 0, somme = 0;
            int nombre = 0;
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
                else if(note != 999)
                {
                    Console.WriteLine("Merci de saisir une note entre 0 et 20");
                }
            } while (note != 999);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"La note max est de {max}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"La note min est de {min}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"La note moyenne est de {somme/nombre}");


        }
    }
}

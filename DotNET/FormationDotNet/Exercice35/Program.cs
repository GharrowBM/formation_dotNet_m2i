using System;

namespace Exercice35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taille;
            int nbContacts = 0;
            Console.Write("Merci de saisir la taille du tableau : ");
            taille = Convert.ToInt32(Console.ReadLine());
            string[] contacts = new string[taille];

            string choix;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1- Saisir un contact");
                Console.WriteLine("2- Afficher la liste des contacts");
                Console.WriteLine("0- Quitter");
                Console.Write("Merci de saisir votre choix : ");
                choix = Console.ReadLine();
                Console.Clear();
                switch (choix)
                {
                    case "1":
                        if(nbContacts < contacts.Length)
                        {
                            Console.Write("Merci de saisir les informations du contact : ");
                            contacts[nbContacts++] = Console.ReadLine();
                            //nbContacts++;
                        }
                        else
                        {
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.WriteLine("Le tableau est plein");
                        }
                        break;
                    case "2":
                        foreach(string contact in contacts)
                        {
                            Console.WriteLine(contact);
                        }
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

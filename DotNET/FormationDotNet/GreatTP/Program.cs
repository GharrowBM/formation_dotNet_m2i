using System;

namespace GreatTP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); 
            string[] basePerson = new string[] { "toto", "tata", "titi", "minet" };
            string[] personsSelected = new string[basePerson.Length];
            //string[] personToSelect = new string[basePerson.Length];
            //for(int i = 0; i < basePerson.Length; i++)
            //{
            //    personToSelect[i] = basePerson[i];
            //}

            string choix;
            do
            {
                
                Console.WriteLine("1-Effecuter un tirage");
                Console.WriteLine("2-Afficher les personnes déjà selectionnées");
                Console.WriteLine("3-Afficher les personnes non selectionnées");
                Console.WriteLine("0-Quitter");
                choix = Console.ReadLine();
                Console.Clear();
                switch (choix)
                {
                    case "1":
                        bool canSelect = false;
                        foreach(string element in basePerson)
                        {
                            if(element !=null)
                            {
                                canSelect = true;
                                break;
                            }
                        }
                        if(canSelect)
                        {
                            string personSelected = null;
                            int index = 0;
                            while (personSelected == null)
                            {
                                index = random.Next(basePerson.Length);
                                personSelected = basePerson[index];
                            }
                            
                            personsSelected[index] = personSelected;
                            basePerson[index] = default(string);
                            Console.WriteLine($"La personne qui doit corriger est {personSelected}");
                        }
                        else
                        {
                            Console.WriteLine("Aucune personne à selectionner, vous pouvez recommencer");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Les personnes déjà selectionnées sont : ");
                        foreach(string element in personsSelected)
                        {
                            if(element != null)
                            Console.WriteLine(element);
                        }
                        break;
                    case "3":
                        Console.WriteLine("Les personnes non selectionnées sont : ");
                        foreach (string element in basePerson)
                        {
                            if(element != null)
                            Console.WriteLine(element);
                        }
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                }
            }while(choix != null);

        }
    }
}

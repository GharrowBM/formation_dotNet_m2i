using System;

namespace BoucleWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region cours boucle while
            //bool test = false;
            ////Exemple boucle infini
            //while(!test)
            //{
            //    Console.WriteLine("Test est faux");
            //}
            //Exemple boucle while avec un nombre
            int nombre = -1;
            while (nombre > 0)
            {
                Console.WriteLine(nombre);
                nombre--;
            }

            //string choix = null;
            ////choix = Console.ReadLine();
            //while(choix != "stop")
            //{
            //    Console.Write("Merci de saisir un nombre : ");
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(n);
            //    Console.Write("On continue ? ");
            //    choix = Console.ReadLine();
            //}
            //Version do while

            nombre = -1;
            do
            {
                Console.WriteLine(nombre);
                nombre--;
            }while (nombre > 0);
            #endregion
            
        }
    }
}

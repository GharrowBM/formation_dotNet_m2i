using System;
// using System.Text;

namespace AffichageConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Les Commentaires
            //// Commentaire simple (la fin de ligne n'est plus prise en compte)

            ///*
            // * Commentaire Multilignes
            // */

            ///// Commentaire pour la documentation
            #endregion

            #region Affichage dans la console
            //Console.Write("Hello");
            //Console.Write(" World!");
            //Console.Write("How Are u?");

            //Console.WriteLine("Je retourne à la ligne");
            //Console.WriteLine("La preuve!");
            //Console.Write("Hello");

            #endregion

            #region Lecture saisies utilisateur
            // Lire un caracteere dans la console
            // Console.Read();
            // char @char = (char)Console.Read();

            // Lire une une chaîne de caracteres
            // string chaine = Console.ReadLine();

            // Lire une valeur Numérique
            //Console.WriteLine("Merci de saisir une valeur numérique : ");
            //int valeur = Convert.ToInt32(Console.ReadLine());

            #endregion

            #region Changement de couleur de la police dans la console
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Je suis en vert");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Je suis en rouge");
            //Console.ForegroundColor = ConsoleColor.Gray;
            //Console.WriteLine("Je suis en gray");
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("Je suis en blanc");
            #endregion

            #region Les Caractères Spéciaux
            //// Affichage d'un chemin dans la console
            //Console.WriteLine("c:\\repertoire\\MonFichier.cs");
            //Console.WriteLine(@"c:\repertoire\MonFichier.cs");

            //// Le \ devant "
            //Console.WriteLine("Bonjour, je m'appel \"Anthony\"");

            //// Le \n pour un retour à la ligne
            //Console.Write("Je saute une ligne après \n");
            //Console.WriteLine("Je saute deux ligne après \n");

            //// Le \t pour les tabulation
            //Console.WriteLine("Liste de choses à faire : ");
            //Console.WriteLine("\t - Apprendre le C# ");
            //Console.WriteLine("\t - Faire des exercices ");
            //Console.WriteLine("\t\t - J'ai deux tabulations ");

            //// Pour afficher les caractères spéciaux de l'UTF-8
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine("€uro");
            #endregion

            #region Affichage de la date et l'heure
            DateTime date = DateTime.Now;
            //Console.WriteLine(date);
            Console.WriteLine("Date et Heure : {0:d} at {0:t}",date);
            #endregion

        }
    }
}

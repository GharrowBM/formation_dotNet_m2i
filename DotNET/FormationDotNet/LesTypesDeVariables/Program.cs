using System;

namespace LesTypesDeVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Les Chaînes de caractères
            //// Variables de type string (Chaînes de caractères)
            //string nom;
            //nom = "Anthony";
            string nom2 = "Sébastien";

            //// Modifie la valeur de nom en donnant celle de nom2
            //nom = nom2;
            //// Je modifie la valeur de nom2
            //nom2 = "Toto";

            //// LEs variable stri,g contiennent leur propre copie des valeures
            //Console.WriteLine(nom);
            //Console.WriteLine(nom2);
            #endregion

            #region Les variables numériques
            //// Déclaration d'une variable de type integer (entier) et initialisation
            //int age;
            //age = 42;
            ////Déclaration et initialisation
            //int age2 = 23;

            //age = age2;
            //age2 = 30;

            //age = Convert.ToInt32(Console.ReadLine());

            //// Affichage des valeures
            //Console.WriteLine(age);
            //Console.WriteLine(age2);
            #endregion

            #region Les Variables de type Objet
            // Déclaration d'une variable de type objet
            object nomObjet;

            // Initialisation de la valeur
            nomObjet = "Ma chaine Objet";

            // Affichage
            Console.WriteLine(nomObjet);
            Console.WriteLine(nomObjet.GetType());
            #endregion
        }
    }
}

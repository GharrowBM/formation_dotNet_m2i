using System;

namespace LeBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Déclaration d'une variable de type objet et boxing de i dans o
            int i = 123;
            // Boxing
            object o = i;
            #endregion

            #region Unboxing de o dans i
            o = 456;
            //Console.WriteLine(o.GetType());
            // Unboxing
            i = (int)o;
            Console.WriteLine(i);
            #endregion

            #region Convertion de type objet
            // 1 ere solution Boxing => Unboxing
            // Avant la convertion, vérication du type de l'objet
            Console.WriteLine(o.GetType());
            // Unboxing
            i = (int)o;


            //// 2eme solution => utilisation du mot clé "as" pour effectuer la convertion
            int? autreInteger = o as int?;
            Console.WriteLine("Avec le mot clé \"as\" " + autreInteger);

            // 3eme solution => En utilisant le mot clé "is" pour effectuer la convertion
            if (o is int monInt)
            {
                Console.WriteLine("Avec le mot clé \"is\" " + monInt);
            }

            #endregion
        }
    }
}

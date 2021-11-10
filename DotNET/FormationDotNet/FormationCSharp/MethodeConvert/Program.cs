using System;

namespace MethodeConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Convertion d'une string en int avec Convert()
            string nombre = "20";
            int @int = Convert.ToInt32(nombre);
            Console.WriteLine("La convertion d'un string en int avec convert : " + @int);
            // Cette méthode ne permet de convertir que les cjaine de caractere sémantiquement proche

            #endregion

            #region Limites de la méthode convert
            //// Caster une string non numérique en une variable int (provoque une erreur de compilation!!!)
            //string chaine = "ABC";
            //int @int2 = Convert.ToInt32(chaine);
            //Console.WriteLine("La convertion d'un string (non numerique en int avec convert : " + @int);

            #endregion
        }
    }
}

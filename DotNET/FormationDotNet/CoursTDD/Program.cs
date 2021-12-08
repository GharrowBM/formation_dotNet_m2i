using System;

namespace CoursTDD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(new CalaculatriceTest().TestAddition())
            {
                Console.WriteLine("La fonction addition fonctionne");
            }else
            {
                Console.WriteLine("Erreur dans le code de la fonction addition");
            }
        }
    }
}

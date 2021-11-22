using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursPOO.Classes
{
    public class Calculatrice
    {
        //public delegate double methodeCalcule(double a, double b);

        //public void Calculer(double a, double b, methodeCalcule methode)
        //{
        //    Console.WriteLine(methode(a, b));
        //}

        public void Calculer(double a, double b, Func<double,double,double> methode)
        {
            Console.WriteLine(methode(a, b));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTDD
{
    internal class CalaculatriceTest
    {
        public bool TestAddition()
        {
            Calculatrice calculatrice = new Calculatrice();
            double result = calculatrice.Addition(10, 30);
            return result == 40;
        }
    }
}

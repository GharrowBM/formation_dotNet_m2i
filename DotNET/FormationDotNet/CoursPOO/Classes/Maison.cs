using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursPOO.Classes
{
    internal class Maison<T>
    {
        T[] elements;

        public Maison()
        {
            elements = new T[10];
        }

    }
}

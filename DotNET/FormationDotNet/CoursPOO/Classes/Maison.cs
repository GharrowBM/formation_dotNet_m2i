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
        private int compteur = 0;
        public Maison()
        {
            elements = new T[10];
        }

        public void Ajouter(T element)
        {

        }

    }
}

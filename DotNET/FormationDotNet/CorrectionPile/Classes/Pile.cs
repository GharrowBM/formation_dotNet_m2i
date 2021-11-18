using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionPile.Classes
{
    internal class Pile<T>
    {
        private T[] elements;
        private int compteur;

        public Pile(int t)
        {
            elements = new T[t];
            compteur = 0;
        }

        public bool Empiler(T element)
        {
            if(compteur < elements.Length)
            {
                elements[compteur++] = element;
                return true;
            }
            return false;
        }

        public bool Depiler()
        {
            if(compteur > 0)
            {
                elements[--compteur] = default(T);
                return true;
            }
            return false ;
        }

        public T GetElement(int index)
        {
            if(index >= 0 && index < elements.Length)
            {
                return elements[index];
            }
            return default(T);
        }
    }
}

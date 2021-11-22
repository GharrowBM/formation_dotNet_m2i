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

        public T Search(Func<T, bool> searchMethod)
        {
            T element = default(T);
            foreach(T t in elements)
            {
                if(searchMethod(t))
                {
                    element = t;
                    break;
                }
            }

            return element;
        }

        public List<T> SearchAll(Func<T, bool> searchMethod)
        {
            List<T> list = new List<T>();
            
            foreach (T t in elements)
            {
                if (searchMethod(t))
                {
                    list.Add(t);
                }
            }

            return list;
        }
    }
}

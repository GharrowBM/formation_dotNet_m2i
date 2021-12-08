using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEnTDD.Classes
{
    public class Tools<T>
    {
        private Random random = new Random();
        public T[] Shuffle(T[] tab)
        {
            
           T[] t = new T[tab.Length];
            for (int i = 0; i < tab.Length; i++)
            {
                int indexTmp = random.Next(0, tab.Length);
                T tTmp = tab[indexTmp];
                tab[indexTmp] = tab[i];
                tab[i] = tTmp;
                t[i] = tab[i];
            }
            return t;
        }
    }
}

using CorrectionPile.Classes;
using System;

namespace CorrectionPile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pile<string> pileString = new Pile<string>(4);
            pileString.Empiler("test1");
            pileString.Empiler("test2");
            pileString.Empiler("test5");
            pileString.Empiler("test4");
            pileString.Depiler();
            pileString.Empiler("test5");

            Pile<int> pileInt = new Pile<int>(5);

        }
    }
}

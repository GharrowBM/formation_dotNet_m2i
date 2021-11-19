using System;
using CoursPOO.Interfaces;

namespace CoursPOO
{
    public class Oiseau : IVolant
    {
        public Oiseau()
        {
        }

        public void Atterrir()
        {
            Console.WriteLine("Oiseau qui atterrit");
        }

        public void Decoller()
        {
            Console.WriteLine("Oiseau qui décolle");
        }

        public void Voler()
        {
            Console.WriteLine("Oiseau qui vole");
        }
    }
}

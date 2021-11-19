using System;
using CoursPOO.Interfaces;

namespace CoursPOO.Classes
{
    public class Carre : Figure, IDeformable
    {
        private double cote;
        public Carre(double pX, double pY, double c) : base(pX, pY)
        {
            cote = c;
        }

        public override void Afficher()
        {
            Console.WriteLine($"carré de centre ({posX}, {posY}) et de coté {cote}");
        }

        public Figure Deformation(double coeffH, double coeffV)
        {
            if(coeffH != coeffV)
            {
                return new Rectangle(posX, posY, cote * coeffH, cote * coeffV);
            }
            return new Carre(posX, posY, cote * coeffV);
        }
    }
}

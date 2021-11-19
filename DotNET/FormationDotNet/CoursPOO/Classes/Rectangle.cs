using System;
using CoursPOO.Interfaces;

namespace CoursPOO.Classes
{
    public class Rectangle: Figure, IDeformable
    {
        private double largeur;
        private double longueur;
        public Rectangle(double pX, double pY, double largeur, double longueur) : base(pX, pY)
        {
            this.largeur = largeur;
            this.longueur = longueur;
        }

        public override void Afficher()
        {
            Console.WriteLine($"Rectange de centre ({posX}, {posY}) et de largeur {largeur} et de longueur {longueur}");
        }

        public Figure Deformation(double coeffH, double coeffV)
        {
            if(coeffH * largeur == coeffV * longueur)
            {
                return new Carre(posX, posY, coeffH * largeur);
            }
            //return default(Figure);
            return new Rectangle(posX, posY, coeffH * largeur, coeffV * longueur);
        }
    }
}

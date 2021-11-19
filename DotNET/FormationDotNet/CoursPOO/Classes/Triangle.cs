using System;
namespace CoursPOO.Classes
{
    public class Triangle:Figure
    {
        private double baseTriangle;
        private double hauteurTriangle;
        public Triangle(double pX, double pY, double h, double b) : base(pX, pY)
        {
            hauteurTriangle = h;
            baseTriangle = b;
        }

        public override void Afficher()
        {
            Console.WriteLine($"Triangle de centre ({posX}, {posY}) et de base {baseTriangle} et de hauteur {hauteurTriangle}");
        }
    }
}

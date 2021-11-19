using System;
namespace CoursPOO.Classes
{
    public abstract class Figure
    {
        protected double posX;
        protected double posY;
        public Figure(double pX, double pY)
        {
            posX = pX;
            posY = pY;
        }
        public abstract void Afficher();
    }
}

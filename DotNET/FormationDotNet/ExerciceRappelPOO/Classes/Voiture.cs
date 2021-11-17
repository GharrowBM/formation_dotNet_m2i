using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceRappelPOO.Classes
{
    internal class Voiture : VehiculeAMoteur
    {
        public Voiture(string model, string marque, double volumeInitial) : base(model, marque, volumeInitial)
        {
            
        }

        public void Rouler(double volume)
        {

            if(!MoteurV.Demarre)
            {
                Demarrer();
            }
            MoteurV.Utiliser(volume);
        }
    }
}

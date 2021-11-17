using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceRappelPOO.Classes
{
    internal class Moteur
    {
        private double volumeReservoir;
        private double volumeTotal;
        private bool demarre;

        public double VolumeReservoir { get => volumeReservoir; set => volumeReservoir = value; }
        public double VolumeTotal { get => volumeTotal; set => volumeTotal = value; }
        public bool Demarre { get => demarre; set => demarre = value; }


        public bool Demarrer()
        {
            if(!Demarre && volumeReservoir > 0.1)
            {
                Console.WriteLine("Le moteur démarre...");
                volumeReservoir -= 0.1;
                Demarre = true;
                return true;
            }
            return false;
        }

        public bool Arreter()
        {
            Demarre = false;
            Console.WriteLine("Le moteur s'arrete...");
            return true;
        }
        public void Utiliser(double volume)
        {
            if(volumeReservoir >= volume)
            {
                Console.WriteLine($"Le moteur utilise {volume} pour le trajet");
                volumeReservoir -= volume;
            }
            else
            {
                Console.WriteLine($"Le moteur utilisera {volumeReservoir} et vous serez en panne d'essence avec {volume - VolumeReservoir} nécessaires");
                VolumeReservoir = 0;
                Demarre=false;
            }
        }

        public void FaireLePlein(double volume)
        {
            VolumeReservoir += volume;
            VolumeTotal += volume;
            Console.WriteLine($"Le moteur fait le plein avec {volume}");
        }
    }
}

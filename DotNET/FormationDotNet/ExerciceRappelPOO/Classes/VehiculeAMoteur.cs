using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceRappelPOO.Classes
{
    internal abstract class VehiculeAMoteur : Vehicule
    {
        private Moteur moteurV;

        

        public  Moteur MoteurV { get => moteurV; set => moteurV = value; }

        public override bool Demarrer()
        {
            return MoteurV.Demarrer();
        }

        public override void  Arreter()
        {
            MoteurV.Arreter();
        }

        public override void FaireLePlein(double volume)
        {
            MoteurV.Arreter();
            MoteurV.FaireLePlein(volume);
            MoteurV.Demarrer();
        }

        protected VehiculeAMoteur(string model, string marque, double volumeInitial) : base(model, marque)
        {
            MoteurV = new Moteur();
            MoteurV.VolumeReservoir = volumeInitial;
            MoteurV.VolumeTotal = volumeInitial;    
        }
    }
}

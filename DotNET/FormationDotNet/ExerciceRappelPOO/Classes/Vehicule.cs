using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceRappelPOO.Classes
{
    internal abstract class Vehicule
    {
        private string model;
        private string marque;

        protected Vehicule(string model, string marque)
        {
            Model = model;
            Marque = marque;
        }

        public string Model { get => model; set => model = value; }
        public string Marque { get => marque; set => marque = value; }

        public abstract bool Demarrer();

        public abstract void Arreter();

        public abstract void FaireLePlein(double volume);
    }
}

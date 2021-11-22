using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionPile.Classes
{
    internal class Voiture
    {
        private string model;

        public Voiture(string model)
        {
            Model = model;
        }

        public string Model { get => model; set => model = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWPF.Classes
{
    public class Voiture
    {
        private string marque;
        private string model;

        public string Marque { get => marque; set => marque = value; }
        public string Model { get => model; set => model = value; }

        public override string ToString()
        {
            return $"Model : {Model}, Marque : {Marque}";
        }
    }
}

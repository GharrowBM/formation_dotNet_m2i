using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursEFCore.Classes
{
    public class Ecole
    {
        private int id;

        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public virtual List<Formateur> Formateurs { get; set; }

        public Ecole()
        {
            Formateurs = new List<Formateur>();
        }
    }
}

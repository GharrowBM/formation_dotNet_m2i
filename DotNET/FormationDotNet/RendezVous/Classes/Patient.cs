using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendezVous.Classes
{
    public class Patient
    {
        private int id;
        private string nom;
        private string prenom;
        private string email;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }

        public virtual List<RendezVous> RendezVous { get; set; }

        public Patient()
        {
            RendezVous = new List<RendezVous>();
        }
    }
}

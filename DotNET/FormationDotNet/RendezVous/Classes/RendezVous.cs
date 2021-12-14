using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendezVous.Classes
{
    public class RendezVous
    {
        private int id;
        private DateTime dateEtHeure;

        public int Id { get => id; set => id = value; }
        public DateTime DateEtHeure { get => dateEtHeure; set => dateEtHeure = value; }

        public int PatientId { get; set; }
        
        [ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }


    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CorrectionPetiteAnnonce.Models
{
    public class Annonce
    {
        private int id;
        private string titre;
        private string description;
        private decimal prix;

        public int Id { get => id; set => id = value; }
        public string Titre { get => titre; set => titre = value; }
        
        [DataType(DataType.Text)]
        public string Description { get => description; set => description = value; }
        public decimal Prix { get => prix; set => prix = value; }

        public virtual List<Image> Images { get; set; }

        public Annonce()
        {
            Images = new List<Image>();
        }
    }
}

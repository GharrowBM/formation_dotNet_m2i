using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseEnregistreuse.Classes
{
    public class ProduitVente
    {
        private int id;

        private int venteId;

        private int produitId;

        private int qty;

        public int Id { get => id; set => id = value; }
        public int VenteId { get => venteId; set => venteId = value; }
        public int ProduitId { get => produitId; set => produitId = value; }
        public int Qty { get => qty; set => qty = value; }

        [ForeignKey("VenteId")]
        public virtual Vente Vente { get; set; }

        [ForeignKey("ProduitId")]
        public virtual Produit Produit { get; set; }
    }
}

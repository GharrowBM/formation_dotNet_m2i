using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaireVersion1.Classes
{
    internal class Operation
    {
        private decimal montant;
        private DateTime dateEtheureOperation;

        public decimal Montant { get => montant;  }
        public DateTime DateEtheureOperation { get => dateEtheureOperation; }

        public Operation(decimal montant)
        {
            this.montant = montant;
            this.dateEtheureOperation = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Montant : {Montant}, Date de l'opération : {DateEtheureOperation}";
        }
    }
}

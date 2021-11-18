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

        public decimal Montant { get => montant; set => montant = value; }
        public DateTime DateEtheureOperation { get => dateEtheureOperation; set => dateEtheureOperation = value; }

        public Operation(decimal montant, DateTime dateEtheureOperation)
        {
            Montant = montant;
            DateEtheureOperation = dateEtheureOperation;
        }
    }
}

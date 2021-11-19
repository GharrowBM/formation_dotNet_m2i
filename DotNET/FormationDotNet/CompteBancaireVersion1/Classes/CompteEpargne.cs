using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaireVersion1.Classes
{
    internal class CompteEpargne : Compte
    {
        private decimal tauxInteret = 2;

        public bool CalculeInteret()
        {
            Operation operation = new Operation(Solde * tauxInteret / 100);
            return Depot(operation);
        }
    }
}

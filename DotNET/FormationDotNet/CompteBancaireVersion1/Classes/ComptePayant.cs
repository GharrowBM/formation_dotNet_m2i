using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaireVersion1.Classes
{
    internal class ComptePayant : Compte
    {
        private static decimal coutOperation = 2;

        public override bool Depot(Operation operation)
        {
            if(operation.Montant >= 2)
            {
                if(base.Depot(operation))
                {
                    return base.Retrait(new Operation(coutOperation * -1));
                }
            }
            return false;
        }

        public override bool Retrait(Operation operation)
        {
            if(Solde > (operation.Montant* -1) + coutOperation)
            {
                if(base.Retrait(operation))
                {
                    return base.Retrait(new Operation(coutOperation * -1));
                }
            }
            return false;
        }
    }
}

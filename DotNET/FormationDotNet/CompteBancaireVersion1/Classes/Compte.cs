using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaireVersion1.Classes
{
    internal class Compte
    {
        private int id;
        private decimal solde;
        private Client client;
        private List<Operation> operations;
        private static int compteur = 0;
        public int Id { get => id; }
        public decimal Solde { get => solde; }
        public Client Client { get => client; set => client = value; }
        public List<Operation> Operations { get => operations; }

        public Compte()
        {
            operations = new List<Operation>();
            solde = 0;
            id = ++compteur;
        }

        public bool Depot(Operation operation)
        {
            if(operation.Montant >= 0)
            {
                operations.Add(operation);
                solde += operation.Montant;
                return true;
            }
            return false;
        }

        public bool Retrait(Operation operation)
        {
            if(solde >= operation.Montant * -1)
            {
                operations.Add(operation);
                solde += operation.Montant;
                return true;
            }
            return false;
        }
    }
}

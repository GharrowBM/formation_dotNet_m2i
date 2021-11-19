using System;
using CaisseEnregistreuse.Interfaces;

namespace CaisseEnregistreuse.Classes
{
    public class PaiementEspece : IPaiement
    {
        private static int compteur = 0;
        private int reference;
        private DateTime datePaiement;
        private decimal monnaie;
        public PaiementEspece()
        {
            reference = ++compteur;
            datePaiement = DateTime.Now;
        }

        public int Reference { get => reference; }
        public DateTime DatePaiement { get => datePaiement; }
        public decimal Monnaie { get; set; }
        public bool Payer(decimal montant)
        {
            return false;
        }
    }
}

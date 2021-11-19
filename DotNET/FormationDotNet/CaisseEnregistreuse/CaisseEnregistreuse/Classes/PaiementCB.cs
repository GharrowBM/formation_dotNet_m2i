﻿using System;
using CaisseEnregistreuse.Interfaces;

namespace CaisseEnregistreuse.Classes
{
    public class PaiementCB : IPaiement
    {
        private static int compteur = 0;
        private int reference;
        private DateTime datePaiement;
        public PaiementCB()
        {
            reference = ++compteur;
            datePaiement = DateTime.Now;
        }

        public int Reference { get => reference; }
        public DateTime DatePaiement { get => datePaiement; }

        public bool Payer(decimal montant)
        {
            return false;
        }
    }
}

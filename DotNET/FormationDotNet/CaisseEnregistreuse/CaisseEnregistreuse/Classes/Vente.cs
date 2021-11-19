using System;
using System.Collections.Generic;
using CaisseEnregistreuse.Interfaces;

namespace CaisseEnregistreuse.Classes
{
    public class Vente
    {
        private static int compteur = 0; 
        private int id;
        private string etat;
        private List<Produit> produits;

        public Vente()
        {
            id = ++compteur;
            produits = new List<Produit>();
            etat = "En cours";
        }

        public string Etat { get => etat; set => etat = value; }
        public List<Produit> Produits { get => produits; set => produits = value; }

        public bool Valider(IPaiement paiement)
        {
            //A Coder
            return false;
        }
    }
}

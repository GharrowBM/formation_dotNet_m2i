using System;
using System.Collections.Generic;

namespace CaisseEnregistreuse.Classes
{
    public class Caisse
    {
        private List<Produit> produits;
        private List<Vente> ventes;
        public Caisse()
        {
            Produits = new List<Produit>();
            Ventes = new List<Vente>();
        }

        public List<Produit> Produits { get => produits; set => produits = value; }
        public List<Vente> Ventes { get => ventes; set => ventes = value; }

        public bool AjouterProduit(Produit produit)
        {
            produits.Add(produit);
            return true;
        }
    }
}

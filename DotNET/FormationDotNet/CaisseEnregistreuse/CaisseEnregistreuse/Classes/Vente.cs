using System;
using System.Collections.Generic;
using System.Linq;
using CaisseEnregistreuse.Interfaces;

namespace CaisseEnregistreuse.Classes
{
    public class Vente
    {
        //private static int compteur = 0; 
        private int id;
        private string etat;
        private List<ProduitVente> produits;
        private decimal total;

        private string typePaiement;
        public Vente()
        {
            //id = ++compteur;
            produits = new List<ProduitVente>();
            etat = "En cours";
        }

        public Vente(int id, decimal total, string etat)
        {
            Id = id;
            this.total = total;
            Etat = etat;
        }

        public string Etat { get => etat; set => etat = value; }
        public virtual List<ProduitVente> Produits { get => produits; set => produits = value; }

        public decimal Total
        {
            get
            {
                decimal total = 0;
                Produits.ForEach(p =>
                {
                    if(p.Produit != null)
                    total += p.Produit.Prix * p.Qty;
                });
                return total;
            }
        }

        public decimal TotalFromBase { get => total; set => total = value; }

        public int Id { get => id; set => id = value; }
        public string TypePaiement { get => typePaiement; set => typePaiement = value; }

        public bool Valider(IPaiement paiement)
        {
            //A Coder
            return false;
        }

        public bool AjouterProduit(Produit produit)
        {
            ProduitVente p = Produits.FirstOrDefault(p => p.Produit.Id == produit.Id);
            if(p != null)
                p.Qty++;
            else 
             Produits.Add(new ProduitVente() { Produit = produit, Qty = 1} );
            return true;
        }

        public bool SupprimerProduit(int id)
        {
            return Produits.Remove(Produits.Find(p => p.Produit.Id == id));
        }
    }
}

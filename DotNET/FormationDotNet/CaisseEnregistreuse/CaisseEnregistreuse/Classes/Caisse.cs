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
        public bool AjouterVente(Vente vente)
        {
            Ventes.Add(vente);
            return true;
        }
        public Produit RechercherProduit(int id)
        {
            //Produit produit = default(Produit);
            //foreach(Produit p in Produits)
            //{
            //    if(p.Id== id)
            //    {
            //        produit = p;
            //        break;
            //    }
            //}

            //return produit;
            return Produits.Find(x => x.Id == id);
        }
    }
}

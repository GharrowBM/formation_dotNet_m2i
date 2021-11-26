using CaisseEnregistreuse.DAO;
using CaisseEnregistreuse.Interfaces;
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
            //produits.Add(produit);
            ProduitDAO produitDAO = new ProduitDAO();
            return produitDAO.Save(produit);
        }
        public bool AjouterVente(Vente vente, IPaiement paiement)
        {
            //Ventes.Add(vente);
            VenteDAO venteDAO = new VenteDAO();
            if(venteDAO.Save(vente, paiement))
            {
                if(venteDAO.SaveVenteProduit(vente))
                {
                    ProduitDAO produitDAO = new ProduitDAO();
                    vente.Produits.ForEach(p =>
                    {
                        p.Stock--;
                        produitDAO.Update(p);
                    });
                    return true;
                }
            }
            return false;
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
           // ProduitDAO produitDAO = new ProduitDAO();
            return new ProduitDAO().GetProduit(id);
        }
    }
}

using CaisseEnregistreuse.DAO;
using CaisseEnregistreuse.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace CaisseEnregistreuse.Classes
{
    public class Caisse
    {
        private List<Produit> produits;
        private List<Vente> ventes;
        private ProduitDAO _produitDAO;
        public Caisse()
        {
            Produits = new List<Produit>();
            Ventes = new List<Vente>();
        }

        public Caisse(ProduitDAO produitDAO) : this()
        {
            _produitDAO = produitDAO;
        }

        public List<Produit> Produits { get => produits; set => produits = value; }
        public List<Vente> Ventes { get => ventes; set => ventes = value; }

        public bool AjouterProduit(Produit produit)
        {
            //produits.Add(produit);
            ProduitDAO produitDAO = _produitDAO ?? new ProduitDAO();
            return produitDAO.Save(produit);
        }
        public bool AjouterVente(Vente vente, IPaiement paiement)
        {
            bool result = true;
            //Ventes.Add(vente);
            SqlConnection connection = BaseDAO.Connection;
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                VenteDAO venteDAO = new VenteDAO();
                venteDAO.Save(vente, paiement, connection, transaction);
                venteDAO.SaveVenteProduit(vente, connection, transaction);
                ProduitDAO produitDAO = new ProduitDAO();
                vente.Produits.ForEach(p =>
                {
                    p.Stock--;
                    produitDAO.Update(p, connection, transaction);
                });

                transaction.Commit();
            }
            catch (Exception e) {
                transaction.Rollback();
                result = false;
                Console.WriteLine(e);
            }
            finally
            {
                connection.Close();
            }


            //if (venteDAO.Save(vente, paiement))
            //{
            //    if (venteDAO.SaveVenteProduit(vente))
            //    {
            //        ProduitDAO produitDAO = new ProduitDAO();
            //        vente.Produits.ForEach(p =>
            //        {
            //            p.Stock--;
            //            produitDAO.Update(p);
            //        });
            //        return true;
            //    }
            //}
            return result;
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
            return (_produitDAO ?? new ProduitDAO()).GetProduit(id);
        }

        public List<Produit> RecupererProduits()
        {
            return (_produitDAO ?? new ProduitDAO()).GetProduits();
        } 

        public List<Vente> RecupererVentes()
        {
            return new VenteDAO().RecupererVentes();
        }
    }
}

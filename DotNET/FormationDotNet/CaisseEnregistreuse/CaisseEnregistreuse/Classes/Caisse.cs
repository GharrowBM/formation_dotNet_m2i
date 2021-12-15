using CaisseEnregistreuse.DAO;
using CaisseEnregistreuse.Interfaces;
using CaisseEnregistreuse.Repository;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CaisseEnregistreuse.Classes
{
    public class Caisse
    {
        private List<Produit> produits;
        private List<Vente> ventes;
        private ProduitDAO _produitDAO;
        private VenteDAO _venteDAO;
        private IDbConnection _sqlConnection;
        public Caisse()
        {
            Produits = new List<Produit>();
            Ventes = new List<Vente>();
        }

        public Caisse(ProduitDAO produitDAO) : this()
        {
            _produitDAO = produitDAO;
        }
        public Caisse(ProduitDAO produitDAO, VenteDAO venteDAO) : this(produitDAO)
        {
            
            _venteDAO = venteDAO;
        }
        public Caisse(ProduitDAO produitDAO, VenteDAO venteDAO, IDbConnection connection) : this(produitDAO, venteDAO)
        {
            _sqlConnection = connection;
        }

        public List<Produit> Produits { get => produits; set => produits = value; }
        public List<Vente> Ventes { get => ventes; set => ventes = value; }

        public bool AjouterProduit(Produit produit)
        {
            //produits.Add(produit);
            //ProduitDAO produitDAO = _produitDAO ?? new ProduitDAO();
            //return produitDAO.Save(produit);
            return new ProduitRepository(DataContext.Instance).Save(produit);
        }
        public bool AjouterVente(Vente vente, IPaiement paiement)
        {
            //bool result = true;
            ////Ventes.Add(vente);
            //SqlConnection connection = _sqlConnection != null ? _sqlConnection as SqlConnection : BaseDAO.Connection;
            //SqlTransaction transaction = null;
            //try
            //{
            //    if(connection != null) connection.Open();
            //    transaction = connection != null ? connection.BeginTransaction() : null;
            //    VenteDAO venteDAO = _venteDAO ?? new VenteDAO();
            //    venteDAO.Save(vente, paiement, connection, transaction);
            //    venteDAO.SaveVenteProduit(vente, connection, transaction);
            //    ProduitDAO produitDAO = _produitDAO ?? new ProduitDAO();
            //    vente.Produits.ForEach(p =>
            //    {
            //        p.Stock--;
            //        produitDAO.Update(p, connection, transaction);
            //    });

            //    transaction?.Commit();
            //}
            //catch (Exception e) {
            //    transaction?.Rollback();
            //    result = false;
            //    Console.WriteLine(e);
            //}
            //finally
            //{
            //    connection?.Close();
            //}


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

            vente.Produits.ForEach(p =>
                {
                    p.Produit.Stock-= p.Qty;                    
                });
            vente.TotalFromBase = vente.Total;
            vente.TypePaiement = paiement.ToString();
            return new VenteRepository(DataContext.Instance).Save(vente).Result;
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
            //return (_produitDAO ?? new ProduitDAO()).GetProduit(id);
            return new ProduitRepository(DataContext.Instance).GetProduit(id);
        }

        public List<Produit> RecupererProduits()
        {
            //return (_produitDAO ?? new ProduitDAO()).GetProduits();

            return new ProduitRepository(DataContext.Instance).GetProduits();
        } 

        public List<Vente> RecupererVentes()
        {
            return new VenteRepository(DataContext.Instance).GetVentes();
            //return new VenteDAO().RecupererVentes();
        }
    }
}

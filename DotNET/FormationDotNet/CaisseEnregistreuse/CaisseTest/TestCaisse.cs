using CaisseEnregistreuse.Classes;
using CaisseEnregistreuse.DAO;
using CaisseEnregistreuse.Interfaces;
using FizzWare.NBuilder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseTest
{
    [TestClass]
    public class TestCaisse
    {
        [TestMethod]
        public void TestAjouterProduit()
        {
            Produit produit = new Produit("produit 1", 10M, 10);
            ProduitDAO fakeProduitDAO = Mock.Of<ProduitDAO>();
            Mock.Get(fakeProduitDAO).Setup(p => p.Save(produit)).Returns(true);
            Caisse caisse = new Caisse(fakeProduitDAO);
            bool result = caisse.AjouterProduit(produit);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestRechercherProduit_Exist()
        {
            Produit produit = new Produit("produit 1", 10M, 10) { Id = 1 };
            ProduitDAO fakeProduitDAO = Mock.Of<ProduitDAO>();
            Mock.Get(fakeProduitDAO).Setup(p => p.GetProduit(1)).Returns(produit);
            Caisse caisse = new Caisse(fakeProduitDAO);

            Produit result = caisse.RechercherProduit(1);

            Assert.AreSame(produit, result);
        }

        [TestMethod]
        public void TestRechercherProduit_Not_Exist()
        {
            
            ProduitDAO fakeProduitDAO = Mock.Of<ProduitDAO>();
            Mock.Get(fakeProduitDAO).Setup(p => p.GetProduit(1)).Returns(default(Produit));
            Caisse caisse = new Caisse(fakeProduitDAO);

            Produit result = caisse.RechercherProduit(1);

            Assert.AreEqual(default(Produit), result);
        }


        [TestMethod]
        public void TestRecupererProduits()
        {
            List<Produit> produits = Builder<Produit>.CreateListOfSize(10).Build().ToList();
            ProduitDAO fakeProduitDAO = Mock.Of<ProduitDAO>();
            Mock.Get(fakeProduitDAO).Setup(p => p.GetProduits()).Returns(produits);
            Caisse caisse = new Caisse(fakeProduitDAO);
            List<Produit> result = caisse.RecupererProduits();
            Assert.AreEqual(produits.Count, result.Count);

        }

        [TestMethod]
        public void TestAjouterVente()
        {
            Vente vente = new Vente() { Id = 1};
            vente.Produits.Add(new Produit("produit 1", 10M, 10) { Id = 1 });
            vente.Produits.Add(new Produit("produit 2", 100M, 10) { Id = 2});
            ProduitDAO fakeProduitDAO = Mock.Of<ProduitDAO>();
            VenteDAO fakeVenteDAO = Mock.Of<VenteDAO>();
            IPaiement paiement = Mock.Of<IPaiement>();
            IDbConnection connection = Mock.Of<IDbConnection>();
            IDbTransaction transaction = Mock.Of<IDbTransaction>();
            Mock.Get(paiement).Setup(p => p.Payer(vente.Total)).Returns(true);
            
            Mock.Get(fakeVenteDAO).Setup(v => v.Save(vente, paiement, connection, transaction)).Returns(true);
            Mock.Get(fakeVenteDAO).Setup(v => v.SaveVenteProduit(vente, connection, transaction)).Returns(true);
            Mock.Get(fakeProduitDAO).Setup(p => p.Update(null, connection, transaction)).Returns(true);

            Caisse caisse = new Caisse(fakeProduitDAO, fakeVenteDAO, connection);

            bool result = caisse.AjouterVente(vente, paiement);

            Assert.IsTrue(result);
        }

    }
}

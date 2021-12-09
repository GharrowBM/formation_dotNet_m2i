using CaisseEnregistreuse.Classes;
using CaisseEnregistreuse.DAO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
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
    }
}

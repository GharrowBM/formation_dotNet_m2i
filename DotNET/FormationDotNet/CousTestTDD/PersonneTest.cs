using CoursTDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CousTestTDD
{
    [TestClass]
    public class PersonneTest
    {
        [TestMethod]
        public void RechercherPersonne_Nom_Toto_Personne()
        {
            Personne p = Personne.RechercherPersonne("toto");
            Assert.IsInstanceOfType(p, typeof(Personne));
        }

        [TestMethod]
        public void RechercherPersonne_Nom_Tata_Default()
        {            
            Personne p = Personne.RechercherPersonne("tata");
            Assert.AreEqual(default(Personne), p);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpPendu.Classes;

namespace CousTestTDD
{
    [TestClass]
    public class PenduTest
    {

        [TestMethod]
        public void  GenererMasqueTest()
        {
            //Arrange
            Pendu pendu = new Pendu();
            //IGenerateur g = new FakeGenerateurMot();
            IGenerateur g = Mock.Of<IGenerateur>();
            Mock.Get(g).Setup(p => p.Generer()).Returns("toto");
            //Act
            pendu.GenererMasque(g);

            Assert.AreEqual("****", pendu.Masque);
        }
    }
}

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
        private Pendu pendu;
        [TestMethod]
        public void  GenererMasqueTest()
        {
            //Arrange
            //pendu = new Pendu();
            ////IGenerateur g = new FakeGenerateurMot();
            //IGenerateur g = Mock.Of<IGenerateur>();
            //Mock.Get(g).Setup(p => p.Generer()).Returns("toto");
            InitPendu();
            //Act
            //pendu.GenererMasque(g);

            Assert.AreEqual("****", pendu.Masque);
        }

        [TestMethod]
        public void TestCharTest_True()
        {
            InitPendu();
            bool result = pendu.TestChar('t');
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestCharTest_False()
        {
            InitPendu();
            bool result = pendu.TestChar('i');
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCharTest_True_NbEssai()
        {
            InitPendu();
            pendu.TestChar('t');
            Assert.AreEqual(10, pendu.NbEssai);
        }

        [TestMethod]
        public void TestCharTest_False_NbEssai()
        {
            InitPendu();
            pendu.TestChar('i');
            Assert.AreEqual(9, pendu.NbEssai);
        }

        [TestMethod]
        public void TestCharTest_True_Masque()
        {
            InitPendu();
            pendu.TestChar('t');
            Assert.AreEqual("t*t*", pendu.Masque);
        }

        [TestMethod]
        public void TestWin_True()
        {
            InitPendu();
            pendu.TestChar('t');
            pendu.TestChar('o');
            Assert.IsTrue(pendu.testWin());
        }
        public void TestWin_False()
        {
            InitPendu();
            pendu.TestChar('i');
            Assert.IsFalse(pendu.testWin());
        }

        public void TestWin_False_NbEssai()
        {
            InitPendu();
            for (int i = 1; i <= 10; i++)
            {
                pendu.TestChar('i');
            }
            pendu.TestChar('t');
            pendu.TestChar('o');
            Assert.IsFalse(pendu.testWin());
        }

        private void InitPendu()
        {
            pendu = new Pendu();
            //IGenerateur g = new FakeGenerateurMot();
            IGenerateur g = Mock.Of<IGenerateur>();
            Mock.Get(g).Setup(p => p.Generer()).Returns("toto");
            //Act
            pendu.GenererMasque(g);
        }
    }
}

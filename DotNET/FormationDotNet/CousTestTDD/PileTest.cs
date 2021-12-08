using CorrectionPile.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CousTestTDD
{
    [TestClass]
    public class PileTest
    {
        [TestMethod]
        public void EmpilerTest_Simple_Element_True()
        {
            Pile<int> pile = new Pile<int>(3);
            bool result = pile.Empiler(10);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EmpilerTest_Simple_Element_False()
        {
            Pile<int> pile = new Pile<int>(2);
            pile.Empiler(10);
            pile.Empiler(10);
            bool result = pile.Empiler(10);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetElementTest_Simple_Element_Exist()
        {
            Pile<int> pile = new Pile<int>(2);
            pile.Empiler(10);
            pile.Empiler(20);
            int result = pile.GetElement(1);
            Assert.AreEqual(20,result);
        }
        [TestMethod]
        public void GetElementTest_Simple_Element_NotExist()
        {
            Pile<int> pile = new Pile<int>(2);
            pile.Empiler(10);
            pile.Empiler(20);
            int result = pile.GetElement(4);
            Assert.AreEqual(default(int), result);
        }

        [TestMethod]
        public void DepilerTest_Simple_Element_True()
        {
            Pile<int> pile = new Pile<int>(2);
            pile.Empiler(10);
            bool result = pile.Depiler();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DepilerTest_Simple_Element_False()
        {
            Pile<int> pile = new Pile<int>(2);
            pile.Empiler(10);
            pile.Depiler();
            bool result = pile.Depiler();
            Assert.IsTrue(!result);
        }

        [TestMethod]
        public void SearhTest_String_Element_Exist()
        {
            Pile<string> pile = new Pile<string>(2);
            pile.Empiler("toto");
            string result = pile.Search(e => e.Contains("t"));
            Assert.AreEqual("toto", result);
        }

        [TestMethod]
        public void SearhTest_String_Element_Not_Exist()
        {
            Pile<string> pile = new Pile<string>(2);
            pile.Empiler("toto");
            string result = pile.Search(e => e.Contains("i"));
            Assert.AreEqual(default(string), result);
        }

        [TestMethod]
        public void SearchAll_String_Element_Exist()
        {
            Pile<string> pile = new Pile<string>(2);
            pile.Empiler("toto");
            pile.Empiler("titi");
            List<string> all = pile.SearchAll(e => e.Contains("t"));
            Assert.AreEqual(2, all.Count);
        }

        [TestMethod]
        public void SearchAll_String_Element_Not_Exist()
        {
            Pile<string> pile = new Pile<string>(2);
            pile.Empiler("toto");
            pile.Empiler("titi");
            List<string> all = pile.SearchAll(e => e.Contains("f"));
            Assert.AreEqual(0, all.Count);
        }
    }
}

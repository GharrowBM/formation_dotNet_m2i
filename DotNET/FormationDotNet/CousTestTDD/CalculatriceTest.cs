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
    public class CalculatriceTest
    {
        //A => Arrange one's
        private Calculatrice c = new Calculatrice();
        
        [TestMethod]
        public void AdditionTest()
        {
            //La régle du AAA
            //A => Arrange
            //Calculatrice c = new Calculatrice();
            
            //A => Act
            double result = c.Addition(1, 0);
            
            //A => Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void AdditionTest2()
        {
            //Calculatrice c = new Calculatrice();
            double result = c.Addition(1, 1);
            Assert.AreEqual(2, result);
        }
    }
}

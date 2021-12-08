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
        [TestMethod]
        public void AdditionTest()
        {
            Calculatrice c = new Calculatrice();
            double result = c.Addition(10, 30);
            Assert.AreEqual(40, result);
        }
    }
}

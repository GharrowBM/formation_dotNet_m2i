using DevEnTDD.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CousTestTDD
{
    [TestClass]
    public class ToolsTest
    {
        [TestMethod]
        public void TestSuffle_Instance()
        {
            Tools<int> t =new Tools<int>();
            int[] tab = t.Shuffle(new int[] { 1, 2, 3, 4 });
            Assert.AreEqual(4, tab.Length);
        }

        [TestMethod]
        public void TestSuffle_Instance_Default_Value()
        {
            Tools<int> t = new Tools<int>();
            int[] tab1 = new int[] { 1, 2, 3, 4 };
            int[] tab2 = t.Shuffle(tab1);
            Assert.AreNotEqual(tab2[3], default(int));
        }

        [TestMethod]
        public void TestSuffle_Suffle()
        {
            Tools<int> t = new Tools<int>();
            int[] tab1 = new int[] { 1, 2, 3, 4 };            
            Assert.AreNotEqual(1, tab1[0]);
        }
    }

}

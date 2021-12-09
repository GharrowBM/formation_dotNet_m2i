using Bowling.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingTest
{  
    [TestClass]
    public class FrameTest
    {
        private IGenerator generator = Mock.Of<IGenerator>();

        [TestMethod]
        public void SimpleFrameFirstRoll()
        {
            //Arrange
            Mock.Get(generator).Setup(g => g.RandomPins(10)).Returns(6);
            Frame frame = new Frame(generator, false);
            //Act
            bool result = frame.Roll();
            //Assert
            Assert.IsTrue(frame.Score == 6 && result);
        }

        [TestMethod]
        public void SimpleFrameSecondRollAfterStrike()
        {
            //Arrange
            Mock.Get(generator).Setup(g => g.RandomPins(10)).Returns(6);
            List<Roll> rolls = new List<Roll>() { new Roll(10)};
            Frame frame = new Frame(generator, false);
            frame.Rolls = rolls;

            //Act
            bool result = frame.Roll();

            //Assert
            Assert.IsFalse(result);
        }


        
    }
}

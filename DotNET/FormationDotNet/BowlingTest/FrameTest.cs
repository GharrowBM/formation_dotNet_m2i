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


        [TestMethod]
        public void SimpleFrameSecondRoll()
        {
            //Arrange
            Mock.Get(generator).Setup(g => g.RandomPins(4)).Returns(3);
            List<Roll> rolls = new List<Roll>() { new Roll(6) };
            Frame frame = new Frame(generator, false);
            frame.Rolls = rolls;

            //Act
            bool result = frame.Roll();

            //Assert
            Assert.AreEqual(9,frame.Score);
        }

        [TestMethod]
        public void SimpleFrameMoreRolls()
        {
            List<Roll> rolls = new List<Roll>() { new Roll(6), new Roll(2) };
            Frame frame = new Frame(generator, false);
            frame.Rolls = rolls;

            bool result = frame.Roll();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LastFrameAfterStrike()
        {
            Mock.Get(generator).Setup(g => g.RandomPins(10)).Returns(3);

            List<Roll> rolls = new List<Roll>() { new Roll(10) };
            Frame frame = new Frame(generator, true);
            frame.Rolls = rolls;

            bool result = frame.Roll();

            Assert.IsTrue(result && frame.Score == 13);

        }
        [TestMethod]
        public void LastFrameAfterStrikeSecondRoll()
        {
            Mock.Get(generator).Setup(g => g.RandomPins(7)).Returns(3);

            List<Roll> rolls = new List<Roll>() { new Roll(10), new Roll(3) };
            Frame frame = new Frame(generator, true);
            frame.Rolls = rolls;

            bool result = frame.Roll();

            Assert.IsTrue(result && frame.Score == 16);

        }

        [TestMethod]
        public void LastFrameAfterSpare()
        {
            Mock.Get(generator).Setup(g => g.RandomPins(10)).Returns(3);

            List<Roll> rolls = new List<Roll>() { new Roll(7), new Roll(3) };
            Frame frame = new Frame(generator, true);
            frame.Rolls = rolls;

            bool result = frame.Roll();

            Assert.IsTrue(result && frame.Score == 13);
        }

        [TestMethod]
        public void LastFrameMoreThen3Rolls()
        {
            List<Roll> rolls = new List<Roll>() { new Roll(7), new Roll(3), new Roll(10) };
            Frame frame = new Frame(generator, true);
            frame.Rolls = rolls;

            bool result = frame.Roll();

            Assert.IsFalse(result);
        }
    }
}

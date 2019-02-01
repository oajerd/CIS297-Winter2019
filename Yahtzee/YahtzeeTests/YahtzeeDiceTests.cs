using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yahtzee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Tests
{
    [TestClass()]
    public class YahtzeeDiceTests
    {
        [TestMethod()]
        public void YahtzeeDiceTest()
        {
            // Arrange
            var expectedValues = new List<int> { 1, 2, 3, 4, 5 };
            NotActuallyRandom random = new NotActuallyRandom(expectedValues);
            var expectedRollCount = 1;

            // Act
            YahtzeeDice yahtzeeDice = new YahtzeeDice(random);

            // Assert
            for (int index = 0; index < expectedValues.Count; index++)
            {
                Assert.AreEqual(expectedValues[index], yahtzeeDice.GetDieValue(index + 1));
            }
            Assert.IsFalse(yahtzeeDice.HoldDie1);
            Assert.IsFalse(yahtzeeDice.HoldDie2);
            Assert.IsFalse(yahtzeeDice.HoldDie3);
            Assert.IsFalse(yahtzeeDice.HoldDie4);
            Assert.IsFalse(yahtzeeDice.HoldDie5);

            Assert.AreEqual(expectedRollCount, yahtzeeDice.RollCount);


        }

        [TestMethod()]
        public void RollTest()
        {
            var expectedValues = new List<int> { 1, 2, 3, 4, 5 };
            NotActuallyRandom random = new NotActuallyRandom(expectedValues);
            var expectedRollCount = 1;

            // Act
            YahtzeeDice yahtzeeDice = new YahtzeeDice(random);
            yahtzeeDice.Roll();

            // Asssert
            for (int index = 0; index < expectedValues.Count; index++)
            {
                Assert.AreEqual(expectedValues[index], yahtzeeDice.GetDieValue(index + 1));
            }
        }

        [TestMethod()]
        public void GetDieValueTest()
        {
            Assert.Fail();
        }
    }
}
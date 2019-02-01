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
    public class YahtzeeScorecardTests
    {
        [TestMethod()]
        public void YahtzeeScorecardTest()
        {
            // Arrange
            var expectedValues = new List<int> { 1, 2, 3, 4, 5 };
            NotActuallyRandom random = new NotActuallyRandom(expectedValues);
            var dice = new YahtzeeDice(random);
            var expectedOnesScore = 1;
            var expectedTwosScore = 2;
            var expectedThreesScore = 3;
            var expectedFoursScore = 4;
            var expectedFivesScore = 5;
            var expectedSixesScore = 0;
            var expectedFullHouseScore = 0;


            // Act
            var scorecard = new YahtzeeScorecard(dice);

            // Assert
            Assert.AreEqual(expectedOnesScore, scorecard.Ones);
            Assert.AreEqual(expectedTwosScore, scorecard.Twos);
            Assert.AreEqual(expectedFullHouseScore, scorecard.FullHouse);

        }
    }
}
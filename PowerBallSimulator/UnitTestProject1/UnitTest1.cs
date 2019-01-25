using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PowerBallSimulator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int expectedWinning = PowerBallTicket.GRAND_PRIZE;
            List<int> notRandomNumbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            NotActuallyRandom random = new NotActuallyRandom(notRandomNumbers);
            PowerBallTicket winnningTicket = new PowerBallTicket(random);

            // re-creates with the list from before so it starts at index 0
            random = new NotActuallyRandom(notRandomNumbers);
            PowerBallTicket myTicket = new PowerBallTicket(random);

            // Act
            int actualWinnings = myTicket.GetWinnings(winnningTicket);

            // Assert
            Assert.AreEqual(expectedWinning, actualWinnings);
        }
    }
}

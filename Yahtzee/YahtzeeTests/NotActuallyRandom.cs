using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yahtzee;

namespace Yahtzee.Tests
{
    public class NotActuallyRandom : IRandom
    {
        List<int> notRandomNumbers;
        int currentIndex;
        public NotActuallyRandom(List<int> notRandomNumbers)
        {
            this.notRandomNumbers = notRandomNumbers;
            currentIndex = 0;
        }

        public int Next(int startingAtThisMin, int upToButNotIncludingThisMax)
        {
            int valueToReturn = notRandomNumbers[currentIndex];
            currentIndex++;
            return valueToReturn;
        }
    }
}
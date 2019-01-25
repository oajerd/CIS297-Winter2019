using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerBallSimulator
{
    public class PowerBallTicket
    {
        public static int TICKET_COST = 2;
        public static int GRAND_PRIZE = 1_000_000_000;

        // one way to deal with duplicate seed values
        //private static Random random = new Random();

        private List<int> whiteNumbers;
        private int redNumber;

        public PowerBallTicket(IRandom random)
        {
            whiteNumbers = new List<int>();

            for (int ballNumber = 0; ballNumber < 5; ballNumber++)
            {
                // random Next is exclusive of the upper bound
                int randomNumber = 0;
                // get a random number NOT in the list already
                // NO REPEATS
                do
                {
                    randomNumber = random.Next(1, 70);
                } while (whiteNumbers.Contains(randomNumber));


                whiteNumbers.Add(randomNumber);

            }

            redNumber = random.Next(1, 27);
        }

        public int GetWinnings(PowerBallTicket winningTicket)
        {
            int numberOfWhiteMatches = 0;

            foreach (var myNumber in whiteNumbers)
            {
                if (winningTicket.whiteNumbers.Contains(myNumber))
                {
                    numberOfWhiteMatches++;
                }
            }

            bool redMatches = redNumber == winningTicket.redNumber;

            if (numberOfWhiteMatches == 5 && redMatches)
            {
                return GRAND_PRIZE;
            }

            if (numberOfWhiteMatches == 5)
            {
                return 1_000_000;
            }

            if (numberOfWhiteMatches == 4 && redMatches)
            {
                return 50_000;
            }

            if (numberOfWhiteMatches == 4 || (numberOfWhiteMatches == 3 && redMatches))
            {
                return 100;
            }

            if (numberOfWhiteMatches == 3 || (numberOfWhiteMatches == 2 && redMatches))
            {
                return 7;
            }

            if (redMatches)
            {
                return 4;
            }

            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class YahtzeeScorecard
    {
        public int Ones { get; set; }
        public int Twos { get; set; }
        //....

        public int FullHouse { get; set; }

        public int SmallStraight { get; set; }

        private YahtzeeDice dice;

        public YahtzeeScorecard(YahtzeeDice dice)
        {
            this.dice = dice;

        }
    }
}

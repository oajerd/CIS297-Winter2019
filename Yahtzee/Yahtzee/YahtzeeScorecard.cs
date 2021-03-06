﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class YahtzeeScorecard : IComparable<YahtzeeScorecard>
    {
        static int UPPER_BONUS = 35;
        static int YAHTZEE = 50;
        static int LARGE_STRAIGHT = 40;
        static int SMALL_STRAIGHT = 30;
        static int FULL_HOUSE = 25;

        public int Ones { get; set; }
        public int Twos { get; set; }
        public int Threes { get; set; }
        public int Fours { get; set; }
        public int Fives { get; set; }
        public int Sixes { get; set; }

        public int ThreeOfAKind { get; set; }
        public int FourOfAKind { get; set; }
        public int FullHouse { get; set; }

        public int SmallStraight { get; set; }
        public int LargeStraight { get; set; }
        public int Yahtzee { get; set; }
        public int Chance { get; set; }

        public int UpperBonus
        {
            get
            {
                return (Ones + Twos + Threes + Fours + Fives + Sixes >= 63) ? UPPER_BONUS : 0;
            }
        }

        public int UpperTotal
        {
            get
            {
                return Ones + Twos + Threes + Fours + Fives + Sixes + UpperBonus;
            }
        }

        public int LowerTotal
        {
            get
            {
                return FullHouse + ThreeOfAKind + FourOfAKind + SmallStraight + LargeStraight + Yahtzee + Chance;
            }
        }

        public int GrandTotal
        {
            get
            {
                return UpperTotal + LowerTotal;
            }
        }

        private YahtzeeDice dice;
        private List<int> diceValues;
        private List<int> faceFrequency;

        public YahtzeeScorecard(YahtzeeDice dice)
        {
            this.dice = dice;
            diceValues = new List<int>();
            faceFrequency = new List<int>();
        }

        public int GetUpperBonus()
        {
            if (Ones + Twos + Threes + Fours + Fives + Sixes >= 63)
            {
                return UPPER_BONUS;
            }
            else
            {
                return 0;
            }
        }

        public int GetUpperTotal()
        {
            return Ones + Twos + Threes + Fours + Fives + Sixes + GetUpperBonus();
        }

        public int GetLowerTotal()
        {
            return FullHouse + ThreeOfAKind + FourOfAKind + SmallStraight + LargeStraight + Yahtzee + Chance;
        }

        public int GetGrandTotal()
        {
            return GetLowerTotal() + GetUpperTotal();
        }

        public void CalculateScores()
        {
            FillDiceValues();
            Ones = sumOfDiceWithFace(1);
            Twos = sumOfDiceWithFace(2);
            Threes = sumOfDiceWithFace(3);
            Fours = sumOfDiceWithFace(4);
            Fives = sumOfDiceWithFace(5);
            Sixes = sumOfDiceWithFace(6);

            // full house
            if (faceFrequency.Contains(2) && faceFrequency.Contains(3))
            {
                FullHouse = FULL_HOUSE;
            }

            if (faceFrequency.Contains(3))
            {
                ThreeOfAKind = sumOfDice();
            }
            if (faceFrequency.Contains(4))
            {
                ThreeOfAKind = sumOfDice();
                FourOfAKind = sumOfDice();
            }
            if (faceFrequency.Contains(5))
            {
                ThreeOfAKind = sumOfDice();
                FourOfAKind = sumOfDice();
                Yahtzee = YAHTZEE;
            }

            if ((diceValues.Contains(1) && diceValues.Contains(2) && diceValues.Contains(3) && diceValues.Contains(4))
                || (diceValues.Contains(2) && diceValues.Contains(3) && diceValues.Contains(4) && diceValues.Contains(5))
                || (diceValues.Contains(3) && diceValues.Contains(4) && diceValues.Contains(5) && diceValues.Contains(6)))
            {
                SmallStraight = SMALL_STRAIGHT;
            }

            if ((diceValues.Contains(1) && diceValues.Contains(2) && diceValues.Contains(3) && diceValues.Contains(4) && diceValues.Contains(5))
                || (diceValues.Contains(2) && diceValues.Contains(3) && diceValues.Contains(4) && diceValues.Contains(5) && diceValues.Contains(6)))
            {
                SmallStraight = SMALL_STRAIGHT;
                LargeStraight = LARGE_STRAIGHT;
            }

            Chance = sumOfDice();
        }

        private void FillDiceValues()
        {
            diceValues = new List<int> { dice.GetDieValue(1), dice.GetDieValue(2),
                dice.GetDieValue(3), dice.GetDieValue(4), dice.GetDieValue(5) };

            faceFrequency = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
            foreach (var face in diceValues)
            {
                faceFrequency[face]++;
            }
        }

        public int sumOfDice()
        {
            return diceValues.Sum();
        }

        public int sumOfDiceWithFace(int face)
        {
            var sum = 0;
            foreach (var die in diceValues)
            {
                if (die == face)
                {
                    sum += face;
                }
            }
            return sum;
        }

        public int CompareTo(YahtzeeScorecard other)
        {
            return GetGrandTotal() - other.GetGrandTotal();
        }
    }
}

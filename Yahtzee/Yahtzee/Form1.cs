using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yahtzee.Properties;

namespace Yahtzee
{
    public partial class YahtzeeForm : Form
    {
        YahtzeeScorecard myScores;
        YahtzeeScorecard possibleScores;
        YahtzeeDice dice;

        public YahtzeeForm()
        {
            InitializeComponent();
            dice = new YahtzeeDice(new RandomWrapper());
            myScores = new YahtzeeScorecard(dice);
            possibleScores = new YahtzeeScorecard(dice);
            possibleScores.CalculateScores();
            UpdatePossilbeScoreLabels();
            UpdateDieImages();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            UpdateHoldStatus();
            dice.Roll();
            UpdateDieImages();
            possibleScores.CalculateScores();
            UpdatePossilbeScoreLabels();
            if (!dice.CanRollAgain())
            {
                rollButton.Enabled = false;
            }
        }

        private void UpdateHoldStatus()
        {
            dice.HoldDie1 = checkBox1.Checked;
            dice.HoldDie2 = checkBox2.Checked;
            dice.HoldDie3 = checkBox3.Checked;
            dice.HoldDie4 = checkBox4.Checked;
            dice.HoldDie5 = checkBox5.Checked;

        }

        private void UpdateDieImages()
        {
            UpdateDieImage(pictureBox1, dice.GetDieValue(1));
            UpdateDieImage(pictureBox2, dice.GetDieValue(2));
            UpdateDieImage(pictureBox3, dice.GetDieValue(3));
            UpdateDieImage(pictureBox4, dice.GetDieValue(4));
            UpdateDieImage(pictureBox5, dice.GetDieValue(5));
        }

        private void UpdateDieImage(PictureBox box, int dieValue )
        {
            switch ( dieValue )
            {
                case 1:
                    box.Image = Resources.Die1;
                    break;
                case 2:
                    box.Image = Resources.Die2;
                    break;
                case 3:
                    box.Image = Resources.Die3;
                    break;
                case 4:
                    box.Image = Resources.Die4;
                    break;
                case 5:
                    box.Image = Resources.Die5;
                    break;
                case 6:
                    box.Image = Resources.Die6;
                    break;
                default:
                    box.Image = null;
                    break;
            }
        }

        private bool HasEveryCategoryBeenScored()
        {
            return !(scoreOnes.Enabled || scoreTwos.Enabled || scoreThrees.Enabled ||
                scoreFours.Enabled || scoreFives.Enabled || scoreSixes.Enabled ||
                scoreThreeOfAKind.Enabled || scoreFourOfAKind.Enabled || scoreFullHouse.Enabled ||
                scoreSmallStraight.Enabled || scoreLargeStraight.Enabled ||
                scoreYahtzee.Enabled || scoreChance.Enabled);
        }

        private void NextTurn()
        {
            if (!HasEveryCategoryBeenScored())
            {
                dice = new YahtzeeDice(new RandomWrapper());
                possibleScores = new YahtzeeScorecard(dice);
                possibleScores.CalculateScores();
                UpdatePossilbeScoreLabels();
                UpdateDieImages();
                rollButton.Enabled = true;
            }
            else
            {
                rollButton.Enabled = false;
            }
            UncheckAllCheckboxes();

            updateTotalLabels();
        }

        private void UncheckAllCheckboxes()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        private void updateTotalLabels()
        {
            upperBonusLabel.Text = myScores.GetUpperBonus().ToString();
            upperTotalLabel.Text = myScores.GetUpperTotal().ToString();
            lowerTotalLabel.Text = myScores.GetLowerTotal().ToString();
            grandTotalLabel.Text = myScores.GetGrandTotal().ToString();
        }

        private void UpdatePossilbeScoreLabels()
        {
            if (scoreOnes.Enabled)
            {
                onesScoreLabel.Text = possibleScores.Ones.ToString();
            }
            if (scoreTwos.Enabled)
            {
                twosScoreLabel.Text = possibleScores.Twos.ToString();
            }
            if (scoreThrees.Enabled)
            {
                threesScoreLabel.Text = possibleScores.Threes.ToString();
            }
            if (scoreFours.Enabled)
            {
                foursScoreLabel.Text = possibleScores.Fours.ToString();
            }
            if (scoreFives.Enabled)
            {
                fivesScoreLabel.Text = possibleScores.Fives.ToString();
            }
            if (scoreSixes.Enabled)
            {
                sixesScoreLabel.Text = possibleScores.Sixes.ToString();
            }
            if (scoreThreeOfAKind.Enabled)
            {
                threeOfAKindScoreLabel.Text = possibleScores.ThreeOfAKind.ToString();
            }
            if (scoreFourOfAKind.Enabled)
            {
                fourOfAKindScoreLabel.Text = possibleScores.FourOfAKind.ToString();
            }
            if (scoreFullHouse.Enabled)
            {
                fullHouseScoreLabel.Text = possibleScores.FullHouse.ToString();
            }
            if (scoreSmallStraight.Enabled)
            {
                smallStraightScoreLabel.Text = possibleScores.SmallStraight.ToString();
            }
            if (scoreLargeStraight.Enabled)
            {
                largeStraightScoreLabel.Text = possibleScores.LargeStraight.ToString();
            }
            if (scoreYahtzee.Enabled)
            {
                yahtzeeScoreLabel.Text = possibleScores.Yahtzee.ToString();
            }
            if (scoreChance.Enabled)
            {
                chanceScoreLabel.Text = possibleScores.Chance.ToString();
            }
        }

        private void scoreOnes_Click(object sender, EventArgs e)
        {
            myScores.Ones = possibleScores.Ones;
            scoreOnes.Enabled = false;
            NextTurn();
        }

        private void scoreTwos_Click(object sender, EventArgs e)
        {
            myScores.Twos = possibleScores.Twos;
            scoreTwos.Enabled = false;
            NextTurn();
        }

        private void scoreThrees_Click(object sender, EventArgs e)
        {
            myScores.Threes = possibleScores.Threes;
            scoreThrees.Enabled = false;
            NextTurn();
        }

        private void scoreFours_Click(object sender, EventArgs e)
        {
            myScores.Fours = possibleScores.Fours;
            scoreFours.Enabled = false;
            NextTurn();
        }

        private void scoreFives_Click(object sender, EventArgs e)
        {
            myScores.Fives = possibleScores.Fives;
            scoreFives.Enabled = false;
            NextTurn();
        }

        private void scoreSixes_Click(object sender, EventArgs e)
        {
            myScores.Sixes = possibleScores.Sixes;
            scoreSixes.Enabled = false;
            NextTurn();
        }

        private void scoreThreeOfAKind_Click(object sender, EventArgs e)
        {
            myScores.ThreeOfAKind = possibleScores.ThreeOfAKind;
            scoreThreeOfAKind.Enabled = false;
            NextTurn();
        }

        private void scoreFourOfAKind_Click(object sender, EventArgs e)
        {
            myScores.FourOfAKind = possibleScores.FourOfAKind;
            scoreFourOfAKind.Enabled = false;
            NextTurn();
        }

        private void scoreFullHouse_Click(object sender, EventArgs e)
        {
            myScores.FullHouse = possibleScores.FullHouse;
            scoreFullHouse.Enabled = false;
            NextTurn();
        }

        private void scoreSmallStraight_Click(object sender, EventArgs e)
        {
            myScores.SmallStraight = possibleScores.SmallStraight;
            scoreSmallStraight.Enabled = false;
            NextTurn();
        }

        private void scoreLargeStraight_Click(object sender, EventArgs e)
        {
            myScores.LargeStraight = possibleScores.LargeStraight;
            scoreLargeStraight.Enabled = false;
            NextTurn();
        }

        private void scoreYahtzee_Click(object sender, EventArgs e)
        {
            myScores.Yahtzee = possibleScores.Yahtzee;
            scoreYahtzee.Enabled = false;
            NextTurn();
        }

        private void scoreChance_Click(object sender, EventArgs e)
        {
            myScores.Chance = possibleScores.Chance;
            scoreChance.Enabled = false;
            NextTurn();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = !checkBox1.Checked;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = !checkBox2.Checked;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            checkBox3.Checked = !checkBox3.Checked;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            checkBox4.Checked = !checkBox4.Checked;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            checkBox5.Checked = !checkBox5.Checked;
        }
    }
}

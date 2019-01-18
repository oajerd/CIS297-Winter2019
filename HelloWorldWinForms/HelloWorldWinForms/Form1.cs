using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWinForms
{
    public partial class Form1 : Form
    {
        private List<List<PictureBox>> PictureBoxes;
        bool bluesTurn = true;
        bool gameOver = false;

        public Form1()
        {
            InitializeComponent();
            PictureBoxes = new List<List<PictureBox>>();

            int x_start = 0;
            int y_start = 40;

            for ( int row = 0; row < 6; row++ )
            {
                PictureBoxes.Add(new List<PictureBox>());
                x_start = 12;
                for ( int column = 0; column < 7; column++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new System.Drawing.Point(x_start, y_start);
                    pictureBox.Size = new System.Drawing.Size(75, 57);
                    pictureBox.BorderStyle = BorderStyle.FixedSingle;
                    pictureBox.BackgroundImage = Properties.Resources.Empty;
                    pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox.Tag = "Empty";
                    ((ISupportInitialize)(pictureBox)).BeginInit();
                    Controls.Add(pictureBox);

                    x_start += 78;
                    PictureBoxes[row].Add(pictureBox);
                }
                y_start += 60;
            }


        }

        private void columnButton_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {

                Button clickedButton = (sender as Button);

                int column = 0;
                switch (clickedButton.Name)
                {
                    case "column1Button":
                        column = 0;
                        break;
                    case "column2Button":
                        column = 1;
                        break;
                    case "column3Button":
                        column = 2;
                        break;
                    case "column4Button":
                        column = 3;
                        break;
                    case "column5Button":
                        column = 4;
                        break;
                    case "column6Button":
                        column = 5;
                        break;
                    case "column7Button":
                        column = 6;
                        break;
                }

                bool whosTurn = bluesTurn;

                for (int row = PictureBoxes.Count - 1; row >= 0; row--)
                {
                    if (PictureBoxes[row][column].Tag.ToString() == "Empty")
                    {
                        if (bluesTurn)
                        {
                            PictureBoxes[row][column].BackgroundImage = Properties.Resources.blueChecker;
                            PictureBoxes[row][column].Tag = "Blue";
                        }
                        else
                        {
                            PictureBoxes[row][column].BackgroundImage = Properties.Resources.redChecker;
                            PictureBoxes[row][column].Tag = "Red";
                        }
                        bluesTurn = !bluesTurn;
                        break;
                    }
                }

                if (whosTurn != bluesTurn)
                {
                    if (bluesTurn)
                    {
                        whosTurnLabel.Text = "Red's Turn";
                    }
                    else
                    {
                        whosTurnLabel.Text = "Blue's Turn";
                    }
                }
            }

            if ( gameIsOver() )
            {
                gameOver = true;
            }
            
            
        }

        private bool gameIsOver()
        {
            return WinHorizontal() || WinVertical() || WinDiagonal();
        }

        private bool WinDiagonal()
        {
            return WinDiagonalUp() || WindDiagonalDown();
        }

        private bool WindDiagonalDown()
        {
            throw new NotImplementedException();
        }

        private bool WinDiagonalUp()
        {
            throw new NotImplementedException();
        }

        private bool WinVertical()
        {
            throw new NotImplementedException();
        }

        private bool WinHorizontal()
        {
            throw new NotImplementedException();
        }
    }
}

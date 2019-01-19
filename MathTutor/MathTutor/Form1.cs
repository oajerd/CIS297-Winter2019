using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTutor
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int firstNumber;
        int secondNumber;
        public Form1()
        {
            InitializeComponent();
            PickNewNumbers();
        }

        private void PickNewNumbers()
        {
            firstNumber = random.Next(1, 11);
            secondNumber = random.Next(1, 11);
            firstNumberLabel.Text = firstNumber.ToString();
            secondNumberLabel.Text = secondNumber.ToString();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int answer = Convert.ToInt32(answerBox.Text);
            if ( answer == firstNumber + secondNumber )
            {
                statusLabel.Text = "Correct!";
                PickNewNumbers();
            }
            else
            {
                statusLabel.Text = "Try again!";
            }
            answerBox.Text = string.Empty;
        }
    }
}

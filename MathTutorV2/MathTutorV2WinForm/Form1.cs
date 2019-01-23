using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTutorV2WinForm
{
    public partial class Form1 : Form
    {
        private MathTutor mathTutor;
        public Form1()
        {
            InitializeComponent();
            radioButtonPlus.Checked = true;
            UpdateQuestionLabel();
        }

        private void radioButtonMinus_CheckedChanged(object sender, EventArgs e)
        { 
            UpdateQuestionLabel();
        }

        private void UpdateQuestionLabel()
        {
            if (radioButtonMinus.Checked)
            {
                mathTutor = new MathTutor(Operator.Subtraction);
            }
            else
            {
                mathTutor = new MathTutor(Operator.Addition);
            }
            string sign = radioButtonMinus.Checked ? "-" : "+";
            questionLabel.Text = $"{mathTutor.FirstVariable} {sign} {mathTutor.SecondVariable} = ";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if ( Convert.ToInt32(answerBox.Text) == mathTutor.Result )
            {
                mathTutor.Update();
                UpdateQuestionLabel();
            }
            answerBox.Clear();
        }
    }

    public enum Operator
    {
        Addition, Subtraction
    }

    public class MathTutor
    {
        public int FirstVariable { get; private set; }
        public int SecondVariable { get; private set; }
        public int Result { get; private set; }
        public Operator OperatorToUse { get; set; }

        private Random random;

        public MathTutor(Operator operatorToUse)
        {
            OperatorToUse = operatorToUse;
            random = new Random();
            Update();
        }

        public void Update()
        {
            FirstVariable = random.Next(1, 11);
            SecondVariable = random.Next(1, 11);

            if (OperatorToUse == Operator.Addition)
            {
                Result = FirstVariable + SecondVariable;
            }
            else if (OperatorToUse == Operator.Subtraction)
            {
                if (FirstVariable < SecondVariable)
                {
                    int temp = FirstVariable;
                    FirstVariable = SecondVariable;
                    SecondVariable = temp;
                }
                Result = FirstVariable - SecondVariable;
            }
        }
    }
}

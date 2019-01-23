using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTutorV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while (input != "+" && input != "-")
            {
                Console.WriteLine("Which operator do you want to work with? ( + - )");
                input = Console.ReadLine();
            }
            Operator operatorToUse;

            if ( input == "+" )
            {
                operatorToUse = Operator.Addition;
            }
            else
            {
                operatorToUse = Operator.Subtraction;
            }

            MathTutor mathTutor = new MathTutor(operatorToUse);
            string keepGoing = "y";
            do
            {
                int answer = -1;

                while (answer != mathTutor.Result)
                {
                    Console.WriteLine($"{mathTutor.FirstVariable} {input} {mathTutor.SecondVariable} = ");
                    answer = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Do you want another problem? Y/N");
                keepGoing = Console.ReadLine().ToLower();
                mathTutor.Update();
            } while (keepGoing == "y");
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

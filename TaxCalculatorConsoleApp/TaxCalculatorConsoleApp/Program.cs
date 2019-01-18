using System;

namespace TaxCalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double grossIncome = 0;
            double totalDeductions = 0;
            double income = 0;
            double deduction = 0;
            do
            {
                Console.WriteLine("Please enter your income from your W2 or 0 to stop entering incomes");
                income = Convert.ToDouble(Console.ReadLine());
                grossIncome += income;
            } while (income != 0);

            do
            {
                Console.WriteLine("Please enter an itemized deduction or 0 to stop entering deductions");
                deduction = Convert.ToDouble(Console.ReadLine());
                totalDeductions += deduction;
            } while (deduction != 0);

            var taxInfo = new TaxesFor2018(grossIncome, totalDeductions);

            Console.WriteLine($"Gross Income: {grossIncome}");
            Console.WriteLine($"Total Deductions: {taxInfo.TotalDeductions}");

            Console.WriteLine($"Taxes owed at 10%: {taxInfo.Taxes_owed_at_10_percent}");
            Console.WriteLine($"Taxes owed at 12%: {taxInfo.Taxes_owed_at_12_percent}");
            Console.WriteLine($"Taxes owed at 22%: {taxInfo.Taxes_owed_at_22_percent}");
            Console.WriteLine($"Taxes owed at 24%: {taxInfo.Taxes_owed_at_24_percent}");
            Console.WriteLine($"Taxes owed at 32%: {taxInfo.Taxes_owed_at_32_percent}");
            Console.WriteLine($"Taxes owed at 35%: {taxInfo.Taxes_owed_at_35_percent}");
            Console.WriteLine($"Taxes owed at 37%: {taxInfo.Taxes_owed_at_37_percent}");

            Console.WriteLine($"Taxes owed at a percentage of Adjusted Gross Income: {taxInfo.TaxesOwedAsPercentageOfAdjustedGrossIncome}");
            Console.WriteLine($"Taxes owed at a percentage of Gross Income: {taxInfo.TaxesOwedAsPercentageOfGrossIncome}");

            Console.ReadLine();
        }
    }

    public class TaxesFor2018
    {
        static int[] Tax_Bracket_Floors = { 600_000, 400_000, 315_000, 165_000, 77_400, 19_050, 0 };
        static double[] Tax_Bracket_Rates = { .37, .35, .32, .24, .22, .12, .1 };

        public double Taxes_owed_at_37_percent { get; private set; }
        public double Taxes_owed_at_35_percent { get; private set; }
        public double Taxes_owed_at_32_percent { get; private set; }
        public double Taxes_owed_at_24_percent { get; private set; }
        public double Taxes_owed_at_22_percent { get; private set; }
        public double Taxes_owed_at_12_percent { get; private set; }
        public double Taxes_owed_at_10_percent { get; private set; }

        public double TotalTaxesOwed { get; private set; }

        public double TaxesOwedAsPercentageOfGrossIncome { get; private set; }
        public double TaxesOwedAsPercentageOfAdjustedGrossIncome { get; private set; }

        private double GrossIncome;
        public double TotalDeductions { get; private set; }
        private double AdjustedGrossIncome;

        public TaxesFor2018(double GrossIncome, double TotalDeductions)
        {
            this.GrossIncome = GrossIncome;
            if (TotalDeductions < 24_000)
            {
                TotalDeductions = 24_000;
            }
            this.TotalDeductions = TotalDeductions;
            AdjustedGrossIncome = GrossIncome - TotalDeductions;
            double incomeToBeTaxed = AdjustedGrossIncome;
            TotalTaxesOwed = 0;

            double[] taxes_at_brackets = { 0, 0, 0, 0, 0, 0, 0 };

            for ( int index = 0; index < Tax_Bracket_Floors.Length; index++ )
            {
                if (incomeToBeTaxed > Tax_Bracket_Floors[index] )
                {
                    taxes_at_brackets[index] = (incomeToBeTaxed - Tax_Bracket_Floors[index]) * Tax_Bracket_Rates[index];
                    incomeToBeTaxed = Tax_Bracket_Floors[index];
                    TotalTaxesOwed += taxes_at_brackets[index];
                }
            }

            Taxes_owed_at_37_percent = taxes_at_brackets[0];
            Taxes_owed_at_35_percent = taxes_at_brackets[1];
            Taxes_owed_at_32_percent = taxes_at_brackets[2];
            Taxes_owed_at_24_percent = taxes_at_brackets[3];
            Taxes_owed_at_22_percent = taxes_at_brackets[4];
            Taxes_owed_at_12_percent = taxes_at_brackets[5];
            Taxes_owed_at_10_percent = taxes_at_brackets[6];

            TaxesOwedAsPercentageOfGrossIncome = TotalTaxesOwed / GrossIncome;
            TaxesOwedAsPercentageOfAdjustedGrossIncome = TotalTaxesOwed / AdjustedGrossIncome;

        }





    }
}

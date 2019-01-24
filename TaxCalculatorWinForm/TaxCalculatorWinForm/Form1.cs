using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculatorWinForm
{
    public partial class Form1 : Form
    {
        TaxesFor2018 taxInfo;
        double grossIncome;
        double totalDeductions;
        public Form1()
        {
            InitializeComponent();
            grossIncome = 0;
            totalDeductions = 0;
            UpdateTaxInfo();
        }

        private void addIncomeButton_Click(object sender, EventArgs e)
        {
            grossIncome += Convert.ToDouble(incomeTextBox.Text);
            grossIncomeLabel.Text = $"Gross Income: ${grossIncome}";
            incomeTextBox.Text = string.Empty;
            UpdateTaxInfo();
        }

        private void addDeductionButton_Click(object sender, EventArgs e)
        {
            totalDeductions += Convert.ToDouble(deductionTextBox.Text);
            totalDeductionLabel.Text = $"Total Deductions: ${totalDeductions}";
            deductionTextBox.Text = string.Empty;
            UpdateTaxInfo();
        }

        public void UpdateTaxInfo()
        {
            taxInfo = new TaxesFor2018(grossIncome, totalDeductions);

            taxInfoLabel.Text = $"Gross Income: {grossIncome}"
           + "\n" + $"Total Deductions: {taxInfo.TotalDeductions}"
           + "\n" + $"Taxes owed at 10%: {taxInfo.Taxes_owed_at_10_percent}"
           + "\n" + $"Taxes owed at 12%: {taxInfo.Taxes_owed_at_12_percent}"
           + "\n" + $"Taxes owed at 22%: {taxInfo.Taxes_owed_at_22_percent}"
           + "\n" + $"Taxes owed at 24%: {taxInfo.Taxes_owed_at_24_percent}"
           + "\n" + $"Taxes owed at 32%: {taxInfo.Taxes_owed_at_32_percent}"
           + "\n" + $"Taxes owed at 35%: {taxInfo.Taxes_owed_at_35_percent}"
           + "\n" + $"Taxes owed at 37%: {taxInfo.Taxes_owed_at_37_percent}"
           + "\n" + $"Taxes owed at a percentage of Adjusted Gross Income: {taxInfo.TaxesOwedAsPercentageOfAdjustedGrossIncome}"
           + "\n" + $"Taxes owed at a percentage of Gross Income: {taxInfo.TaxesOwedAsPercentageOfGrossIncome}";

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

            for (int index = 0; index < Tax_Bracket_Floors.Length; index++)
            {
                if (incomeToBeTaxed > Tax_Bracket_Floors[index])
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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxCalculatorConsoleApp;

namespace TaxesFor2018Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTaxes_NoIncome()
        {
            // AAA

            // Arrange
            double income = 0;
            double deductions = 0;
            double expectedTotalTaxes = 0;

            // Act
            TaxesFor2018 taxInfo = new TaxesFor2018(income, deductions);

            // Assert
            Assert.AreEqual(expectedTotalTaxes, taxInfo.TotalTaxesOwed);
        }

        [TestMethod]
        public void TestTaxes_LessIncome_ThanDeductions()
        {
            // AAA

            // Arrange
            double income = 20_000;
            double deductions = 0;
            double expectedTotalTaxes = 0;
            double expectedTotalDeductions = 24_000;

            // Act
            TaxesFor2018 taxInfo = new TaxesFor2018(income, deductions);

            // Assert
            Assert.AreEqual(expectedTotalTaxes, taxInfo.TotalTaxesOwed);
            Assert.AreEqual(expectedTotalDeductions, taxInfo.TotalDeductions);
        }

        [TestMethod]
        public void TestTaxes_1_000_000_Income()
        {
            // AAA

            // Arrange
            double income = 1_000_000;
            double deductions = 0;
            double expectedTotalTaxes = 0;
            double expectedTotalDeductions = 24_000;
            double expectedTaxesAt10Percent = 1905;
            double expectedTaxesAt12Percent = 7002;
            double expectedTaxesAt22Percent = 19272;
            double expectedTaxesAt24Percent = 36000;
            double expectedTaxesAt32Percent = 27200;
            double expectedTaxesAt35Percent = 70000;
            double expectedTaxesAt37Percent = 139120;

            // Act
            TaxesFor2018 taxInfo = new TaxesFor2018(income, deductions);

            // Assert
            Assert.AreEqual(expectedTaxesAt10Percent, taxInfo.Taxes_owed_at_10_percent);
            Assert.AreEqual(expectedTaxesAt12Percent, taxInfo.Taxes_owed_at_12_percent);
            Assert.AreEqual(expectedTaxesAt22Percent, taxInfo.Taxes_owed_at_22_percent);
            Assert.AreEqual(expectedTaxesAt24Percent, taxInfo.Taxes_owed_at_24_percent);
            Assert.AreEqual(expectedTaxesAt32Percent, taxInfo.Taxes_owed_at_32_percent);
            Assert.AreEqual(expectedTaxesAt35Percent, taxInfo.Taxes_owed_at_35_percent);
            Assert.AreEqual(expectedTaxesAt37Percent, taxInfo.Taxes_owed_at_37_percent);
            
            Assert.AreEqual(expectedTotalDeductions, taxInfo.TotalDeductions);
        }
    }
}

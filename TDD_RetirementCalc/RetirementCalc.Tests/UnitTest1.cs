using NUnit.Framework;
using RetirementCalc.Service;


namespace Tests
{
    public class Tests
    {
        [Test]
        public void RetirementCalculatorReturns_TypeInt()
        {
            var client = new Client
                {
                    currentAge = 47,
                    targetRetirementAge = 65,
                    netWorth = 500000,
                    desiredMonthlySpending = 2500,
                    yearlySavingContribution = 22000,
                    yearlyExpenses = 55000
                };
            var calculator = new Calculator(new NoExpensePlanned());
            var output = calculator.RetirementYears(client);
            Assert.That(output, Is.TypeOf<int>());
        }

        [Test]
        public void NoExpenseRetire()
        {
            var client = new Client
            {
                currentAge = 55,
                targetRetirementAge = 65,
                netWorth = 500000,
                desiredMonthlySpending = 2000,
                yearlySavingContribution = 22000,
                yearlyExpenses = 30000
            };
            var calculator = new Calculator(new NoExpensePlanned());
            var output = calculator.RetirementYears(client);
            var expected = 18;
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void RetireWithEducationExpenses()
        {
            var client = new Client
            {
                currentAge = 55,
                targetRetirementAge = 65,
                netWorth = 800000,
                desiredMonthlySpending = 2000,
                yearlySavingContribution = 22000,
                yearlyExpenses = 30000
            };
            EducationExpense educationExpense = new EducationExpense(){ 
                amount = 25000,
                numberofYears = 4
            };
            var calculator = new Calculator(educationExpense);
            var output = calculator.RetirementYears(client);
            var expected = 26;
            Assert.AreEqual(expected, output);
        }
    }
}
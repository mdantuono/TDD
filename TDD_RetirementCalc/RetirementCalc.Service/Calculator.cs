using System;

namespace RetirementCalc.Service
{
    public class Calculator
    {
        private readonly IExpense expense;

        public Calculator(IExpense expense)
        {
            this.expense = expense;
        }

        public int RetirementYears(Client client)
       {
            var educationCost = expense.totalExpense();
            if (educationCost > 0)
                client.netWorth = client.netWorth - educationCost;
            var totalAtRetirement = client.netWorth - (client.yearlyExpenses * (client.targetRetirementAge - client.currentAge)) + (client.yearlySavingContribution * (client.targetRetirementAge - client.currentAge));
            var yearsAfterRetire = totalAtRetirement / (client.desiredMonthlySpending * 12);
            return Convert.ToInt32(yearsAfterRetire);
       }
    }
}

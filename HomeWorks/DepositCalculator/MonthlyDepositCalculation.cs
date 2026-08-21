using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DepositCalculator
{
    public static class MonthlyDepositCalculation
    {
        private const decimal InterestRate = 0.24m;

        public static List<DepositData> CalculateMonthlyResult(decimal initialDeposit, int months, int withCapitalization)
        {
            var result = new List<DepositData>();
            decimal currentBalance = initialDeposit;

            for (int i = 1; i <= months; i++)
            {
                decimal monthlyInterestRate;

                if (withCapitalization == 1)
                {
                     monthlyInterestRate = currentBalance * InterestRate / 12m;
                }
                else
                {
                     monthlyInterestRate = initialDeposit * InterestRate / 12m;
                }
                currentBalance += monthlyInterestRate;

                result.Add(new DepositData
                {
                    NumberOfMonths = i,
                    Deposit = initialDeposit,
                    Interest = monthlyInterestRate,
                    Balance = currentBalance
                });
            }

            return result;
        }
    }
}

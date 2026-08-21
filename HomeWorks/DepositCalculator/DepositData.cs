using System;
using System.Collections.Generic;
using System.Text;

namespace DepositCalculator
{
    public class DepositData
    {
        public int NumberOfMonths 
        { 
            get;
            init => field = value < 1 || value > 12
                ? throw new ArgumentOutOfRangeException(nameof(NumberOfMonths), "Number of months must be between 1 and 12 !") 
                : value;
        }
        public decimal Deposit 
        { 
            get;
            init => field = value < 100
                ? throw new ArgumentOutOfRangeException(nameof(Deposit), "The Deposit must be more than 100 !")
                : value;
        }
        public decimal Interest { get; init; }
        public decimal Balance { get; init; }
    }
}

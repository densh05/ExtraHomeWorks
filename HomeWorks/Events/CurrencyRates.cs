using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    static class CurrencyRates
    {
        private static decimal usdRate;
        private static decimal eurRate;
        private static decimal gbpRate;

        public static event EventHandler RatesUpdated;

        public static List<Currency> GetCurrentRates()
        {
            return new List<Currency>()
            {
                new Currency {Code = "USD", Name = "US Dollar", Rate = usdRate},
                new Currency {Code = "EUR", Name = "Euro", Rate = eurRate},
                new Currency {Code = "GBP", Name = "Pound", Rate = gbpRate}
            };
        }

        public static void SetRates(decimal usdRate, decimal eurRate, decimal gbpRate)
        {
            CurrencyRates.usdRate = usdRate;
            CurrencyRates.eurRate = eurRate;
            CurrencyRates.gbpRate = gbpRate;

            var args = new EventRateArgs
            {
                UsdRate = usdRate,
                EurRate = usdRate,
                GbpRate = gbpRate
            };

            RatesUpdated?.Invoke(null, args);
        }

    }
}

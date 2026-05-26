using Events;

class Program
{

    private static void OnCurrencyRateChanged(object sender, EventArgs e)
    {
        var args = e as EventRateArgs; 

        var euro = args?.EurRate;

        Console.WriteLine(euro);

        var currencies = CurrencyRates.GetCurrentRates();
        foreach (var currency in currencies)
        {
            Console.WriteLine(currency.Name);
            Console.WriteLine(currency.Rate);
        }
    }

    static void Main()
    {
        CurrencyRates.RatesUpdated += OnCurrencyRateChanged;

        CurrencyRates.SetRates(42.3m, 45.2m, 53.7m);

        CurrencyRates.SetRates(43.3m, 46.2m, 55.7m);
    }
}

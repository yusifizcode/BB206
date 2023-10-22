namespace EnumTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalcCurrency(Currency.USD, 16));
        }

        static double CalcCurrency(Currency currency, double azn)
        {
            switch (currency)
            {
                case Currency.USD:
                    return azn * 0.5882;
                case Currency.RUB:
                    return azn * 57.4713;
                case Currency.EUR:
                    return azn * 0.5562;
                case Currency.TRY:
                    return azn * 16.4474;
                default:
                    return 0;
            }
        }
    }
}
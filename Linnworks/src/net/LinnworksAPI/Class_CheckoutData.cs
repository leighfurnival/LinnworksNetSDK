namespace LinnworksAPI
{
    public class CheckoutData
    {
        public string CurrencyCode;
        public string CurrencySymbol;
        public CheckoutItem Item;
        public TotalsInformation TotalsInformation;
        public double TaxRate;
    }
}
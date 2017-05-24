using System;

namespace LinnworksAPI
{
    [Serializable]
    public class OrderTotalsInfo
    {
        public double Subtotal;
        public double PostageCost;
        public double Tax;
        public double TotalCharge;
        public string PaymentMethod;
        public Guid PaymentMethodId;
        public double ProfitMargin;
        public double TotalDiscount;
        public string Currency;
        public double CountryTaxRate;
    }
}
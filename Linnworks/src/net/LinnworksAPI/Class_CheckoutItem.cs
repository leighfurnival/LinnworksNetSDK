using System;

namespace LinnworksAPI
{
    public class CheckoutItem
    {
        public string Name;
        public double Total;
        public double DiscountAmount;
        public string DiscountMessage;
        public DateTime NextPaymentDate;
        public ChargeType ChargeType;
    }
}
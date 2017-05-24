using System.Collections.Generic;

namespace LinnworksAPI
{
    public class CheckoutRequest
    {
        public PaymentType PaymentType;
        public List<CheckoutRequestParameter> Parameters;
        public string CurrencyCode;
    }
}
using System;

namespace LinnworksAPI
{
    public class ReturnOrderHeader
    {
        public Guid pkOrderId;
        public int nOrderId;
        public string Source;
        public string SubSource;
        public string PostalServiceName;
        public string cShippingAddress;
        public string cCurrency;
        public DateTime dReceivedDate;
        public DateTime dProcessedOn;
        public double fTotalCharge;
        public string RefundLink;
    }
}
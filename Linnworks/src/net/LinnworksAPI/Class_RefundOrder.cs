using System;

namespace LinnworksAPI
{
    public class RefundOrder
    {
        public Guid pkOrderID;
        public int nOrderId;
        public string cFullName;
        public string Source;
        public double Amount;
        public string IssueRefundUrl;
        public string cCurrency;
        public string ReferenceNum;
        public string SecondaryReference;
        public DateTime RefundDate;
    }
}
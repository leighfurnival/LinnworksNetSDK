using System;

namespace LinnworksAPI
{
    public class RefundOrder
    {
        public Guid pkOrderID;
<<<<<<< HEAD
        public int nOrderId;
        public string cFullName;
        public string Source;
        public double Amount;
        public string IssueRefundUrl;
        public string cCurrency;
        public string ReferenceNum;
        public string SecondaryReference;
=======
        public Int32 nOrderId;
        public String cFullName;
        public String Source;
        public String SubSource;
        public Double Amount;
        public String IssueRefundUrl;
        public String cCurrency;
        public String ReferenceNum;
        public String SecondaryReference;
>>>>>>> refs/remotes/LinnSystems/master
        public DateTime RefundDate;
        public Double SubTotal;
        public Double Total;
        public Double TaxRate;
    }
}
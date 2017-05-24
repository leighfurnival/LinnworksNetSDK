using System;

namespace LinnworksAPI
{
    public class Update_PurchaseOrderItemParameter
    {
        public Guid pkPurchaseItemId;
        public Guid pkPurchaseId;
        public int? Quantity;
        public int? PackQuantity;
        public int? PackSize;
        public decimal? Cost;
        public decimal? TaxRate;
    }
}
using System;

namespace LinnworksAPI
{
    public class Add_PurchaseOrderItemParameter
    {
        public Guid pkPurchaseId;
        public Guid fkStockItemId;
        public int Qty;
        public int PackQuantity;
        public int PackSize;
        public decimal Cost;
        public decimal TaxRate;
    }
}
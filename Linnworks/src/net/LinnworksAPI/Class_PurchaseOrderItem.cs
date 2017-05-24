using System;

namespace LinnworksAPI
{
    public class PurchaseOrderItem
    {
        public Guid pkPurchaseItemId;
        public Guid fkStockItemId;
        public int Quantity;
        public decimal Cost;
        public int Delivered;
        public decimal TaxRate;
        public decimal Tax;
        public int PackQuantity;
        public int PackSize;
        public string SKU;
        public string ItemTitle;
    }
}
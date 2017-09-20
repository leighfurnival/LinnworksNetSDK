using System;

namespace LinnworksAPI
{
    public class PurchaseOrderItem
    {
        public Guid pkPurchaseItemId;
        public Guid fkStockItemId;
<<<<<<< HEAD
        public int Quantity;
        public decimal Cost;
        public int Delivered;
        public decimal TaxRate;
        public decimal Tax;
        public int PackQuantity;
        public int PackSize;
        public string SKU;
        public string ItemTitle;
=======
        public Int32 Quantity;
        public Decimal Cost;
        public Int32 Delivered;
        public Decimal TaxRate;
        public Decimal Tax;
        public Int32 PackQuantity;
        public Int32 PackSize;
        public String SKU;
        public String ItemTitle;
        public Int32 InventoryTrackingType;
>>>>>>> refs/remotes/LinnSystems/master
    }
}
using System;

namespace LinnworksAPI
{
    public class StockItemDuePO
    {
        public string SupplierName;
        public StockLocation Location;
        public Guid SupplierId;
        public DateTime DateOfPurchase;
        public DateTime QuotedDeliveryDate;
        public int Quantity;
        public int Delivered;
        public double UnitCost;
        public Guid StockItemId;
    }
}
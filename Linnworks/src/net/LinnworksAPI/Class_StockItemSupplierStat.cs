using System;

namespace LinnworksAPI
{
    public class StockItemSupplierStat
    {
        public bool IsDefault;
        public string Supplier;
        public Guid SupplierID;
        public string Code;
        public string SupplierBarcode;
        public int LeadTime;
        public double PurchasePrice;
        public double MinPrice;
        public double MaxPrice;
        public double AveragePrice;
        public double AverageLeadTime;
        public int SupplierMinOrderQty;
        public int SupplierPackSize;
        public string SupplierCurrency;
        public Guid StockItemId;
    }
}
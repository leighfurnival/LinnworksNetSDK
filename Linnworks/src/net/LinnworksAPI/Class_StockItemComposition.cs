using System;

namespace LinnworksAPI
{
    public class StockItemComposition
    {
        public Guid LinkedStockItemId;
        public string ItemTitle;
        public string SKU;
        public int Quantity;
        public double PurchasePrice;
        public Guid StockItemId;
    }
}
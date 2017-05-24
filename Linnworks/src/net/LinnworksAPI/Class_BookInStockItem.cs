using System;

namespace LinnworksAPI
{
    public class BookInStockItem
    {
        public Guid StockItemId;
        public Guid LocationId;
        public int QuantityReceived;
        public decimal CostPerUnit;
    }
}
using System;

namespace LinnworksAPI
{
    public class StockItemPricingRule
    {
        public int? pkRowId;
        public Guid fkStockPricingId;
        public string Type;
        public int LowerBound;
        public double Value;
    }
}
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class StockItemPrice
    {
        public Guid pkRowId;
        public string Source;
        public string SubSource;
        public double Price;
        public UpdateStatusType UpdateStatus;
        public string Tag;
        public List<StockItemPricingRule> Rules;
        public Guid StockItemId;
    }
}
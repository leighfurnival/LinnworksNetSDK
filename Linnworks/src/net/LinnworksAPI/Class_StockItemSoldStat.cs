using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class StockItemSoldStat
    {
        public string Source;
        public int Quantity;
        public double Total;
        public double Cost;
        public double ProfitMargin;
        public List<StockItemSoldStatDetail> Detail;
        public Guid StockItemId;
    }
}
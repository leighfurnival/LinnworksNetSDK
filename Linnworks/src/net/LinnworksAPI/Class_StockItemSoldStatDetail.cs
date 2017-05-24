using System.Collections.Generic;

namespace LinnworksAPI
{
    public class StockItemSoldStatDetail
    {
        public string Subsource;
        public int Quantity;
        public double Total;
        public double Cost;
        public double ProfitMargin;
        public List<StockItemSoldStatFinalDetail> Detail;
    }
}
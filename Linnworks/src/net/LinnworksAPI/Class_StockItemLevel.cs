using System;

namespace LinnworksAPI
{
    public class StockItemLevel
    {
        public StockLocation Location;
        public int StockLevel;
        public double StockValue;
        public int MinimumLevel;
        public int InOrderBook;
        public int Due;
        public int InOrders;
        public int Available;
        public double UnitCost;
        public string SKU;
        public bool AutoAdjust;
        public DateTime LastUpdateDate;
        public string LastUpdateOperation;
        public Guid rowid;
        public bool PendingUpdate;
        public Guid StockItemId;
    }
}
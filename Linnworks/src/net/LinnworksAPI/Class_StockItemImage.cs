using System;

namespace LinnworksAPI
{
    public class StockItemImage
    {
        public string Source;
        public string FullSource;
        public string CheckSumValue;
        public Guid pkRowId;
        public bool IsMain;
        public int SortOrder;
        public Guid StockItemId;
    }
}
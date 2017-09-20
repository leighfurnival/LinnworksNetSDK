using System;

namespace LinnworksAPI
{
    public class StockItemChannelSKU
    {
        public Guid ChannelSKURowId;
        public string SKU;
        public string Source;
        public string SubSource;
        public string UpdateStatus;
        public string ChannelReferenceId;
        public DateTime LastUpdate;
        public int SubmittedQuantity;
        public int ListedQuantity;
        public int MaxListedQuantity;
        public Guid StockItemId;
    }
}
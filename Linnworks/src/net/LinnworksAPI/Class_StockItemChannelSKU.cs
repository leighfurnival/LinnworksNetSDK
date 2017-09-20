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
<<<<<<< HEAD
        public int SubmittedQuantity;
        public int ListedQuantity;
        public int MaxListedQuantity;
=======
        public Int32 MaxListedQuantity;
        public Int32 EndWhenStock;
        public Int32 SubmittedQuantity;
        public Int32 ListedQuantity;
        public Double StockPercentage;
        public Boolean IgnoreSync;
        public Boolean? IgnoreSyncMultiLocation;
        public Boolean IsMultiLocation;
>>>>>>> refs/remotes/LinnSystems/master
        public Guid StockItemId;
    }
}
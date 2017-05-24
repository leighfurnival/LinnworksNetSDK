using System;

namespace LinnworksAPI
{
    public class SplitPackaging
    {
        public int BinIndex;
        public string ItemTitle;
        public string PackageTitle;
        public Guid pkBinId;
        public Guid fkOrderItemRowId;
        public int Quantity;
        public string SKU;
        public string TrackingNumber;
        public double Weight;
    }
}
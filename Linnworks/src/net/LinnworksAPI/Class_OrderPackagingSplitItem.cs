using System;

namespace LinnworksAPI
{
    public class OrderPackagingSplitItem
    {
        public Guid RowId;
        public int Quantity;
        public string TrackingNumber;
        public double Weight;
        public string SKU;
        public string Title;
    }
}
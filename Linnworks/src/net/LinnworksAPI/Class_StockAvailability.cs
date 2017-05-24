using System;

namespace LinnworksAPI
{
    public class StockAvailability
    {
        public Guid PkId;
        public LevelType LevelType;
        public AvailabilityStatus Status;
        public string ReferenceNumber;
        public int Quantity;
    }
}
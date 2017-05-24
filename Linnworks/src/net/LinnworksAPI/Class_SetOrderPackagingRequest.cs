using System;

namespace LinnworksAPI
{
    public class SetOrderPackagingRequest
    {
        public Guid fkPackagingGroupId;
        public Guid fkPackagingTypeId;
        public Guid pkOrderId;
        public double TotalWeight;
        public bool ManualAdjust;
        public decimal TotalDepth;
        public decimal TotalHeight;
        public decimal TotalWidth;
    }
}
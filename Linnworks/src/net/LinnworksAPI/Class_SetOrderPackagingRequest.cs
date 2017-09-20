using System;

namespace LinnworksAPI
{
    public class SetOrderPackagingRequest
    {
        public Guid fkPackagingGroupId;
        public Guid fkPackagingTypeId;
        public Guid pkOrderId;
<<<<<<< HEAD
        public double TotalWeight;
        public bool ManualAdjust;
        public decimal TotalDepth;
        public decimal TotalHeight;
        public decimal TotalWidth;
=======
        public Double TotalWeight;
        public Boolean ManualAdjust;
        public Boolean IsAutoSplit;
        public Decimal TotalDepth;
        public Decimal TotalHeight;
        public Decimal TotalWidth;
>>>>>>> refs/remotes/LinnSystems/master
    }
}
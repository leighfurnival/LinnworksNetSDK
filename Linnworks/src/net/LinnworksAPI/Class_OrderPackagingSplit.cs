using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class OrderPackagingSplit
    {
        public Guid pkBinId;
        public Guid pkPostalServiceId;
        public double PackagingWeight;
        public Guid fkPackagingTypeId;
        public List<OrderPackagingSplitItem> Items;
        public double TotalWeight;
        public string TrackingNumbers;
    }
}
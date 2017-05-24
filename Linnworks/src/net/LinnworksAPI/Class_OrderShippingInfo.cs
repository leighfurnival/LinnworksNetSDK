using System;

namespace LinnworksAPI
{
    [Serializable]
    public class OrderShippingInfo
    {
        public string Vendor;
        public Guid PostalServiceId;
        public string PostalServiceName;
        public double TotalWeight;
        public double ItemWeight;
        public Guid PackageCategoryId;
        public string PackageCategory;
        public Guid? PackageTypeId;
        public string PackageType;
        public double PostageCost;
        public double PostageCostExTax;
        public string TrackingNumber;
        public bool ManualAdjust;
    }
}
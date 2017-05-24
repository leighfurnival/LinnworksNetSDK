using System;

namespace LinnworksAPI
{
    public class PackageType
    {
        public Guid PackageTypeId;
        public Guid PackageGroupId;
        public string PackageTitle;
        public double FromGramms;
        public double ToGramms;
        public double PackagingWeight;
        public double PackagingCapacity;
        public Guid Rowguid;
        public double Width;
        public double Height;
        public double Depth;
    }
}
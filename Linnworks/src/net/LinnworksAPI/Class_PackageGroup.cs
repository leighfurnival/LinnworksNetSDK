using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class PackageGroup
    {
        public Guid PackageCategoryID;
        public string PackageCategory;
        public Guid rowguid;
        public List<PackageType> PackageTypes;
    }
}
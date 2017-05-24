using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class VariationGroupTemplate
    {
        public string VariationGroupName;
        public string ParentSKU;
        public Guid ParentStockItemId;
        public List<Guid> VariationItemIds;
    }
}
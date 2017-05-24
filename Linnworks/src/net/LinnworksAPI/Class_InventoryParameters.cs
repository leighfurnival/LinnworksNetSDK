using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class InventoryParameters
    {
        public List<Guid> InventoryItemIds;
        public List<Tuple<int, int>> SelectedRegions;
        public Guid Token;
    }
}
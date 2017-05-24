using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class PortionResult<InventoryItem>
    {
        public List<InventoryItem> Items;
        public int TotalItems;
        public int StartIndex;
        public Guid Token;
    }
}
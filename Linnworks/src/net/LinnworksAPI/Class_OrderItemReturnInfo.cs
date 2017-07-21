using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    //ReSharper disable UnusedMember.Global
    public class OrderItemReturnInfo
    {
        public Guid fkOrderItemRowId;
        public Guid ParentRowId;
        public int ReturnableQty;
        public int OrderQty;
        public int ReturnedQty;
        public string SKU;
        public string ItemTitle;
        public double UnitValue;
        public double TaxRate;
        public bool TaxCostInclusive;
        public string Currency;
        public bool IsCompositeParent;
        public bool IsPartialCompositeReturn;
        public int ParentRatio;
        public List<OrderItemReturnInfo> ChildItems;
        public Guid? pkStockItemId;
        public int ResentQty;
    }
}
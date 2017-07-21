using System;
//ReSharper disable UnusedMember.Global
namespace LinnworksAPI
{
    public class CalcOrderItem
    {
        public Guid fkStockItemId;
        public Guid fkOrderItemId;
        public string SKU;
        public int nQty;
        public double ItemWeight;
        public double DimHeight;
        public double DimWidth;
        public double DimDepth;
        public Guid PackageGroup;
        public Guid? fkCompositeParentRowId;
    }
}
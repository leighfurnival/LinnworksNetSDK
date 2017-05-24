using System;

namespace LinnworksAPI
{
    public class OrderRelation
    {
        public int ChildOrderId;
        public Guid ChildOrderPkOrderId;
        public int ParentOrderId;
        public Guid ParentOrderPkOrderId;
        public string RelationType;
    }
}
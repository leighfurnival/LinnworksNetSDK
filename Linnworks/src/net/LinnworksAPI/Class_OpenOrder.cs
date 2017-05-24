using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    [Serializable]
    public class OpenOrder
    {
        public string ORDER_NOT_FOUND_ERROR;
        public Guid OrderId;
        public int NumOrderId;
        public OrderGeneralInfo GeneralInfo;
        public OrderShippingInfo ShippingInfo;
        public OrderCustomerInfo CustomerInfo;
        public OrderTotalsInfo TotalsInfo;
        public List<string> FolderName;
        public List<OrderItem> Items;
    }
}
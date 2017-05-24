using System;

namespace LinnworksAPI
{
    [Serializable]
    public class OrderCustomerInfo
    {
        public string ChannelBuyerName;
        public CustomerAddress Address;
        public Address BillingAddress;
    }
}
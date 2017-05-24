using System;

namespace LinnworksAPI
{
    [Serializable]
    public class OrderItemOption
    {
        public Guid pkOptionId;
        public string Property;
        public string Value;
    }
}
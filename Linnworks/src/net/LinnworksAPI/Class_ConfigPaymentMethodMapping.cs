using System.Collections.Generic;

namespace LinnworksAPI
{
    public class ConfigPaymentMethodMapping
    {
        public List<ConfigPaymentMethodMappingItem> Mapping;
        public List<ChannelPaymentMethod> ChannelServices;
        public bool IsChanged;
    }
}
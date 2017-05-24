using System.Collections.ObjectModel;

namespace LinnworksAPI
{
    public class ConfigPostalServiceMapping
    {
        public ReadOnlyCollection<ConfigPostalServiceMappingItem> Mapping;
        public ReadOnlyCollection<ChannelPostalService> ChannelServices;
        public bool IsChanged;
    }
}
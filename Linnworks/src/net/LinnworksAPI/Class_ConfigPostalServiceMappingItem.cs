using System;

namespace LinnworksAPI
{
    public class ConfigPostalServiceMappingItem
    {
        public int fkChannelId;
        public int pkRowId;
        public string Tag;
        public Guid fkPostalServiceId;
        public string PostalServiceName;
        public string Site;
        public bool IsChanged;
    }
}
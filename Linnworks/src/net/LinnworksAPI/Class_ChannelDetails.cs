using System.Collections.Generic;

namespace LinnworksAPI
{
    public class ChannelDetails
    {
        public int LinksCount;
        public List<InventoryListingTemplate> Templates;
        public List<FieldTypes> Changes;
        public bool ContainsChanges;
    }
}
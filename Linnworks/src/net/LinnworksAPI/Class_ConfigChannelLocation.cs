using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class ConfigChannelLocation
    {
        public int pkChannelLocationId;
        public bool Deleted;
        public string Identifier;
        public string Name;
        public Guid OrderDownloadLocation;
        public List<Guid> InventorySyncLocations;
    }
}
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class InventoryView
    {
        public Guid Id;
        public string Name;
        public ModeType Mode;
        public string Source;
        public string SubSource;
        public string CountryCode;
        public string CountryName;
        public ListingType Listing;
        public bool ShowOnlyChanged;
        public IncludeArchived IncludeProducts;
        public List<Filter> Filters;
        public List<Column> Columns;
        public List<Channel> Channels;
    }
}
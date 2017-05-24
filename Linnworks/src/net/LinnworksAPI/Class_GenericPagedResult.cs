using System.Collections.Generic;

namespace LinnworksAPI
{
    public class GenericPagedResult<VariationGroup>
    {
        public int PageNumber;
        public int EntriesPerPage;
        public int TotalEntries;
        public int TotalPages;
        public List<VariationGroup> Data;
    }
}
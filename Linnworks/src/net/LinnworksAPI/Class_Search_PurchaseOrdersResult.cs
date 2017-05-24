using System.Collections.Generic;

namespace LinnworksAPI
{
    public class Search_PurchaseOrdersResult
    {
        public List<PurchaseOrderHeader> Result;
        public int TotalPages;
        public int CurrentPageNumber;
        public int EntriesPerPage;
        public int TotalNumberOfRecords;
    }
}
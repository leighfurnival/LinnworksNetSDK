using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Search_PurchaseOrders result class. Contains the Result - the list of returned purchase order headers, and current paging information 
    /// </summary>
    public class Search_PurchaseOrdersResult
	{
        /// <summary>
        /// List of purchase order headers 
        /// </summary>
		public List<PurchaseOrderHeader> Result;

        /// <summary>
        /// Total number of pages 
        /// </summary>
		public Int32 TotalPages;

        /// <summary>
        /// Currently request page number 
        /// </summary>
		public Int32 CurrentPageNumber;

        /// <summary>
        /// Requested entries per page 
        /// </summary>
		public Int32 EntriesPerPage;

        /// <summary>
        /// Total number of records matching the search request 
        /// </summary>
		public Int32 TotalNumberOfRecords;
	} 
}
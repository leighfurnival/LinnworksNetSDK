using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Single purchase order class. 
    /// </summary>
    public class Get_PurchaseOrderResponse
	{
        /// <summary>
        /// Purchase order header 
        /// </summary>
		public PurchaseOrderHeader PurchaseOrderHeader;

        /// <summary>
        /// Purchase order items 
        /// </summary>
		public List<PurchaseOrderItem> PurchaseOrderItem;

        /// <summary>
        /// Count of notes on the purchase order 
        /// </summary>
		public List<PurchaseOrderAdditionalCost> AdditionalCosts;

		public Int32 NoteCount;

        /// <summary>
        /// Purchase order payment statements 
        /// </summary>
		public List<PurchaseOrderPaymentStatement> PaymentStatements;

        /// <summary>
        /// Purchase order delivered records 
        /// </summary>
		public List<PurchaseOrderDeliveredRecord> DeliveredRecords;
	} 
}
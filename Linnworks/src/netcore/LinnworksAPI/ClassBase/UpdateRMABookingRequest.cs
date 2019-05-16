using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateRMABookingRequest
	{
        /// <summary>
        /// The unique identifier for the order the return lines pertain to 
        /// </summary>
		public Guid OrderId;

        /// <summary>
        /// The unique identifier for the RMA header to update 
        /// </summary>
		public Int32 RMAHeaderId;

        /// <summary>
        /// A collection of updated return items 
        /// </summary>
		public List<UpdatedReturnItem> ReturnItems;

        /// <summary>
        /// A collection of updated exchange items 
        /// </summary>
		public List<UpdatedExchangeItem> ExchangeItems;

        /// <summary>
        /// A collection of updated resend items 
        /// </summary>
		public List<UpdatedResendItem> ResendItems;

        /// <summary>
        /// If an existing RMA order has been deleted or cancelled, this flag determines whether a new one should be created, or an error should be returned 
        /// </summary>
		public Boolean AllowCreationOfNewOrder;
	} 
}
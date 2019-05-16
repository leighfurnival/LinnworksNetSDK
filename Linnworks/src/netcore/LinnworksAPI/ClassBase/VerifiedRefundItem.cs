using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class VerifiedRefundItem
	{
        /// <summary>
        /// The unique order item identifier 
        /// </summary>
		public Guid OrderItemRowId;

        /// <summary>
        /// A unique identifier for the return line this refund relates to. If null, it is an independent refund 
        /// </summary>
		public Int32? ReturnRowId;

        /// <summary>
        /// The Linnworks SKU for the item, assuming it is linked. If it is not, this matches the channel SKU 
        /// </summary>
		public String ItemSKU;

        /// <summary>
        /// The channel's SKU for the item 
        /// </summary>
		public String ChannelSKU;

        /// <summary>
        /// For a linked item, the Linnworks item title for this channel (or the default item title where a specific channel title does not exist). For an unlinked item, this is the title
        /// provided by the channel 
        /// </summary>
		public String ItemTitle;

        /// <summary>
        /// The tax-inclusive cost for this line 
        /// </summary>
		public Decimal Cost;

        /// <summary>
        /// If a refund is linked to a cancellation request, this field denotes the amount of the item cancelled 
        /// </summary>
		public Int32 CancelledQuantity;
	} 
}
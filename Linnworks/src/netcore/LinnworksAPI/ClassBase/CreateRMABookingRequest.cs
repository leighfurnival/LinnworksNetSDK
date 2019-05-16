using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreateRMABookingRequest
	{
        /// <summary>
        /// Determines whether the RMA request was initiated on the channel, or within Linnworks 
        /// </summary>
		public Boolean ChannelInitiated;

        /// <summary>
        /// The unique identifier for the order a return booking is being created for 
        /// </summary>
		public Guid OrderId;

        /// <summary>
        /// A collection of items to be returned as part of this booking 
        /// </summary>
		public List<ReturnItem> ReturnItems;

        /// <summary>
        /// A collection of items to be exchanged as part of this booking 
        /// </summary>
		public List<ExchangeItem> ExchangeItems;

        /// <summary>
        /// A collection of items to be resent as part of this booking 
        /// </summary>
		public List<ResendItem> ResendItems;
	} 
}
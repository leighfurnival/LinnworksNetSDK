using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderCustomerInfo
	{
        /// <summary>
        /// Username of customer (Comes from channel) 
        /// </summary>
		public String ChannelBuyerName;

        /// <summary>
        /// Customer address 
        /// </summary>
		public CustomerAddress Address;

        /// <summary>
        /// Customer billing address 
        /// </summary>
		public CustomerAddress BillingAddress;
	} 
}
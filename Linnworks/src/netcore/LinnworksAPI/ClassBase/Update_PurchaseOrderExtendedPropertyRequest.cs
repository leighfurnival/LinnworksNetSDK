using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Update_PurchaseOrderExtendedPropertyRequest
	{
        /// <summary>
        /// Purchase order uniqueidentifier 
        /// </summary>
		public Guid PurchaseId;

        /// <summary>
        /// items to update 
        /// </summary>
		public List<Update_PurchaseOrderExtendedPropertyItem> ExtendedPropertyItems;
	} 
}
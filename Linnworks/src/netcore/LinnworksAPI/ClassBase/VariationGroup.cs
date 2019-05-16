using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class VariationGroup
	{
        /// <summary>
        /// Variation parent SKU 
        /// </summary>
		public String VariationSKU;

        /// <summary>
        /// Variation parent ID (unique identifier) 
        /// </summary>
		public Guid pkVariationItemId;

        /// <summary>
        /// Variation parent title 
        /// </summary>
		public String VariationGroupName;
	} 
}
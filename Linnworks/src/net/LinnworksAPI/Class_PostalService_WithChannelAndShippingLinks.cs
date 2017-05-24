using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class PostalService_WithChannelAndShippingLinks
    {
        public Guid id;
        public bool hasMappedShippingService;
        public IEnumerable<Channel> Channels;
        public IEnumerable<ShippingService> ShippingServices;
        public string PostalServiceName;
        public string PostalServiceTag;
        public string ServiceCountry;
        public string PostalServiceCode;
        public string Vendor;
        public string PrintModule;
        public string PrintModuleTitle;
        public Guid pkPostalServiceId;
        public bool TrackingNumberRequired;
        public bool WeightRequired;
        public bool IgnorePackagingGroup;
        public int fkShippingAPIConfigId;
        public Guid? IntegratedServiceId;
    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class PostalServicesMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static List<PostalService_WithChannelAndShippingLinks> GetPostalServices(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<PostalService_WithChannelAndShippingLinks>>(Factory.GetResponse("PostalServices/GetPostalServices", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static PostalService CreatePostalService(PostalService_WithChannelAndShippingLinks PostalServiceDetails, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<PostalService>(Factory.GetResponse("PostalServices/CreatePostalService", "PostalServiceDetails=" + JsonConvert.SerializeObject(PostalServiceDetails, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void UpdatePostalService(PostalService PostalServiceDetails, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("PostalServices/UpdatePostalService", "PostalServiceDetails=" + JsonConvert.SerializeObject(PostalServiceDetails, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeletePostalService(Guid idToDelete, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("PostalServices/DeletePostalService", "idToDelete=" + idToDelete + "", ApiToken, ApiServer);
        }

        public static List<ChannelServiceLinks> GetChannelLinks(Guid postalServiceId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<ChannelServiceLinks>>(Factory.GetResponse("PostalServices/GetChannelLinks", "postalServiceId=" + postalServiceId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}
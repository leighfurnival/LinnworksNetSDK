using Newtonsoft.Json;
using System;

namespace LinnworksAPI
{
    public static class LocationsMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static StockLocation GetLocation(Guid pkStockLocationId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<StockLocation>(Factory.GetResponse("Locations/GetLocation", "pkStockLocationId=" + pkStockLocationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void AddLocation(StockLocation location, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Locations/AddLocation", "location=" + JsonConvert.SerializeObject(location, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateLocation(StockLocation location, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Locations/UpdateLocation", "location=" + JsonConvert.SerializeObject(location, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteLocation(Guid pkStockLocationId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Locations/DeleteLocation", "pkStockLocationId=" + pkStockLocationId + "", ApiToken, ApiServer);
        }
    }
}
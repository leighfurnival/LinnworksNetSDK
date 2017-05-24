using Newtonsoft.Json;

namespace LinnworksAPI
{
    public static class CustomerMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static void CreateNewCustomer(CustomerAddress customerDetails, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Customer/CreateNewCustomer", "customerDetails=" + JsonConvert.SerializeObject(customerDetails, serializerSettings) + "", ApiToken, ApiServer);
        }
    }
}
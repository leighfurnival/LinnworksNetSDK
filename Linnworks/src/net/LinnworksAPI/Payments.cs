using Newtonsoft.Json;

namespace LinnworksAPI
{
    public static class PaymentsMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static CheckoutData GetCheckoutInformation(CheckoutRequest Request, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<CheckoutData>(Factory.GetResponse("Payments/GetCheckoutInformation", "Request=" + JsonConvert.SerializeObject(Request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static PaymentResponse CompleteCheckoutPayment(PaymentRequest Request, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<PaymentResponse>(Factory.GetResponse("Payments/CompleteCheckoutPayment", "Request=" + JsonConvert.SerializeObject(Request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}
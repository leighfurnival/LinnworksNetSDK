using Newtonsoft.Json;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class SettingsMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static List<CurrencyConversionRate> GetCurrencyConversionRates(GetConversionRatesRequest requestParams, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<CurrencyConversionRate>>(Factory.GetResponse("Settings/GetCurrencyConversionRates", "requestParams=" + JsonConvert.SerializeObject(requestParams, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void UpdateCurrencyConversionRates(List<CurrencyConversionRate> rates, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Settings/UpdateCurrencyConversionRates", "rates=" + JsonConvert.SerializeObject(rates, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void InsertCurrencyConversionRates(List<CurrencyConversionRate> rates, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Settings/InsertCurrencyConversionRates", "rates=" + JsonConvert.SerializeObject(rates, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteCurrencyConversionRates(List<string> currencies, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Settings/DeleteCurrencyConversionRates", "currencies=" + JsonConvert.SerializeObject(currencies, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static Measures GetMeasures(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Measures>(Factory.GetResponse("Settings/GetMeasures", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}
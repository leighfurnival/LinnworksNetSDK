using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class DashboardsMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static List<LowStockLevel> GetLowStockLevel(Guid? locationId, int? numRows, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<LowStockLevel>>(Factory.GetResponse("Dashboards/GetLowStockLevel", "locationId=" + JsonConvert.SerializeObject(locationId, serializerSettings) + "&numRows=" + JsonConvert.SerializeObject(numRows, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PerfomanceData> GetPerformanceTableData(int period, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<PerfomanceData>>(Factory.GetResponse("Dashboards/GetPerformanceTableData", "period=" + period + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Dictionary<string, List<PerfomanceDetail>> GetPerformanceDetail(int period, int timeScale, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Dictionary<string, List<PerfomanceDetail>>>(Factory.GetResponse("Dashboards/GetPerformanceDetail", "period=" + period + "&timeScale=" + timeScale + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<TopProductData> GetTopProducts(TopProductsType type, int period, int numRows, int orderStatus, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<TopProductData>>(Factory.GetResponse("Dashboards/GetTopProducts", "type=" + type + "&period=" + period + "&numRows=" + numRows + "&orderStatus=" + orderStatus + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockItemLocation> GetInventoryLocationData(DateTime? date, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockItemLocation>>(Factory.GetResponse("Dashboards/GetInventoryLocationData", "date=" + JsonConvert.SerializeObject(date, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockCategoryLocation> GetInventoryLocationCategoriesData(DateTime? date, Guid locationId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<StockCategoryLocation>>(Factory.GetResponse("Dashboards/GetInventoryLocationCategoriesData", "date=" + JsonConvert.SerializeObject(date, serializerSettings) + "&locationId=" + locationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static PagedStockCategoryLocationProductResult GetInventoryLocationProductsData(DateTime? date, Guid locationId, Guid categoryId, int pageNumber, int entriesPerPage, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<PagedStockCategoryLocationProductResult>(Factory.GetResponse("Dashboards/GetInventoryLocationProductsData", "date=" + JsonConvert.SerializeObject(date, serializerSettings) + "&locationId=" + locationId + "&categoryId=" + categoryId + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static CustomScriptResult ExecuteCustomScriptQuery(string script, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<CustomScriptResult>(Factory.GetResponse("Dashboards/ExecuteCustomScriptQuery", "script=" + script + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static CustomScriptResult ExecuteCustomPagedScript(int scriptId, ScriptParameter parameters, int entriesPerPage, int pageNumber, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<CustomScriptResult>(Factory.GetResponse("Dashboards/ExecuteCustomPagedScript", "scriptId=" + scriptId + "&parameters=" + JsonConvert.SerializeObject(parameters, serializerSettings) + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}
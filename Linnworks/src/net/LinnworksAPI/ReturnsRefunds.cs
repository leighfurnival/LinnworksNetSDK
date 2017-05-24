using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class ReturnsRefundsMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static List<RefundOrder> GetRefundOrders(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<RefundOrder>>(Factory.GetResponse("ReturnsRefunds/GetRefundOrders", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<RefundInfo> GetRefunds(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<RefundInfo>>(Factory.GetResponse("ReturnsRefunds/GetRefunds", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<BookedReturnsExchangeOrder> GetBookedReturnsExchangeOrders(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<BookedReturnsExchangeOrder>>(Factory.GetResponse("ReturnsRefunds/GetBookedReturnsExchangeOrders", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<BookedReturnsExchangeItem> GetBookedReturnsExchangeItems(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<BookedReturnsExchangeItem>>(Factory.GetResponse("ReturnsRefunds/GetBookedReturnsExchangeItems", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void DeleteBookedOrder(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("ReturnsRefunds/DeleteBookedOrder", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer);
        }

        public static void ActionBookedOrder(Guid pkOrderId, List<BookedReturnsExchangeItem> bookedItems, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("ReturnsRefunds/ActionBookedOrder", "pkOrderId=" + pkOrderId + "&bookedItems=" + JsonConvert.SerializeObject(bookedItems, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteBookedItem(Guid pkOrderId, int pkReturnId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("ReturnsRefunds/DeleteBookedItem", "pkOrderId=" + pkOrderId + "&pkReturnId=" + pkReturnId + "", ApiToken, ApiServer);
        }

        public static void RefundOrder(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("ReturnsRefunds/RefundOrder", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer);
        }

        public static List<WarehouseLocation> GetWarehouseLocations(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<WarehouseLocation>>(Factory.GetResponse("ReturnsRefunds/GetWarehouseLocations", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void EditBookedItemInfo(Guid pkOrderId, BookedReturnsExchangeItem bookedReturnsExchangeItem, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("ReturnsRefunds/EditBookedItemInfo", "pkOrderId=" + pkOrderId + "&bookedReturnsExchangeItem=" + JsonConvert.SerializeObject(bookedReturnsExchangeItem, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeletePendingRefundItem(Guid fkOrderId, Guid pkRefundRowId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("ReturnsRefunds/DeletePendingRefundItem", "fkOrderId=" + fkOrderId + "&pkRefundRowId=" + pkRefundRowId + "", ApiToken, ApiServer);
        }

        public static double GetTotalRefunds(Guid fkOrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<double>(Factory.GetResponse("ReturnsRefunds/GetTotalRefunds", "fkOrderId=" + fkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static GenericPagedResult<ReturnsRefundsWeb> SearchReturnsRefundsPaged(DateTime? from, DateTime? to, ReturnsRefundsSearchDateType dateType, string searchField, bool exactMatch, string searchTerm, int pageNum, int numEntriesPerPage, HistoryType historyType, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<GenericPagedResult<ReturnsRefundsWeb>>(Factory.GetResponse("ReturnsRefunds/SearchReturnsRefundsPaged", "from=" + JsonConvert.SerializeObject(from, serializerSettings) + "&to=" + JsonConvert.SerializeObject(to, serializerSettings) + "&dateType=" + JsonConvert.SerializeObject(dateType, serializerSettings) + "&searchField=" + searchField + "&exactMatch=" + exactMatch + "&searchTerm=" + searchTerm + "&pageNum=" + pageNum + "&numEntriesPerPage=" + numEntriesPerPage + "&historyType=" + JsonConvert.SerializeObject(historyType, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static string CreateReturnsRefundsCSV(DateTime? from, DateTime? to, ReturnsRefundsSearchDateType dateType, string searchField, bool exactMatch, string searchTerm, string sortColumn, bool sortDirection, HistoryType historyType, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<string>(Factory.GetResponse("ReturnsRefunds/CreateReturnsRefundsCSV", "from=" + JsonConvert.SerializeObject(from, serializerSettings) + "&to=" + JsonConvert.SerializeObject(to, serializerSettings) + "&dateType=" + JsonConvert.SerializeObject(dateType, serializerSettings) + "&searchField=" + searchField + "&exactMatch=" + exactMatch + "&searchTerm=" + searchTerm + "&sortColumn=" + sortColumn + "&sortDirection=" + sortDirection + "&historyType=" + JsonConvert.SerializeObject(historyType, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<SearchField> GetSearchTypes(HistoryType historyType, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<SearchField>>(Factory.GetResponse("ReturnsRefunds/GetSearchTypes", "historyType=" + JsonConvert.SerializeObject(historyType, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}
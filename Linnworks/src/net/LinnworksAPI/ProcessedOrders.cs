using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class ProcessedOrdersMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static List<RefundInfo> RefundFreeText(Guid pkOrderId, List<RefundItem> refundItems, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<RefundInfo>>(Factory.GetResponse("ProcessedOrders/RefundFreeText", "pkOrderId=" + pkOrderId + "&refundItems=" + JsonConvert.SerializeObject(refundItems, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<RefundInfo> RefundShipping(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<RefundInfo>>(Factory.GetResponse("ProcessedOrders/RefundShipping", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void MarkManualRefundsAsActioned(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("ProcessedOrders/MarkManualRefundsAsActioned", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer);
        }

        public static List<RefundInfo> RefundServices(Guid pkOrderId, List<RefundItem> refundItems, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<RefundInfo>>(Factory.GetResponse("ProcessedOrders/RefundServices", "pkOrderId=" + pkOrderId + "&refundItems=" + JsonConvert.SerializeObject(refundItems, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<RefundInfo> RefundCompleteOrder(Guid pkOrderId, bool isManualRefund, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<RefundInfo>>(Factory.GetResponse("ProcessedOrders/RefundCompleteOrder", "pkOrderId=" + pkOrderId + "&isManualRefund=" + isManualRefund + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static ValidationResult ValidateCompleteOrderRefund(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<ValidationResult>(Factory.GetResponse("ProcessedOrders/ValidateCompleteOrderRefund", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static RefundScreenOptions GetRefundsOptions(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<RefundScreenOptions>(Factory.GetResponse("ProcessedOrders/GetRefundsOptions", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<ServiceItem> GetRefundableServiceItems(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<ServiceItem>>(Factory.GetResponse("ProcessedOrders/GetRefundableServiceItems", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static ExistingRefundTotal GetTotalRefunds(Guid pkOrderId, bool? includeBookings, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<ExistingRefundTotal>(Factory.GetResponse("ProcessedOrders/GetTotalRefunds", "pkOrderId=" + pkOrderId + "&includeBookings=" + JsonConvert.SerializeObject(includeBookings, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static ValidationResult IsRefundValid(Guid pkOrderId, List<RefundItem> refundItems, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<ValidationResult>(Factory.GetResponse("ProcessedOrders/IsRefundValid", "pkOrderId=" + pkOrderId + "&refundItems=" + JsonConvert.SerializeObject(refundItems, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static bool IsRefundValidationRequiredByOrderId(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<bool>(Factory.GetResponse("ProcessedOrders/IsRefundValidationRequiredByOrderId", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<ChannelRefundReason> GetChannelRefundReasons(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<ChannelRefundReason>>(Factory.GetResponse("ProcessedOrders/GetChannelRefundReasons", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<ReturnInfo> GetReturnsExchanges(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<ReturnInfo>>(Factory.GetResponse("ProcessedOrders/GetReturnsExchanges", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<OrderItemReturnInfo> GetReturnItemsInfo(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<OrderItemReturnInfo>>(Factory.GetResponse("ProcessedOrders/GetReturnItemsInfo", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static ReturnOrderHeader GetReturnOrderInfo(Guid pkOrderId, bool includeRefundLink, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<ReturnOrderHeader>(Factory.GetResponse("ProcessedOrders/GetReturnOrderInfo", "pkOrderId=" + pkOrderId + "&includeRefundLink=" + includeRefundLink + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static ProcessedOrderWeb GetOrderInfo(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<ProcessedOrderWeb>(Factory.GetResponse("ProcessedOrders/GetOrderInfo", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static GenericPagedResult<ProcessedOrderWeb> SearchProcessedOrdersPaged(DateTime? from, DateTime? to, SearchDateType dateType, string searchField, bool exactMatch, string searchTerm, int pageNum, int numEntriesPerPage, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<GenericPagedResult<ProcessedOrderWeb>>(Factory.GetResponse("ProcessedOrders/SearchProcessedOrdersPaged", "from=" + JsonConvert.SerializeObject(from, serializerSettings) + "&to=" + JsonConvert.SerializeObject(to, serializerSettings) + "&dateType=" + JsonConvert.SerializeObject(dateType, serializerSettings) + "&searchField=" + searchField + "&exactMatch=" + exactMatch + "&searchTerm=" + searchTerm + "&pageNum=" + pageNum + "&numEntriesPerPage=" + numEntriesPerPage + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static string CreateProcessedOrdersCSV(DateTime? from, DateTime? to, SearchDateType dateType, string searchField, bool exactMatch, string searchTerm, string sortColumn, bool sortDirection, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<string>(Factory.GetResponse("ProcessedOrders/CreateProcessedOrdersCSV", "from=" + JsonConvert.SerializeObject(from, serializerSettings) + "&to=" + JsonConvert.SerializeObject(to, serializerSettings) + "&dateType=" + JsonConvert.SerializeObject(dateType, serializerSettings) + "&searchField=" + searchField + "&exactMatch=" + exactMatch + "&searchTerm=" + searchTerm + "&sortColumn=" + sortColumn + "&sortDirection=" + sortDirection + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static OrderReturnCategory AddReturnCategory(string categoryName, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<OrderReturnCategory>(Factory.GetResponse("ProcessedOrders/AddReturnCategory", "categoryName=" + categoryName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void RenameReturnCategory(int pkItemId, string newName, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("ProcessedOrders/RenameReturnCategory", "pkItemId=" + pkItemId + "&newName=" + newName + "", ApiToken, ApiServer);
        }

        public static void DeleteReturnCategory(int pkItemId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("ProcessedOrders/DeleteReturnCategory", "pkItemId=" + pkItemId + "", ApiToken, ApiServer);
        }

        public static List<OrderRelation> GetProcessedRelatives(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<OrderRelation>>(Factory.GetResponse("ProcessedOrders/GetProcessedRelatives", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<SplitPackaging> GetPackageSplit(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<SplitPackaging>>(Factory.GetResponse("ProcessedOrders/GetPackageSplit", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<AuditEntry> GetProcessedAuditTrail(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<AuditEntry>>(Factory.GetResponse("ProcessedOrders/GetProcessedAuditTrail", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<OrderExtendedProperty> GetProcessedOrderExtendedProperties(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<OrderExtendedProperty>>(Factory.GetResponse("ProcessedOrders/GetProcessedOrderExtendedProperties", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<OrderReturnCategory> GetReturnCategories(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<OrderReturnCategory>>(Factory.GetResponse("ProcessedOrders/GetReturnCategories", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<OrderNote> GetProcessedOrderNotes(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<OrderNote>>(Factory.GetResponse("ProcessedOrders/GetProcessedOrderNotes", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Guid AddOrderNote(Guid pkOrderID, string noteText, bool isInternal, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Guid>(Factory.GetResponse("ProcessedOrders/AddOrderNote", "pkOrderID=" + pkOrderID + "&noteText=" + noteText + "&isInternal=" + isInternal + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<ReturnInfo> CreateReturn(Guid pkOrderId, List<RowQty> returnitems, Guid returnLocation, string channelReason, string channelSubReason, string category, string reason, bool isReturnBooking, bool ignoredValidation, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<ReturnInfo>>(Factory.GetResponse("ProcessedOrders/CreateReturn", "pkOrderId=" + pkOrderId + "&returnitems=" + JsonConvert.SerializeObject(returnitems, serializerSettings) + "&returnLocation=" + returnLocation + "&channelReason=" + channelReason + "&channelSubReason=" + channelSubReason + "&category=" + category + "&reason=" + reason + "&isReturnBooking=" + isReturnBooking + "&ignoredValidation=" + ignoredValidation + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void ChangeOrderNote(Guid pkOrderNoteId, string noteText, bool isInternal, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("ProcessedOrders/ChangeOrderNote", "pkOrderNoteId=" + pkOrderNoteId + "&noteText=" + noteText + "&isInternal=" + isInternal + "", ApiToken, ApiServer);
        }

        public static void DeleteOrderNote(Guid pkOrderNoteId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("ProcessedOrders/DeleteOrderNote", "pkOrderNoteId=" + pkOrderNoteId + "", ApiToken, ApiServer);
        }

        public static List<ReturnInfo> CreateExchange(Guid pkOrderId, List<RowQty> exchangeItems, Guid despatchLocation, Guid returnLocation, string channelReason, string channelSubReason, string category, string reason, bool isBooking, bool ignoredValidation, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<ReturnInfo>>(Factory.GetResponse("ProcessedOrders/CreateExchange", "pkOrderId=" + pkOrderId + "&exchangeItems=" + JsonConvert.SerializeObject(exchangeItems, serializerSettings) + "&despatchLocation=" + despatchLocation + "&returnLocation=" + returnLocation + "&channelReason=" + channelReason + "&channelSubReason=" + channelSubReason + "&category=" + category + "&reason=" + reason + "&isBooking=" + isBooking + "&ignoredValidation=" + ignoredValidation + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<ReturnInfo> CreateResend(Guid pkOrderId, List<RowQty> resendItems, Guid despatchLocation, string category, string reason, double additionalCost, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<ReturnInfo>>(Factory.GetResponse("ProcessedOrders/CreateResend", "pkOrderId=" + pkOrderId + "&resendItems=" + JsonConvert.SerializeObject(resendItems, serializerSettings) + "&despatchLocation=" + despatchLocation + "&category=" + category + "&reason=" + reason + "&additionalCost=" + additionalCost + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<ReturnInfo> CreateFullResend(Guid pkOrderId, Guid despatchLocation, string category, string reason, double additionalCost, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<ReturnInfo>>(Factory.GetResponse("ProcessedOrders/CreateFullResend", "pkOrderId=" + pkOrderId + "&despatchLocation=" + despatchLocation + "&category=" + category + "&reason=" + reason + "&additionalCost=" + additionalCost + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<RefundInfo> GetRefunds(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<RefundInfo>>(Factory.GetResponse("ProcessedOrders/GetRefunds", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static bool CheckOrderFullyReturned(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<bool>(Factory.GetResponse("ProcessedOrders/CheckOrderFullyReturned", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}
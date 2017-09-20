using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class OrdersMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static UserOrderView GetOrderView(int pkViewId, bool markAsLatestViewed, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<UserOrderView>(Factory.GetResponse("Orders/GetOrderView", "pkViewId=" + pkViewId + "&markAsLatestViewed=" + markAsLatestViewed + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void SaveOrderView(int pkViewId, string viewName, string OrderViewDetailJSON, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Orders/SaveOrderView", "pkViewId=" + pkViewId + "&viewName=" + viewName + "&OrderViewDetailJSON=" + OrderViewDetailJSON + "", ApiToken, ApiServer);
        }

        public static List<CustomerAddress> CustomerLookUp(string field, string txt, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<CustomerAddress>>(Factory.GetResponse("Orders/CustomerLookUp", "field=" + field + "&txt=" + txt + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<LinkedItem> GetLinkedItems(Guid itemId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<LinkedItem>>(Factory.GetResponse("Orders/GetLinkedItems", "itemId=" + itemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void UpdateLinkItem(Guid pkStockId, Guid pkStockItemId, string source, string subSource, string channelSKU, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Orders/UpdateLinkItem", "pkStockId=" + pkStockId + "&pkStockItemId=" + pkStockItemId + "&source=" + source + "&subSource=" + subSource + "&channelSKU=" + channelSKU + "", ApiToken, ApiServer);
        }

        public static Guid? CreateNewItemAndLink(Guid pkStockItemId, string itemTitle, string source, string subSource, string channelSKU, Guid? locationId, int? initialQuantity, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Guid?>(Factory.GetResponse("Orders/CreateNewItemAndLink", "pkStockItemId=" + pkStockItemId + "&itemTitle=" + itemTitle + "&source=" + source + "&subSource=" + subSource + "&channelSKU=" + channelSKU + "&locationId=" + JsonConvert.SerializeObject(locationId, serializerSettings) + "&initialQuantity=" + JsonConvert.SerializeObject(initialQuantity, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<OrderPackagingSplit> GetOrderPackagingSplit(Guid orderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<OrderPackagingSplit>>(Factory.GetResponse("Orders/GetOrderPackagingSplit", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static UpdateTotalsResult SetOrderPackagingSplit(Guid orderId, List<OrderPackagingSplit> packagingSplit, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<UpdateTotalsResult>(Factory.GetResponse("Orders/SetOrderPackagingSplit", "orderId=" + orderId + "&packagingSplit=" + JsonConvert.SerializeObject(packagingSplit, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Guid? GetOpenOrderIdByOrderOrReferenceId(string orderOrReferenceId, FieldsFilter filters, Guid? locationId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Guid?>(Factory.GetResponse("Orders/GetOpenOrderIdByOrderOrReferenceId", "orderOrReferenceId=" + orderOrReferenceId + "&filters=" + JsonConvert.SerializeObject(filters, serializerSettings) + "&locationId=" + JsonConvert.SerializeObject(locationId, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static KeyValuePair<OrderSummary, string> GetOpenOrderIdByOrderOrReferenceIdAndProcess(string orderOrReferenceId, Guid fulfilmentCenter, FieldsFilter filters, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<KeyValuePair<OrderSummary, string>>(Factory.GetResponse("Orders/GetOpenOrderIdByOrderOrReferenceIdAndProcess", "orderOrReferenceId=" + orderOrReferenceId + "&fulfilmentCenter=" + fulfilmentCenter + "&filters=" + JsonConvert.SerializeObject(filters, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static KeyValuePair<List<OrderSummary>, string> GetOpenOrdersByItemBarcode(string productBarcode, FieldsFilter filters, Guid? locationId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<KeyValuePair<List<OrderSummary>, string>>(Factory.GetResponse("Orders/GetOpenOrdersByItemBarcode", "productBarcode=" + productBarcode + "&filters=" + JsonConvert.SerializeObject(filters, serializerSettings) + "&locationId=" + JsonConvert.SerializeObject(locationId, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<OrderDetails> GetOrderDetailsByReferenceId(string ReferenceId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<OrderDetails>>(Factory.GetResponse("Orders/GetOrderDetailsByReferenceId", "ReferenceId=" + ReferenceId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static OrderDetails GetOrderDetailsByNumOrderId(int OrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<OrderDetails>(Factory.GetResponse("Orders/GetOrderDetailsByNumOrderId", "OrderId=" + OrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static OrderDetails GetOrderById(Guid pkOrderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<OrderDetails>(Factory.GetResponse("Orders/GetOrderById", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<OrderDetails> GetOrdersById(List<Guid> pkOrderIds, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<OrderDetails>>(Factory.GetResponse("Orders/GetOrdersById", "pkOrderIds=" + JsonConvert.SerializeObject(pkOrderIds, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<CalcOrderHeader> GetOrderPackagingCalculation(GetOrderPackagingCalculationRequest request, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<CalcOrderHeader>>(Factory.GetResponse("Orders/GetOrderPackagingCalculation", "request=" + JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static CalcOrderHeader RecalculateSingleOrderPackaging(CalcOrderHeader request, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<CalcOrderHeader>(Factory.GetResponse("Orders/RecalculateSingleOrderPackaging", "request=" + JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static CalcOrderHeader SetOrderSplitPackagingManualOverwrite(CalcOrderHeader request, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<CalcOrderHeader>(Factory.GetResponse("Orders/SetOrderSplitPackagingManualOverwrite", "request=" + JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static CalcOrderHeader SetOrderPackaging(SetOrderPackagingRequest request, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<CalcOrderHeader>(Factory.GetResponse("Orders/SetOrderPackaging", "request=" + JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Guid GetUserLocationId(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Guid>(Factory.GetResponse("Orders/GetUserLocationId", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void SetUserLocationId(Guid locationId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Orders/SetUserLocationId", "locationId=" + locationId + "", ApiToken, ApiServer);
        }

        public static GenericPagedResult<OpenOrder> GetOpenOrders(int entriesPerPage, int pageNumber, FieldsFilter filters, List<FieldSorting> sorting, Guid? fulfilmentCenter, string additionalFilter, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<GenericPagedResult<OpenOrder>>(Factory.GetResponse("Orders/GetOpenOrders", "entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "&filters=" + JsonConvert.SerializeObject(filters, serializerSettings) + "&sorting=" + JsonConvert.SerializeObject(sorting, serializerSettings) + "&fulfilmentCenter=" + JsonConvert.SerializeObject(fulfilmentCenter, serializerSettings) + "&additionalFilter=" + additionalFilter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<Guid> GetAllOpenOrders(FieldsFilter filters, List<FieldSorting> sorting, Guid fulfilmentCenter, string additionalFilter, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/GetAllOpenOrders", "filters=" + JsonConvert.SerializeObject(filters, serializerSettings) + "&sorting=" + JsonConvert.SerializeObject(sorting, serializerSettings) + "&fulfilmentCenter=" + fulfilmentCenter + "&additionalFilter=" + additionalFilter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<Guid> GetAllOpenOrdersBetweenIndex(int fromIndex, int toIndex, FieldsFilter filters, List<FieldSorting> sorting, Guid fulfilmentCenter, string additionalFilter, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/GetAllOpenOrdersBetweenIndex", "fromIndex=" + fromIndex + "&toIndex=" + toIndex + "&filters=" + JsonConvert.SerializeObject(filters, serializerSettings) + "&sorting=" + JsonConvert.SerializeObject(sorting, serializerSettings) + "&fulfilmentCenter=" + fulfilmentCenter + "&additionalFilter=" + additionalFilter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<Guid> SetLabelsPrinted(List<Guid> orderIds, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/SetLabelsPrinted", "orderIds=" + JsonConvert.SerializeObject(orderIds, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<Guid> SetInvoicesPrinted(List<Guid> orderIds, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/SetInvoicesPrinted", "orderIds=" + JsonConvert.SerializeObject(orderIds, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static OrderItem GetOrderItemComposition(Guid orderId, Guid stockItemId, Guid fulfilmentCenter, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<OrderItem>(Factory.GetResponse("Orders/GetOrderItemComposition", "orderId=" + orderId + "&stockItemId=" + stockItemId + "&fulfilmentCenter=" + fulfilmentCenter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<Guid> ChangeOrderTag(List<Guid> orderIds, int? tag, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/ChangeOrderTag", "orderIds=" + JsonConvert.SerializeObject(orderIds, serializerSettings) + "&tag=" + JsonConvert.SerializeObject(tag, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<OrderFolder> GetAvailableFolders(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<OrderFolder>>(Factory.GetResponse("Orders/GetAvailableFolders", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<OrderFolder> SetAvailableFolders(List<OrderFolder> folders, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<OrderFolder>>(Factory.GetResponse("Orders/SetAvailableFolders", "folders=" + JsonConvert.SerializeObject(folders, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<Guid> AssignToFolder(List<Guid> orderIds, string folder, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/AssignToFolder", "orderIds=" + JsonConvert.SerializeObject(orderIds, serializerSettings) + "&folder=" + folder + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<Guid> UnassignToFolder(List<Guid> orderIds, string folder, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/UnassignToFolder", "orderIds=" + JsonConvert.SerializeObject(orderIds, serializerSettings) + "&folder=" + folder + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static string GetOrderXmlJSTree(Guid orderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<string>(Factory.GetResponse("Orders/GetOrderXmlJSTree", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<OrderXML> GetOrderXml(Guid orderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<OrderXML>>(Factory.GetResponse("Orders/GetOrderXml", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<Guid> ChangeShippingMethod(List<Guid> orderIds, string shippingMethod, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/ChangeShippingMethod", "orderIds=" + JsonConvert.SerializeObject(orderIds, serializerSettings) + "&shippingMethod=" + shippingMethod + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<Guid> ChangeStatus(List<Guid> orderIds, int status, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/ChangeStatus", "orderIds=" + JsonConvert.SerializeObject(orderIds, serializerSettings) + "&status=" + status + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void LockOrder(List<Guid> orderIds, bool lockOrder, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Orders/LockOrder", "orderIds=" + JsonConvert.SerializeObject(orderIds, serializerSettings) + "&lockOrder=" + lockOrder + "", ApiToken, ApiServer);
        }

        public static void DeleteOrder(Guid orderId, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Orders/DeleteOrder", "orderId=" + orderId + "", ApiToken, ApiServer);
        }

        public static string CancelOrder(Guid orderId, Guid fulfilmentCenter, double refund, string note, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<string>(Factory.GetResponse("Orders/CancelOrder", "orderId=" + orderId + "&fulfilmentCenter=" + fulfilmentCenter + "&refund=" + refund + "&note=" + note + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static MoveToLocationResult MoveToLocation(List<Guid> orderIds, Guid pkStockLocationId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<MoveToLocationResult>(Factory.GetResponse("Orders/MoveToLocation", "orderIds=" + JsonConvert.SerializeObject(orderIds, serializerSettings) + "&pkStockLocationId=" + pkStockLocationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static MoveToFulfilmentCenterResult MoveToFulfilmentCenter(List<Guid> orderIds, Guid fulfilmentCenterId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<MoveToFulfilmentCenterResult>(Factory.GetResponse("Orders/MoveToFulfilmentCenter", "orderIds=" + JsonConvert.SerializeObject(orderIds, serializerSettings) + "&fulfilmentCenterId=" + fulfilmentCenterId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<KeyValuePair<Guid, string>> ClearShippingLabelInfo(List<Guid> orderIds, bool withoutConfirmation, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<KeyValuePair<Guid, string>>>(Factory.GetResponse("Orders/ClearShippingLabelInfo", "orderIds=" + JsonConvert.SerializeObject(orderIds, serializerSettings) + "&withoutConfirmation=" + withoutConfirmation + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<Guid> ClearInvoicePrinted(List<Guid> orderIds, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/ClearInvoicePrinted", "orderIds=" + JsonConvert.SerializeObject(orderIds, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<Guid> ClearPickListPrinted(List<Guid> orderIds, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/ClearPickListPrinted", "orderIds=" + JsonConvert.SerializeObject(orderIds, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<ShippingMethod> GetShippingMethods(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<ShippingMethod>>(Factory.GetResponse("Orders/GetShippingMethods", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PackageGroup> GetPackagingGroups(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<PackageGroup>>(Factory.GetResponse("Orders/GetPackagingGroups", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<ExtendedProperty> GetExtendedProperties(Guid orderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<ExtendedProperty>>(Factory.GetResponse("Orders/GetExtendedProperties", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<string> GetExtendedPropertyTypes(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<string>>(Factory.GetResponse("Orders/GetExtendedPropertyTypes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<ExtendedProperty> SetExtendedProperties(Guid orderId, ExtendedProperty extendedProperties, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<ExtendedProperty>>(Factory.GetResponse("Orders/SetExtendedProperties", "orderId=" + orderId + "&extendedProperties=" + JsonConvert.SerializeObject(extendedProperties, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<KeyValuePair<Guid, string>> GetBatchPilots(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<KeyValuePair<Guid, string>>>(Factory.GetResponse("Orders/GetBatchPilots", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static OpenOrder GetOrder(Guid orderId, Guid? fulfilmentLocationId, bool loadItems, bool loadAdditionalInfo, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<OpenOrder>(Factory.GetResponse("Orders/GetOrder", "orderId=" + orderId + "&fulfilmentLocationId=" + JsonConvert.SerializeObject(fulfilmentLocationId, serializerSettings) + "&loadItems=" + loadItems + "&loadAdditionalInfo=" + loadAdditionalInfo + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<OpenOrder> GetOrders(List<Guid> ordersIds, Guid? fulfilmentLocationId, bool loadItems, bool loadAdditionalInfo, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<OpenOrder>>(Factory.GetResponse("Orders/GetOrders", "ordersIds=" + JsonConvert.SerializeObject(ordersIds, serializerSettings) + "&fulfilmentLocationId=" + JsonConvert.SerializeObject(fulfilmentLocationId, serializerSettings) + "&loadItems=" + loadItems + "&loadAdditionalInfo=" + loadAdditionalInfo + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<OrderAuditTrail> GetOrderAuditTrail(Guid orderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<OrderAuditTrail>>(Factory.GetResponse("Orders/GetOrderAuditTrail", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<OrderNote> GetOrderNotes(Guid orderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<OrderNote>>(Factory.GetResponse("Orders/GetOrderNotes", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void SetOrderNotes(Guid orderId, List<OrderNote> orderNotes, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Orders/SetOrderNotes", "orderId=" + orderId + "&orderNotes=" + JsonConvert.SerializeObject(orderNotes, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<OrderRelation> GetOrderRelations(Guid orderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<OrderRelation>>(Factory.GetResponse("Orders/GetOrderRelations", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<OrderItem> GetOrderItems(Guid orderId, Guid fulfilmentCenter, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<OrderItem>>(Factory.GetResponse("Orders/GetOrderItems", "orderId=" + orderId + "&fulfilmentCenter=" + fulfilmentCenter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<KeyValuePair<Guid, Guid>> GetOpenOrderItemsSuppliers(Guid orderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<KeyValuePair<Guid, Guid>>>(Factory.GetResponse("Orders/GetOpenOrderItemsSuppliers", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static UpdateOrderItemResult AddOrderItem(Guid orderId, Guid itemId, string channelSKU, Guid fulfilmentCenter, int quantity, LinePricingRequest linePricing, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<UpdateOrderItemResult>(Factory.GetResponse("Orders/AddOrderItem", "orderId=" + orderId + "&itemId=" + itemId + "&channelSKU=" + channelSKU + "&fulfilmentCenter=" + fulfilmentCenter + "&quantity=" + quantity + "&linePricing=" + JsonConvert.SerializeObject(linePricing, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static UpdateOrderItemResult AddOrderService(Guid orderId, string service, double cost, double taxRate, Guid fulfilmentCenter, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<UpdateOrderItemResult>(Factory.GetResponse("Orders/AddOrderService", "orderId=" + orderId + "&service=" + service + "&cost=" + cost + "&taxRate=" + taxRate + "&fulfilmentCenter=" + fulfilmentCenter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static UpdateOrderItemResult UpdateOrderItem(Guid orderId, OrderItem orderItem, Guid fulfilmentCenter, string source, string subSource, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<UpdateOrderItemResult>(Factory.GetResponse("Orders/UpdateOrderItem", "orderId=" + orderId + "&orderItem=" + JsonConvert.SerializeObject(orderItem, serializerSettings) + "&fulfilmentCenter=" + fulfilmentCenter + "&source=" + source + "&subSource=" + subSource + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static UpdateOrderItemResult RemoveOrderItem(Guid orderId, Guid rowid, Guid fulfilmentCenter, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<UpdateOrderItemResult>(Factory.GetResponse("Orders/RemoveOrderItem", "orderId=" + orderId + "&rowid=" + rowid + "&fulfilmentCenter=" + fulfilmentCenter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<Country> GetCountries(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<Country>>(Factory.GetResponse("Orders/GetCountries", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PaymentMethod> GetPaymentMethods(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<PaymentMethod>>(Factory.GetResponse("Orders/GetPaymentMethods", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Guid GetDefaultPaymentMethodIdForNewOrder(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<Guid>(Factory.GetResponse("Orders/GetDefaultPaymentMethodIdForNewOrder", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void SetDefaultPaymentMethodIdForNewOrder(Guid paymentMethod, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Orders/SetDefaultPaymentMethodIdForNewOrder", "paymentMethod=" + paymentMethod + "", ApiToken, ApiServer);
        }

        public static List<PaymentMethod> SetPaymentMethods(PaymentMethod paymentMethods, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<PaymentMethod>>(Factory.GetResponse("Orders/SetPaymentMethods", "paymentMethods=" + JsonConvert.SerializeObject(paymentMethods, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static OpenOrder CreateNewOrder(Guid fulfilmentCenter, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<OpenOrder>(Factory.GetResponse("Orders/CreateNewOrder", "fulfilmentCenter=" + fulfilmentCenter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<Guid> GetDraftOrders(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/GetDraftOrders", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static string CompleteOrder(Guid orderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<string>(Factory.GetResponse("Orders/CompleteOrder", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<OpenOrder> SplitOrder(Guid orderId, OrderSplit newOrders, string type, Guid fulfilmentLocationId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<OpenOrder>>(Factory.GetResponse("Orders/SplitOrder", "orderId=" + orderId + "&newOrders=" + JsonConvert.SerializeObject(newOrders, serializerSettings) + "&type=" + type + "&fulfilmentLocationId=" + fulfilmentLocationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static OpenOrder MergeOrders(List<Guid> ordersToMerge, Guid fulfilmentCenter, Guid pkPostalServiceId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<OpenOrder>(Factory.GetResponse("Orders/MergeOrders", "ordersToMerge=" + JsonConvert.SerializeObject(ordersToMerge, serializerSettings) + "&fulfilmentCenter=" + fulfilmentCenter + "&pkPostalServiceId=" + pkPostalServiceId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static ProcessOrderResult ProcessOrder(Guid orderId, bool scanPerformed, Guid? locationId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<ProcessOrderResult>(Factory.GetResponse("Orders/ProcessOrder", "orderId=" + orderId + "&scanPerformed=" + scanPerformed + "&locationId=" + JsonConvert.SerializeObject(locationId, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<ProcessOrderResult> ProcessOrdersInBatch(List<Guid> ordersIds, Guid? locationId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<ProcessOrderResult>>(Factory.GetResponse("Orders/ProcessOrdersInBatch", "ordersIds=" + JsonConvert.SerializeObject(ordersIds, serializerSettings) + "&locationId=" + JsonConvert.SerializeObject(locationId, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static ProcessOrderResult ProcessFulfilmentCentreOrder(Guid orderId, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<ProcessOrderResult>(Factory.GetResponse("Orders/ProcessFulfilmentCentreOrder", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void SetOrderGeneralInfo(Guid orderId, OrderGeneralInfo info, bool wasDraft, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Orders/SetOrderGeneralInfo", "orderId=" + orderId + "&info=" + JsonConvert.SerializeObject(info, serializerSettings) + "&wasDraft=" + wasDraft + "", ApiToken, ApiServer);
        }

        public static UpdateTotalsResult SetOrderShippingInfo(Guid orderId, OrderShippingInfo info, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<UpdateTotalsResult>(Factory.GetResponse("Orders/SetOrderShippingInfo", "orderId=" + orderId + "&info=" + JsonConvert.SerializeObject(info, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void SetOrderCustomerInfo(Guid orderId, OrderCustomerInfo info, bool? saveToCrm, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Orders/SetOrderCustomerInfo", "orderId=" + orderId + "&info=" + JsonConvert.SerializeObject(info, serializerSettings) + "&saveToCrm=" + JsonConvert.SerializeObject(saveToCrm, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void SetOrderTotalsInfo(Guid orderId, OrderTotalsInfo info, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Orders/SetOrderTotalsInfo", "orderId=" + orderId + "&info=" + JsonConvert.SerializeObject(info, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static CouponValidationResult ValidateCoupon(Guid orderId, string barcode, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<CouponValidationResult>(Factory.GetResponse("Orders/ValidateCoupon", "orderId=" + orderId + "&barcode=" + barcode + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static UpdateOrderItemResult AddCoupon(Guid orderId, string barcode, CouponValidationResult couponData, Guid fulfilmentCenter, string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<UpdateOrderItemResult>(Factory.GetResponse("Orders/AddCoupon", "orderId=" + orderId + "&barcode=" + barcode + "&couponData=" + JsonConvert.SerializeObject(couponData, serializerSettings) + "&fulfilmentCenter=" + fulfilmentCenter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void UpdateBillingAddress(Guid orderId, Address billingAddress, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Orders/UpdateBillingAddress", "orderId=" + orderId + "&billingAddress=" + JsonConvert.SerializeObject(billingAddress, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void SetAdditionalInfo(Guid orderId, Guid rowId, OrderItemOption additionalInfo, string ApiToken, string ApiServer)
        {
            Factory.GetResponse("Orders/SetAdditionalInfo", "orderId=" + orderId + "&rowId=" + rowId + "&additionalInfo=" + JsonConvert.SerializeObject(additionalInfo, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<UserOrderView> GetOrderViews(string ApiToken, string ApiServer)
        {
            return JsonConvert.DeserializeObject<List<UserOrderView>>(Factory.GetResponse("Orders/GetOrderViews", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}
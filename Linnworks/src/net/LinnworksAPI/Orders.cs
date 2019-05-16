using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Xml;
using System.ComponentModel;
using System.Reflection;

namespace LinnworksAPI
{
	public static class OrdersMethods 
	{ 
		private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ"};
 		public static UpdateOrderItemResult AddCoupon(Guid orderId,String barcode,CouponValidationResult couponData,Guid fulfilmentCenter,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateOrderItemResult>(Factory.GetResponse("Orders/AddCoupon", "orderId=" + orderId + "&barcode=" + barcode + "&couponData=" + Newtonsoft.Json.JsonConvert.SerializeObject(couponData, serializerSettings) + "&fulfilmentCenter=" + fulfilmentCenter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static UpdateOrderItemResult AddOrderItem(Guid orderId,Guid itemId,String channelSKU,Guid fulfilmentCenter,Int32 quantity,LinePricingRequest linePricing,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateOrderItemResult>(Factory.GetResponse("Orders/AddOrderItem", "orderId=" + orderId + "&itemId=" + itemId + "&channelSKU=" + channelSKU + "&fulfilmentCenter=" + fulfilmentCenter + "&quantity=" + quantity + "&linePricing=" + Newtonsoft.Json.JsonConvert.SerializeObject(linePricing, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static UpdateOrderItemResult AddOrderService(Guid orderId,String service,Double cost,Double taxRate,Guid fulfilmentCenter,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateOrderItemResult>(Factory.GetResponse("Orders/AddOrderService", "orderId=" + orderId + "&service=" + service + "&cost=" + cost + "&taxRate=" + taxRate + "&fulfilmentCenter=" + fulfilmentCenter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<Guid> AssignToFolder(List<Guid> orderIds,String folder,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/AssignToFolder", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds, serializerSettings) + "&folder=" + folder + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static String CancelOrder(Guid orderId,Guid fulfilmentCenter,Double refund,String note,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("Orders/CancelOrder", "orderId=" + orderId + "&fulfilmentCenter=" + fulfilmentCenter + "&refund=" + refund + "&note=" + note + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<Guid> ChangeOrderTag(List<Guid> orderIds,Int32? tag,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/ChangeOrderTag", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds, serializerSettings) + "&tag=" + Newtonsoft.Json.JsonConvert.SerializeObject(tag, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<Guid> ChangeShippingMethod(List<Guid> orderIds,String shippingMethod,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/ChangeShippingMethod", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds, serializerSettings) + "&shippingMethod=" + shippingMethod + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<Guid> ChangeStatus(List<Guid> orderIds,Int32 status,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/ChangeStatus", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds, serializerSettings) + "&status=" + status + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<Guid> ClearInvoicePrinted(List<Guid> orderIds,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/ClearInvoicePrinted", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<Guid> ClearPickListPrinted(List<Guid> orderIds,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/ClearPickListPrinted", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<KeyValuePair<Guid,String>> ClearShippingLabelInfo(List<Guid> orderIds,Boolean withoutConfirmation,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<KeyValuePair<Guid,String>>>(Factory.GetResponse("Orders/ClearShippingLabelInfo", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds, serializerSettings) + "&withoutConfirmation=" + withoutConfirmation + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static String CompleteOrder(Guid orderId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("Orders/CompleteOrder", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Guid? CreateNewItemAndLink(Guid pkStockItemId,String itemTitle,String source,String subSource,String channelSKU,Guid? locationId,Int32? initialQuantity,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Guid?>(Factory.GetResponse("Orders/CreateNewItemAndLink", "pkStockItemId=" + pkStockItemId + "&itemTitle=" + itemTitle + "&source=" + source + "&subSource=" + subSource + "&channelSKU=" + channelSKU + "&locationId=" + Newtonsoft.Json.JsonConvert.SerializeObject(locationId, serializerSettings) + "&initialQuantity=" + Newtonsoft.Json.JsonConvert.SerializeObject(initialQuantity, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static OpenOrder CreateNewOrder(Guid fulfilmentCenter,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<OpenOrder>(Factory.GetResponse("Orders/CreateNewOrder", "fulfilmentCenter=" + fulfilmentCenter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<Guid> CreateOrders(List<ChannelOrder> orders,String location,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/CreateOrders", "orders=" + Newtonsoft.Json.JsonConvert.SerializeObject(orders, serializerSettings) + "&location=" + location + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<CustomerAddress> CustomerLookUp(String field,String txt,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<CustomerAddress>>(Factory.GetResponse("Orders/CustomerLookUp", "field=" + field + "&txt=" + txt + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void DeleteOrder(Guid orderId,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Orders/DeleteOrder", "orderId=" + orderId + "", ApiToken, ApiServer); 
		}

		public static List<StockItemBatch> GetAllAvailableOrderItemBatchsByOrderId(AvailableOrderItemBatchsInfo parameters,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemBatch>>(Factory.GetResponse("Orders/GetAllAvailableOrderItemBatchsByOrderId", "parameters=" + Newtonsoft.Json.JsonConvert.SerializeObject(parameters, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<Guid> GetAllOpenOrders(FieldsFilter filters,List<FieldSorting> sorting,Guid fulfilmentCenter,String additionalFilter,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/GetAllOpenOrders", "filters=" + Newtonsoft.Json.JsonConvert.SerializeObject(filters, serializerSettings) + "&sorting=" + Newtonsoft.Json.JsonConvert.SerializeObject(sorting, serializerSettings) + "&fulfilmentCenter=" + fulfilmentCenter + "&additionalFilter=" + additionalFilter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<Guid> GetAllOpenOrdersBetweenIndex(Int32 fromIndex,Int32 toIndex,FieldsFilter filters,List<FieldSorting> sorting,Guid fulfilmentCenter,String additionalFilter,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/GetAllOpenOrdersBetweenIndex", "fromIndex=" + fromIndex + "&toIndex=" + toIndex + "&filters=" + Newtonsoft.Json.JsonConvert.SerializeObject(filters, serializerSettings) + "&sorting=" + Newtonsoft.Json.JsonConvert.SerializeObject(sorting, serializerSettings) + "&fulfilmentCenter=" + fulfilmentCenter + "&additionalFilter=" + additionalFilter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<OrderItemBatch> GetAssignedOrderItemBatches(GetAssignedOrderItemBatchesRequest request,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderItemBatch>>(Factory.GetResponse("Orders/GetAssignedOrderItemBatches", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<OrderFolder> GetAvailableFolders(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderFolder>>(Factory.GetResponse("Orders/GetAvailableFolders", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<KeyValuePair<Guid,String>> GetBatchPilots(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<KeyValuePair<Guid,String>>>(Factory.GetResponse("Orders/GetBatchPilots", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<Country> GetCountries(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Country>>(Factory.GetResponse("Orders/GetCountries", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Guid GetDefaultPaymentMethodIdForNewOrder(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Guid>(Factory.GetResponse("Orders/GetDefaultPaymentMethodIdForNewOrder", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<Guid> GetDraftOrders(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/GetDraftOrders", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<ExtendedProperty> GetExtendedProperties(Guid orderId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ExtendedProperty>>(Factory.GetResponse("Orders/GetExtendedProperties", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<String> GetExtendedPropertyNames(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<String>>(Factory.GetResponse("Orders/GetExtendedPropertyNames", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<String> GetExtendedPropertyTypes(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<String>>(Factory.GetResponse("Orders/GetExtendedPropertyTypes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<LinkedItem> GetLinkedItems(Guid itemId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<LinkedItem>>(Factory.GetResponse("Orders/GetLinkedItems", "itemId=" + itemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Guid? GetOpenOrderIdByOrderOrReferenceId(String orderOrReferenceId,FieldsFilter filters,Guid? locationId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Guid?>(Factory.GetResponse("Orders/GetOpenOrderIdByOrderOrReferenceId", "orderOrReferenceId=" + orderOrReferenceId + "&filters=" + Newtonsoft.Json.JsonConvert.SerializeObject(filters, serializerSettings) + "&locationId=" + Newtonsoft.Json.JsonConvert.SerializeObject(locationId, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static KeyValuePair<OrderSummary,String> GetOpenOrderIdByOrderOrReferenceIdAndProcess(Guid ApiToken, String ApiServer,String orderOrReferenceId,Guid fulfilmentCenter,FieldsFilter filters,Boolean batchScanned = false)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<KeyValuePair<OrderSummary,String>>(Factory.GetResponse("Orders/GetOpenOrderIdByOrderOrReferenceIdAndProcess", "orderOrReferenceId=" + orderOrReferenceId + "&fulfilmentCenter=" + fulfilmentCenter + "&filters=" + Newtonsoft.Json.JsonConvert.SerializeObject(filters, serializerSettings) + "&batchScanned=" + batchScanned + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<KeyValuePair<Guid,Guid>> GetOpenOrderItemsSuppliers(Guid orderId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<KeyValuePair<Guid,Guid>>>(Factory.GetResponse("Orders/GetOpenOrderItemsSuppliers", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static GenericPagedResult<OpenOrder> GetOpenOrders(Int32 entriesPerPage,Int32 pageNumber,FieldsFilter filters,List<FieldSorting> sorting,Guid? fulfilmentCenter,String additionalFilter,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericPagedResult<OpenOrder>>(Factory.GetResponse("Orders/GetOpenOrders", "entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "&filters=" + Newtonsoft.Json.JsonConvert.SerializeObject(filters, serializerSettings) + "&sorting=" + Newtonsoft.Json.JsonConvert.SerializeObject(sorting, serializerSettings) + "&fulfilmentCenter=" + Newtonsoft.Json.JsonConvert.SerializeObject(fulfilmentCenter, serializerSettings) + "&additionalFilter=" + additionalFilter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static KeyValuePair<List<OrderSummary>,String> GetOpenOrdersByItemBarcode(String productBarcode,FieldsFilter filters,Guid? locationId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<KeyValuePair<List<OrderSummary>,String>>(Factory.GetResponse("Orders/GetOpenOrdersByItemBarcode", "productBarcode=" + productBarcode + "&filters=" + Newtonsoft.Json.JsonConvert.SerializeObject(filters, serializerSettings) + "&locationId=" + Newtonsoft.Json.JsonConvert.SerializeObject(locationId, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static OpenOrder GetOrder(Guid orderId,Guid? fulfilmentLocationId,Boolean loadItems,Boolean loadAdditionalInfo,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<OpenOrder>(Factory.GetResponse("Orders/GetOrder", "orderId=" + orderId + "&fulfilmentLocationId=" + Newtonsoft.Json.JsonConvert.SerializeObject(fulfilmentLocationId, serializerSettings) + "&loadItems=" + loadItems + "&loadAdditionalInfo=" + loadAdditionalInfo + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<OrderAuditTrail> GetOrderAuditTrail(Guid orderId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderAuditTrail>>(Factory.GetResponse("Orders/GetOrderAuditTrail", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static OrderDetails GetOrderById(Guid pkOrderId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<OrderDetails>(Factory.GetResponse("Orders/GetOrderById", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static OrderDetails GetOrderDetailsByNumOrderId(Int32 OrderId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<OrderDetails>(Factory.GetResponse("Orders/GetOrderDetailsByNumOrderId", "OrderId=" + OrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<OrderDetails> GetOrderDetailsByReferenceId(String ReferenceId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderDetails>>(Factory.GetResponse("Orders/GetOrderDetailsByReferenceId", "ReferenceId=" + ReferenceId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<OrderItemBatch> GetOrderItemBatchsByOrderId(OrderItemBatchInfo parameters,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderItemBatch>>(Factory.GetResponse("Orders/GetOrderItemBatchsByOrderId", "parameters=" + Newtonsoft.Json.JsonConvert.SerializeObject(parameters, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static OrderItem GetOrderItemComposition(Guid orderId,Guid stockItemId,Guid fulfilmentCenter,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<OrderItem>(Factory.GetResponse("Orders/GetOrderItemComposition", "orderId=" + orderId + "&stockItemId=" + stockItemId + "&fulfilmentCenter=" + fulfilmentCenter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<OrderItem> GetOrderItems(Guid orderId,Guid fulfilmentCenter,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderItem>>(Factory.GetResponse("Orders/GetOrderItems", "orderId=" + orderId + "&fulfilmentCenter=" + fulfilmentCenter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<OrderNote> GetOrderNotes(Guid orderId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderNote>>(Factory.GetResponse("Orders/GetOrderNotes", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<OrderNoteType> GetOrderNoteTypes(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderNoteType>>(Factory.GetResponse("Orders/GetOrderNoteTypes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<CalcOrderHeader> GetOrderPackagingCalculation(GetOrderPackagingCalculationRequest request,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<CalcOrderHeader>>(Factory.GetResponse("Orders/GetOrderPackagingCalculation", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<OrderPackagingSplit> GetOrderPackagingSplit(Guid orderId,Boolean openOrdersOnly,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderPackagingSplit>>(Factory.GetResponse("Orders/GetOrderPackagingSplit", "orderId=" + orderId + "&openOrdersOnly=" + openOrdersOnly + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<OrderRelation> GetOrderRelations(Guid orderId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderRelation>>(Factory.GetResponse("Orders/GetOrderRelations", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<OpenOrder> GetOrders(List<Guid> ordersIds,Guid? fulfilmentLocationId,Boolean loadItems,Boolean loadAdditionalInfo,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OpenOrder>>(Factory.GetResponse("Orders/GetOrders", "ordersIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(ordersIds, serializerSettings) + "&fulfilmentLocationId=" + Newtonsoft.Json.JsonConvert.SerializeObject(fulfilmentLocationId, serializerSettings) + "&loadItems=" + loadItems + "&loadAdditionalInfo=" + loadAdditionalInfo + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<OrderDetails> GetOrdersById(List<Guid> pkOrderIds,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderDetails>>(Factory.GetResponse("Orders/GetOrdersById", "pkOrderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(pkOrderIds, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static UserOrderView GetOrderView(Int32 pkViewId,Boolean markAsLatestViewed,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<UserOrderView>(Factory.GetResponse("Orders/GetOrderView", "pkViewId=" + pkViewId + "&markAsLatestViewed=" + markAsLatestViewed + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<UserOrderView> GetOrderViews(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<UserOrderView>>(Factory.GetResponse("Orders/GetOrderViews", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<OrderXML> GetOrderXml(Guid orderId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderXML>>(Factory.GetResponse("Orders/GetOrderXml", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static String GetOrderXmlJSTree(Guid orderId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("Orders/GetOrderXmlJSTree", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<PackageGroup> GetPackagingGroups(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PackageGroup>>(Factory.GetResponse("Orders/GetPackagingGroups", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<PaymentMethod> GetPaymentMethods(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PaymentMethod>>(Factory.GetResponse("Orders/GetPaymentMethods", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<ShippingMethod> GetShippingMethods(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ShippingMethod>>(Factory.GetResponse("Orders/GetShippingMethods", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Guid GetUserLocationId(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Guid>(Factory.GetResponse("Orders/GetUserLocationId", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void LockOrder(List<Guid> orderIds,Boolean lockOrder,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Orders/LockOrder", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds, serializerSettings) + "&lockOrder=" + lockOrder + "", ApiToken, ApiServer); 
		}

		public static OpenOrder MergeOrders(List<Guid> ordersToMerge,Guid fulfilmentCenter,Guid pkPostalServiceId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<OpenOrder>(Factory.GetResponse("Orders/MergeOrders", "ordersToMerge=" + Newtonsoft.Json.JsonConvert.SerializeObject(ordersToMerge, serializerSettings) + "&fulfilmentCenter=" + fulfilmentCenter + "&pkPostalServiceId=" + pkPostalServiceId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static MoveToFulfilmentCenterResult MoveToFulfilmentCenter(List<Guid> orderIds,Guid fulfilmentCenterId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<MoveToFulfilmentCenterResult>(Factory.GetResponse("Orders/MoveToFulfilmentCenter", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds, serializerSettings) + "&fulfilmentCenterId=" + fulfilmentCenterId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static MoveToLocationResult MoveToLocation(List<Guid> orderIds,Guid pkStockLocationId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<MoveToLocationResult>(Factory.GetResponse("Orders/MoveToLocation", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds, serializerSettings) + "&pkStockLocationId=" + pkStockLocationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static ProcessOrderResult ProcessFulfilmentCentreOrder(Guid orderId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ProcessOrderResult>(Factory.GetResponse("Orders/ProcessFulfilmentCentreOrder", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static ProcessOrderResult ProcessOrder(Guid ApiToken, String ApiServer,Guid orderId,Boolean scanPerformed,Guid? locationId,Boolean allowZeroAndNegativeBatchQty = false)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ProcessOrderResult>(Factory.GetResponse("Orders/ProcessOrder", "orderId=" + orderId + "&scanPerformed=" + scanPerformed + "&locationId=" + Newtonsoft.Json.JsonConvert.SerializeObject(locationId, serializerSettings) + "&allowZeroAndNegativeBatchQty=" + allowZeroAndNegativeBatchQty + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void ProcessOrder_RequiredBatchScans(BatchAssignmentForOrderItems BatchAssignment,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Orders/ProcessOrder_RequiredBatchScans", "BatchAssignment=" + Newtonsoft.Json.JsonConvert.SerializeObject(BatchAssignment, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static ProcessOrderByOrderIdOrReferenceResponse ProcessOrderByOrderOrReferenceId(ProcessOrderByOrderIdOrReferenceRequest request,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ProcessOrderByOrderIdOrReferenceResponse>(Factory.GetResponse("Orders/ProcessOrderByOrderOrReferenceId", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<ProcessOrderResult> ProcessOrdersInBatch(List<Guid> ordersIds,Guid? locationId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ProcessOrderResult>>(Factory.GetResponse("Orders/ProcessOrdersInBatch", "ordersIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(ordersIds, serializerSettings) + "&locationId=" + Newtonsoft.Json.JsonConvert.SerializeObject(locationId, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static CalcOrderHeader RecalculateSingleOrderPackaging(CalcOrderHeader request,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<CalcOrderHeader>(Factory.GetResponse("Orders/RecalculateSingleOrderPackaging", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static UpdateOrderItemResult RemoveOrderItem(Guid orderId,Guid rowid,Guid fulfilmentCenter,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateOrderItemResult>(Factory.GetResponse("Orders/RemoveOrderItem", "orderId=" + orderId + "&rowid=" + rowid + "&fulfilmentCenter=" + fulfilmentCenter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<Guid> RunRulesEngine(Guid[] orderIds,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/RunRulesEngine", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void SaveOrderView(Int32 pkViewId,String viewName,String OrderViewDetailJSON,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Orders/SaveOrderView", "pkViewId=" + pkViewId + "&viewName=" + viewName + "&OrderViewDetailJSON=" + OrderViewDetailJSON + "", ApiToken, ApiServer); 
		}

		public static void SetAdditionalInfo(Guid orderId,Guid rowId,OrderItemOption[] additionalInfo,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Orders/SetAdditionalInfo", "orderId=" + orderId + "&rowId=" + rowId + "&additionalInfo=" + Newtonsoft.Json.JsonConvert.SerializeObject(additionalInfo, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static List<OrderFolder> SetAvailableFolders(List<OrderFolder> folders,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderFolder>>(Factory.GetResponse("Orders/SetAvailableFolders", "folders=" + Newtonsoft.Json.JsonConvert.SerializeObject(folders, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void SetDefaultPaymentMethodIdForNewOrder(Guid paymentMethod,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Orders/SetDefaultPaymentMethodIdForNewOrder", "paymentMethod=" + paymentMethod + "", ApiToken, ApiServer); 
		}

		public static List<ExtendedProperty> SetExtendedProperties(Guid orderId,ExtendedProperty[] extendedProperties,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ExtendedProperty>>(Factory.GetResponse("Orders/SetExtendedProperties", "orderId=" + orderId + "&extendedProperties=" + Newtonsoft.Json.JsonConvert.SerializeObject(extendedProperties, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<Guid> SetInvoicesPrinted(List<Guid> orderIds,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/SetInvoicesPrinted", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<Guid> SetLabelsPrinted(List<Guid> orderIds,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/SetLabelsPrinted", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static OrderTotalsInfo SetOrderCustomerInfo(Guid orderId,OrderCustomerInfo info,Boolean? saveToCrm,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<OrderTotalsInfo>(Factory.GetResponse("Orders/SetOrderCustomerInfo", "orderId=" + orderId + "&info=" + Newtonsoft.Json.JsonConvert.SerializeObject(info, serializerSettings) + "&saveToCrm=" + Newtonsoft.Json.JsonConvert.SerializeObject(saveToCrm, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void SetOrderGeneralInfo(Guid orderId,OrderGeneralInfo info,Boolean wasDraft,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Orders/SetOrderGeneralInfo", "orderId=" + orderId + "&info=" + Newtonsoft.Json.JsonConvert.SerializeObject(info, serializerSettings) + "&wasDraft=" + wasDraft + "", ApiToken, ApiServer); 
		}

		public static void SetOrderNotes(Guid orderId,List<OrderNote> orderNotes,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Orders/SetOrderNotes", "orderId=" + orderId + "&orderNotes=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderNotes, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static CalcOrderHeader SetOrderPackaging(SetOrderPackagingRequest request,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<CalcOrderHeader>(Factory.GetResponse("Orders/SetOrderPackaging", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static UpdateTotalsResult SetOrderPackagingSplit(Guid orderId,List<OrderPackagingSplit> packagingSplit,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateTotalsResult>(Factory.GetResponse("Orders/SetOrderPackagingSplit", "orderId=" + orderId + "&packagingSplit=" + Newtonsoft.Json.JsonConvert.SerializeObject(packagingSplit, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static UpdateTotalsResult SetOrderShippingInfo(Guid orderId,OrderShippingInfo info,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateTotalsResult>(Factory.GetResponse("Orders/SetOrderShippingInfo", "orderId=" + orderId + "&info=" + Newtonsoft.Json.JsonConvert.SerializeObject(info, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static CalcOrderHeader SetOrderSplitPackagingManualOverwrite(CalcOrderHeader request,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<CalcOrderHeader>(Factory.GetResponse("Orders/SetOrderSplitPackagingManualOverwrite", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void SetOrderTotalsInfo(Guid orderId,OrderTotalsInfo info,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Orders/SetOrderTotalsInfo", "orderId=" + orderId + "&info=" + Newtonsoft.Json.JsonConvert.SerializeObject(info, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static List<PaymentMethod> SetPaymentMethods(PaymentMethod[] paymentMethods,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PaymentMethod>>(Factory.GetResponse("Orders/SetPaymentMethods", "paymentMethods=" + Newtonsoft.Json.JsonConvert.SerializeObject(paymentMethods, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void SetPickListPrinted(SetPickListPrintedRequest Request,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Orders/SetPickListPrinted", "Request=" + Newtonsoft.Json.JsonConvert.SerializeObject(Request, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static List<OpenOrder> SplitOrder(Guid orderId,OrderSplit[] newOrders,String type,Guid fulfilmentLocationId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OpenOrder>>(Factory.GetResponse("Orders/SplitOrder", "orderId=" + orderId + "&newOrders=" + Newtonsoft.Json.JsonConvert.SerializeObject(newOrders, serializerSettings) + "&type=" + type + "&fulfilmentLocationId=" + fulfilmentLocationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<Guid> UnassignToFolder(List<Guid> orderIds,String folder,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/UnassignToFolder", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds, serializerSettings) + "&folder=" + folder + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void UpdateBillingAddress(Guid orderId,Address billingAddress,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Orders/UpdateBillingAddress", "orderId=" + orderId + "&billingAddress=" + Newtonsoft.Json.JsonConvert.SerializeObject(billingAddress, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void UpdateLinkItem(Guid pkStockId,Guid pkStockItemId,String source,String subSource,String channelSKU,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Orders/UpdateLinkItem", "pkStockId=" + pkStockId + "&pkStockItemId=" + pkStockItemId + "&source=" + source + "&subSource=" + subSource + "&channelSKU=" + channelSKU + "", ApiToken, ApiServer); 
		}

		public static UpdateOrderItemResult UpdateOrderItem(Guid orderId,OrderItem orderItem,Guid fulfilmentCenter,String source,String subSource,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateOrderItemResult>(Factory.GetResponse("Orders/UpdateOrderItem", "orderId=" + orderId + "&orderItem=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderItem, serializerSettings) + "&fulfilmentCenter=" + fulfilmentCenter + "&source=" + source + "&subSource=" + subSource + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static CouponValidationResult ValidateCoupon(Guid orderId,String barcode,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<CouponValidationResult>(Factory.GetResponse("Orders/ValidateCoupon", "orderId=" + orderId + "&barcode=" + barcode + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		} 
	}
}
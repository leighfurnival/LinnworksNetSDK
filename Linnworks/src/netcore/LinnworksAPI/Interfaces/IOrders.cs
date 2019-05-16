using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IOrdersController
	{
		UpdateOrderItemResult AddCoupon(Guid orderId,String barcode,CouponValidationResult couponData,Guid fulfilmentCenter);
		UpdateOrderItemResult AddOrderItem(Guid orderId,Guid itemId,String channelSKU,Guid fulfilmentCenter,Int32 quantity,LinePricingRequest linePricing);
		UpdateOrderItemResult AddOrderService(Guid orderId,String service,Double cost,Double taxRate,Guid fulfilmentCenter);
		void AssignOrderItemBatches(AssignOrderItemBatches request);
		List<OrderItemBatch> AssignStockToOrder(AssignStockToOrderRequest request);
		List<Guid> AssignToFolder(List<Guid> orderIds,String folder);
		String CancelOrder(Guid orderId,Guid fulfilmentCenter,Double refund,String note);
		List<Guid> ChangeOrderTag(List<Guid> orderIds,Int32? tag);
		List<Guid> ChangeShippingMethod(List<Guid> orderIds,String shippingMethod);
		List<Guid> ChangeStatus(List<Guid> orderIds,Int32 status);
		List<Guid> ClearInvoicePrinted(List<Guid> orderIds);
		List<Guid> ClearPickListPrinted(List<Guid> orderIds);
		List<KeyValuePair<Guid,String>> ClearShippingLabelInfo(List<Guid> orderIds,Boolean withoutConfirmation);
		String CompleteOrder(Guid orderId);
		Guid? CreateNewItemAndLink(Guid pkStockItemId,String itemTitle,String source,String subSource,String channelSKU,Guid? locationId,Int32? initialQuantity);
		OpenOrder CreateNewOrder(Guid fulfilmentCenter);
		List<Guid> CreateOrders(List<ChannelOrder> orders,String location);
		List<CustomerAddress> CustomerLookUp(String field,String txt);
		void DeleteOrder(Guid orderId);
		List<StockItemBatch> GetAllAvailableOrderItemBatchsByOrderId(AvailableOrderItemBatchsInfo parameters);
		List<Guid> GetAllOpenOrders(FieldsFilter filters,List<FieldSorting> sorting,Guid fulfilmentCenter,String additionalFilter,Boolean exactMatch = false);
		List<Guid> GetAllOpenOrdersBetweenIndex(Int32 fromIndex,Int32 toIndex,FieldsFilter filters,List<FieldSorting> sorting,Guid fulfilmentCenter,String additionalFilter);
		List<OrderItemBatch> GetAssignedOrderItemBatches(GetAssignedOrderItemBatchesRequest request);
		List<OrderFolder> GetAvailableFolders();
		List<KeyValuePair<Guid,String>> GetBatchPilots();
		List<OrderCountry> GetCountries();
		Guid GetDefaultPaymentMethodIdForNewOrder();
		List<Guid> GetDraftOrders();
		List<ExtendedProperty> GetExtendedProperties(Guid orderId);
		List<String> GetExtendedPropertyNames();
		List<String> GetExtendedPropertyTypes();
		List<LinkedItem> GetLinkedItems(Guid itemId);
		Guid? GetOpenOrderIdByOrderOrReferenceId(String orderOrReferenceId,FieldsFilter filters,Guid? locationId);
		KeyValuePair<OrderSummary,String> GetOpenOrderIdByOrderOrReferenceIdAndProcess(String orderOrReferenceId,Guid fulfilmentCenter,FieldsFilter filters,Boolean batchScanned = false);
		List<KeyValuePair<Guid,Guid>> GetOpenOrderItemsSuppliers(Guid orderId);
		GenericPagedResult<OpenOrder> GetOpenOrders(Int32 entriesPerPage,Int32 pageNumber,FieldsFilter filters,List<FieldSorting> sorting,Guid? fulfilmentCenter,String additionalFilter);
		KeyValuePair<List<OrderSummary>,String> GetOpenOrdersByItemBarcode(String productBarcode,FieldsFilter filters,Guid? locationId);
		OpenOrder GetOrder(Guid orderId,Guid? fulfilmentLocationId,Boolean loadItems,Boolean loadAdditionalInfo);
		List<OrderAuditTrail> GetOrderAuditTrail(Guid orderId);
		OrderDetails GetOrderById(Guid pkOrderId);
		OrderDetails GetOrderDetailsByNumOrderId(Int32 OrderId);
		List<OrderDetails> GetOrderDetailsByReferenceId(String ReferenceId);
		List<OrderItemBatch> GetOrderItemBatchsByOrderId(OrderItemBatchInfo parameters);
		OrderItem GetOrderItemComposition(Guid orderId,Guid stockItemId,Guid fulfilmentCenter);
		List<OrderItem> GetOrderItems(Guid orderId,Guid fulfilmentCenter);
		List<OrderNote> GetOrderNotes(Guid orderId);
		List<OrderNoteType> GetOrderNoteTypes();
		List<CalcOrderHeader> GetOrderPackagingCalculation(GetOrderPackagingCalculationRequest request);
		List<OrderPackagingSplit> GetOrderPackagingSplit(Guid orderId,Boolean openOrdersOnly);
		List<OrderRelation> GetOrderRelations(Guid orderId);
		List<OpenOrder> GetOrders(List<Guid> ordersIds,Guid? fulfilmentLocationId,Boolean loadItems,Boolean loadAdditionalInfo);
		List<OrderDetails> GetOrdersById(List<Guid> pkOrderIds);
		UserOrderView GetOrderView(Int32 pkViewId,Boolean markAsLatestViewed);
		List<UserOrderView> GetOrderViews();
		List<OrderXML> GetOrderXml(Guid orderId);
		String GetOrderXmlJSTree(Guid orderId);
		List<PackageGroup> GetPackagingGroups();
		List<PaymentMethod> GetPaymentMethods();
		List<ShippingMethod> GetShippingMethods();
		Guid GetUserLocationId();
		void LockOrder(List<Guid> orderIds,Boolean lockOrder);
		OpenOrder MergeOrders(List<Guid> ordersToMerge,Guid fulfilmentCenter,Guid pkPostalServiceId);
		MoveToFulfilmentCenterResult MoveToFulfilmentCenter(List<Guid> orderIds,Guid fulfilmentCenterId);
		MoveToLocationResult MoveToLocation(List<Guid> orderIds,Guid pkStockLocationId);
		ProcessOrderResult ProcessFulfilmentCentreOrder(Guid orderId);
		ProcessOrderResult ProcessOrder(Guid orderId,Boolean scanPerformed,Guid? locationId,Boolean allowZeroAndNegativeBatchQty = false);
		void ProcessOrder_RequiredBatchScans(BatchAssignmentForOrderItems BatchAssignment);
		ProcessOrderByOrderIdOrReferenceResponse ProcessOrderByOrderOrReferenceId(ProcessOrderByOrderIdOrReferenceRequest request);
		List<ProcessOrderResult> ProcessOrdersInBatch(List<Guid> ordersIds,Guid? locationId);
		CalcOrderHeader RecalculateSingleOrderPackaging(CalcOrderHeader request);
		UpdateOrderItemResult RemoveOrderItem(Guid orderId,Guid rowid,Guid fulfilmentCenter);
		List<Guid> RunRulesEngine(Guid[] orderIds);
		void SaveOrderView(Int32 pkViewId,String viewName,String OrderViewDetailJSON);
		void SetAdditionalInfo(Guid orderId,Guid rowId,OrderItemOption[] additionalInfo);
		List<OrderFolder> SetAvailableFolders(List<OrderFolder> folders);
		void SetDefaultPaymentMethodIdForNewOrder(Guid paymentMethod);
		List<ExtendedProperty> SetExtendedProperties(Guid orderId,ExtendedProperty[] extendedProperties);
		List<Guid> SetInvoicesPrinted(List<Guid> orderIds);
		List<Guid> SetLabelsPrinted(List<Guid> orderIds);
		OrderTotalsInfo SetOrderCustomerInfo(Guid orderId,OrderCustomerInfo info,Boolean? saveToCrm);
		void SetOrderGeneralInfo(Guid orderId,OrderGeneralInfo info,Boolean wasDraft);
		void SetOrderNotes(Guid orderId,List<OrderNote> orderNotes);
		CalcOrderHeader SetOrderPackaging(SetOrderPackagingRequest request);
		UpdateTotalsResult SetOrderPackagingSplit(Guid orderId,List<OrderPackagingSplit> packagingSplit);
		UpdateTotalsResult SetOrderShippingInfo(Guid orderId,UpdateOrderShippingInfoRequest info);
		CalcOrderHeader SetOrderSplitPackagingManualOverwrite(CalcOrderHeader request);
		void SetOrderTotalsInfo(Guid orderId,OrderTotalsInfo info);
		List<PaymentMethod> SetPaymentMethods(PaymentMethod[] paymentMethods);
		void SetPickListPrinted(SetPickListPrintedRequest Request);
		List<OpenOrder> SplitOrder(Guid orderId,OrderSplit[] newOrders,String type,Guid fulfilmentLocationId);
		List<Guid> UnassignToFolder(List<Guid> orderIds,String folder);
		void UpdateBillingAddress(Guid orderId,CustomerAddress billingAddress);
		void UpdateLinkItem(Guid pkStockId,Guid pkStockItemId,String source,String subSource,String channelSKU);
		UpdateOrderItemResult UpdateOrderItem(Guid orderId,OrderItem orderItem,Guid fulfilmentCenter,String source,String subSource);
		CouponValidationResult ValidateCoupon(Guid orderId,String barcode);
	} 
}
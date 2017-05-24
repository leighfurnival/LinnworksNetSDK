using System;

namespace LinnworksAPI
{
    public class Update_PurchaseOrderHeaderParameter
    {
        public Guid pkPurchaseID;
        public string SupplierReferenceNumber;
        public Guid? fkLocationId;
        public Guid? fkSupplierId;
        public string Currency;
        public string ExternalInvoiceNumber;
        public DateTime? DateOfPurchase;
        public DateTime? QuotedDeliveryDate;
        public decimal? ShippingTaxRate;
        public decimal? ConversionRate;
        public decimal? PostagePaid;
    }
}
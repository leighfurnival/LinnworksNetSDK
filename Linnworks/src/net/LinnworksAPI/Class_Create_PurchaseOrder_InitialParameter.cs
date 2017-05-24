using System;

namespace LinnworksAPI
{
    public class Create_PurchaseOrder_InitialParameter
    {
        public Guid fkSupplierId;
        public Guid fkLocationId;
        public string ExternalInvoiceNumber;
        public string Currency;
        public string SupplierReferenceNumber;
        public DateTime DateOfPurchase;
        public DateTime QuotedDeliveryDate;
        public decimal PostagePaid;
        public decimal ShippingTaxRate;
        public decimal ConversionRate;
    }
}
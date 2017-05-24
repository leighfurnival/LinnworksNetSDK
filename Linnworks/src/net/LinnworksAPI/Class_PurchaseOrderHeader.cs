using System;

namespace LinnworksAPI
{
    public class PurchaseOrderHeader
    {
        public Guid pkPurchaseID;
        public Guid fkSupplierId;
        public Guid fkLocationId;
        public string ExternalInvoiceNumber;
        public PurchaseOrderStatus Status;
        public string Currency;
        public string SupplierReferenceNumber;
        public bool Locked;
        public int LineCount;
        public int DeliveredLinesCount;
        public DateTime DateOfPurchase;
        public DateTime DateOfDelivery;
        public DateTime QuotedDeliveryDate;
        public decimal PostagePaid;
        public decimal TotalCost;
        public decimal taxPaid;
        public decimal ShippingTaxRate;
        public decimal ConversionRate;
    }
}
using System;

namespace LinnworksAPI
{
    public class ProcessedOrderWeb
    {
        public Guid pkOrderID;
        public string cShippingAddress;
        public DateTime dReceivedDate;
        public DateTime dProcessedOn;
        public double timeDiff;
        public double fPostageCost;
        public double fTotalCharge;
        public double PostageCostExTax;
        public double Subtotal;
        public double fTax;
        public double TotalDiscount;
        public double ProfitMargin;
        public double CountryTaxRate;
        public int nOrderId;
        public int nStatus;
        public string cCurrency;
        public string PostalTrackingNumber;
        public string cCountry;
        public string Source;
        public string PostalServiceName;
        public string PostalServiceCode;
        public string Vendor;
        public string ReferenceNum;
        public string SecondaryReference;
        public string ExternalReference;
        public string Address1;
        public string Address2;
        public string Address3;
        public string Town;
        public string Region;
        public string BuyerPhoneNumber;
        public string Company;
        public string SubSource;
        public string ChannelBuyerName;
        public string AccountName;
        public string cFullName;
        public string cEmailAddress;
        public string cPostCode;
        public DateTime dPaidOn;
        public string PackageCategory;
        public string PackageTitle;
        public double ItemWeight;
        public double TotalWeight;
        public string FolderCollection;
        public string cBillingAddress;
        public string BillingName;
        public string BillingCompany;
        public string BillingAddress1;
        public string BillingAddress2;
        public string BillingAddress3;
        public string BillingTown;
        public string BillingRegion;
        public string BillingPostCode;
        public string BillingCountryName;
        public string BillingPhoneNumber;
        public bool HoldOrCancel;
    }
}
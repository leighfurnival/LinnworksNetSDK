using System;

namespace LinnworksAPI
{
    [Serializable]
    public class CustomerAddress
    {
        public string EmailAddress;
        public string Address1;
        public string Address2;
        public string Address3;
        public string Town;
        public string Region;
        public string PostCode;
        public string Country;
        public string FullName;
        public string Company;
        public string PhoneNumber;
        public Guid CountryId;
    }
}
using System;

namespace LinnworksAPI
{
    public class Country
    {
        public Guid CountryId;
        public string CountryName;
        public string CountryCode;
        public string Continent;
        public bool CustomsRequired;
        public double TaxRate;
    }
}
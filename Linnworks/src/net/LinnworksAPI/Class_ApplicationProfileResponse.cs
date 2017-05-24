using System;

namespace LinnworksAPI
{
    public class ApplicationProfileResponse
    {
        public string PlanTag;
        public string PlanName;
        public DateTime ActivationDate;
        public DateTime LastPaymentDate;
        public DateTime NextPaymentDate;
        public DateTime ProfileExpires;
        public bool IsProfileActive;
    }
}
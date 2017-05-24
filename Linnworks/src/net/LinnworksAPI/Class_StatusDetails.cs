using System.Collections.Generic;

namespace LinnworksAPI
{
    public class StatusDetails
    {
        public StateType State;
        public string Reason;
        public Dictionary<string, string> Parameters;
    }
}
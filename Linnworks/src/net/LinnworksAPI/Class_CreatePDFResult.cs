using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class CreatePDFResult
    {
        public string URL;
        public List<Guid> IdsProcessed;
        public Dictionary<string, List<Guid>> ProcessedIds;
        public List<string> PrintErrors;
    }
}
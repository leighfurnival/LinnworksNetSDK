using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class CreatePDFResult
    {
<<<<<<< HEAD
        public string URL;
=======
        public List<PrintError> KeyedError;
        public String URL;
>>>>>>> refs/remotes/LinnSystems/master
        public List<Guid> IdsProcessed;
        public Dictionary<string, List<Guid>> ProcessedIds;
        public List<string> PrintErrors;
    }
}
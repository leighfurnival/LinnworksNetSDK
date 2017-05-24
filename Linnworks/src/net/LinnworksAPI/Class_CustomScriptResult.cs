using System.Collections.Generic;

namespace LinnworksAPI
{
    public class CustomScriptResult
    {
        public bool IsError;
        public string ErrorMessage;
        public long TotalResults;
        public List<CustomScriptColumn> Columns;
        public List<Dictionary<string, object>> Results;
    }
}
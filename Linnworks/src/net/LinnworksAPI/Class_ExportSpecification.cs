using System.Collections.Generic;

namespace LinnworksAPI
{
    public class ExportSpecification
    {
        public bool ExportColumnNames;
        public string Delimiter;
        public string Escape;
        public string CustomScript;
        public ExportGenericFeed Feed;
        public List<ExportColumn> ColumnMappings;
        public List<ExecutionOption> ExecutionOptions;
    }
}
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class ExportColumn
    {
        public int Order;
        public Filters Filters;
        public bool ExportToFile;
        public List<SubQueryOutputMappingSelectionField> SubQuerySelection;
        public string FileColumn;
        public string Column;
        public string Expression;
        public string DefaultValue;
        public bool Visible;
    }
}
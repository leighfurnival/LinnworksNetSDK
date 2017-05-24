using System;

namespace LinnworksAPI
{
    public class DateFieldFilter
    {
        public DateTime? DateFrom;
        public DateTime? DateTo;
        public DateTimeFieldFilterType Type;
        public int? Value;
        public FieldCode FieldCode;
    }
}
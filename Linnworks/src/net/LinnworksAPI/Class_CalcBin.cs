using System;
using System.Collections.Generic;
//ReSharper disable UnusedMember.Global
namespace LinnworksAPI
{
    public class CalcBin
    {
        public Guid pkBinId;
        public string TrackingNumber;
        public string LabelId;
        public decimal? Weight;
        public DateTime? PrintDate;
        public decimal? Cost;
        public Guid fkPackagingTypeId;
        public decimal? Width;
        public decimal? Height;
        public decimal? Depth;
        public decimal? PackagingWeight;
        public decimal? ItemWeight;
        public bool ManualAdjust;
        public List<CalcBinItem> Items;
        public SqlDataRecord DataRecordMetaData;
    }
}
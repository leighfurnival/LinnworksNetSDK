using System;
using System.Collections.Generic;
//ReSharper disable UnusedMember.Global
namespace LinnworksAPI
{
    public class CalcOrderHeader
    {
        public Guid pkOrderID;
        public int nOrderId;
        public Guid fkPostalServiceId;
        public Guid fkCountryId;
        public string cCountry;
        public double ItemWeight;
        public Guid fkPackagingGroupId;
        public Guid fkPackagingTypeId;
        public bool IsSplitPackaging;
        public double PackagingWeight;
        public double TotalWeight;
        public decimal? TotalWidth;
        public decimal? TotalHeight;
        public decimal? TotalDepth;
        public bool ManualAdjust;
        public int SplitPackageCount;
        public bool LabelPrinted;
        public List<string> CalculationHints;
        public List<CalcOrderItem> Items;
        public List<CalcBin> Bins;
        public CalcMethod DimMethod;
        public SqlDataRecord DataRecordMetaData;
    }
}
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
<<<<<<< HEAD
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
=======
        public Boolean IsSplitPackaging;
        public Double PackagingWeight;
        public Double TotalWeight;
        public Decimal? TotalWidth;
        public Decimal? TotalHeight;
        public Decimal? TotalDepth;
        public Boolean ManualAdjust;
        public Boolean CanAutoSplit;
        public Boolean IsAutoSplit;
        public Int32 SplitPackageCount;
        public Boolean LabelPrinted;
        public List<String> CalculationHints;
>>>>>>> refs/remotes/LinnSystems/master
        public List<CalcOrderItem> Items;
        public List<CalcBin> Bins;
        public PackingResult ThreeDimPackaging;
        public CalcMethod DimMethod;
        public SqlDataRecord DataRecordMetaData;
    }
}
using System;

namespace LinnworksAPI
{
    public class ScheduleConfiguration
    {
        public RepetitionType RepetitionType;
        public DateTime? OneTimeDate;
        public DailyFrequencyType? DailyFrequency;
        public DateTime? OccursFrequencyStartingDate;
        public int? OccursFrequencyEveryX;
        public string WeeklyDays;
        public RepetitionType? OccursFrequency;
        public string OccursOnceAtTime;
        public int? OccursEveryHours;
        public string StartingTime;
        public string EndingTime;
        public bool Enabled;
    }
}
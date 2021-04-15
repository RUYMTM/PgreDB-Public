using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class TradingTactic
    {
        public int TradingTacticId { get; set; }
        public DateTime CreationTimestamp { get; set; }
        public int ScheduleIdentificationGroupId { get; set; }
        public string BalanceGroupType { get; set; }
        public int FogTimeHorizontMin { get; set; }
        public bool UsingXg { get; set; }
        public decimal PowerLimitForXgKw { get; set; }
        public decimal SunPositionLimitForXg { get; set; }
        public decimal SunPositionLimitForSmoothing { get; set; }
        public decimal SmoothingVariable { get; set; }
        public decimal FogyGradientCorrection { get; set; }
        public decimal DaSunnyWeatherModValue { get; set; }
        public decimal DaModerateWeatherModValue { get; set; }
        public decimal DaCloudyWeatherModValue { get; set; }
        public decimal IdSunnyWeatherModValue { get; set; }
        public decimal IdModerateWeatherModValue { get; set; }
        public decimal IdCloudyWeatherModValue { get; set; }
        public decimal UpSystemStateSunnyLowerLimitMw { get; set; }
        public decimal UpSystemStateSunnyUpperLimitMw { get; set; }
        public decimal UpSystemStateSunnyCorrection { get; set; }
        public decimal UpSystemStateModerateLowerLimitMw { get; set; }
        public decimal UpSystemStateModerateUpperLimitMw { get; set; }
        public decimal UpSystemStateModerateCorrection { get; set; }
        public decimal UpSystemStateCloudyLowerLimitMw { get; set; }
        public decimal UpSystemStateCloudyUpperLimitMw { get; set; }
        public decimal UpSystemStateCloudyCorrection { get; set; }
        public decimal DownSystemStateSunnyLowerLimitMw { get; set; }
        public decimal DownSystemStateSunnyUpperLimitMw { get; set; }
        public decimal DownSystemStateSunnyCorrection { get; set; }
        public decimal DownSystemStateModerateLowerLimitMw { get; set; }
        public decimal DownSystemStateModerateUpperLimitMw { get; set; }
        public decimal DownSystemStateModerateCorrection { get; set; }
        public decimal DownSystemStateCloudyLowerLimitMw { get; set; }
        public decimal DownSystemStateCloudyUpperLimitMw { get; set; }
        public decimal DownSystemStateCloudyCorrection { get; set; }
        public decimal ActualPowerToIdScheduleFogLimit { get; set; }
        public decimal ActualPowerToIdScheduleFogUsage { get; set; }
        public decimal ActualPowerToIdScheduleSunLimit { get; set; }
        public decimal ActualPowerToIdScheduleSunLimitStage { get; set; }
        public decimal ActualPowerToIdScheduleSunUsageFirstStage { get; set; }
        public decimal ActualPowerToIdScheduleSunUsageSecondStage { get; set; }
        public decimal ActualPowerToIdScheduleModerateLimit { get; set; }
        public decimal ActualPowerToIdScheduleModerateUpperLimit { get; set; }
        public decimal ActualPowerToIdScheduleModerateStandardUsage { get; set; }
        public decimal ActualPowerToIdScheduleModerateMaxUsage { get; set; }
        public decimal ActualPowerToIdScheduleCloudyLimit { get; set; }
        public decimal ActualPowerToIdScheduleCloudyUsage { get; set; }
        public decimal StartTimeAfterSunriseNoSunriseMin { get; set; }
        public decimal EndTimeCalculationAfterSunriseMin { get; set; }
        public decimal EndTimeAfterSunriseMin { get; set; }
        public decimal SmoothingPercentageLimit { get; set; }
        public string SystemStateAdjustmentsJson { get; set; }
        public bool AutoSystemStateCorrection { get; set; }
        public string Country { get; set; }
        public decimal? BadWeatherModVariable { get; set; }
        public decimal? GoodWeatherModVariable { get; set; }
        public string DaUsageSunnyTimeLimit { get; set; }
        public decimal DaUsageSunnyRateLimit { get; set; }
        public decimal AffrRampDownActivationPriceLimit { get; set; }
        public decimal CriticalEventPowerBuying { get; set; }
        public decimal CriticalEventPowerSelling { get; set; }
    }
}

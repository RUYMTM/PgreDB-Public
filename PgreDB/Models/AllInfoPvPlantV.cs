using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace PgreDB.Models
{
    public partial class AllInfoPvPlantV
    {
    
        public int PowerPlantId { get; set; }
        public string EwiserAzonosito { get; set; }
        [Required]
        public string EromuNeve { get; set; }//szerk
        [Required]
        public string LocationCity { get; set; }//szerk
        public string LocationParcelNumber { get; set; }//szerk
        public string MeteringPointIdentification { get; set; }
        public bool? MkpSynced { get; set; }
        public string DocumentSz { get; set; }
        public string DocumentCs { get; set; }
        public string DocumentE { get; set; }
        public string HivatalosTulajCegnev { get; set; }
        public string SzamalazasCegnev { get; set; }
        public string UzemeltetoCegnev { get; set; }
        public string KozvetitoCegnev { get; set; }
        public string Userek { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public DateTime? KatContractStartDate { get; set; }
        public DateTime? RealProductionStartDate { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public int? PvModuleNumber { get; set; }
        public double? PvModulePower { get; set; }
        [Range(0, 4000000)]
        public int? TotalInverterPowerWatt { get; set; }//szerk
        public double? InverterMaxEfficiency { get; set; }
        public string MekhId { get; set; }
        public int? ScheduleIdentificationGroupId { get; set; }
        public int? ScheduleIdentificationGroupPrevId { get; set; }
        public DateTime? ScheduleIdentificationGroupPrevDate { get; set; }
        public string MekSendersTimeSeriesIdentification { get; set; }
        public string MekSendersTimeSeriesSequentialIdentification { get; set; }
        public string ElozoCsoportFelhnev { get; set; }
        public string ScheduleDestination { get; set; }
        public string CsoportFelhnev { get; set; }
        public DateTime? MekLastPasswordRenewingDate { get; set; }
        public bool? ActivePrediction { get; set; }
        public bool? ActiveInverterMonitoring { get; set; }
        public bool? ActiveMekh { get; set; }
        public bool? ActiveBilling { get; set; }
        public decimal? TotalBaseFee { get; set; }
        public decimal? TotalFeedInTariffFixFee { get; set; }
        public decimal? TotalSuccessFee { get; set; }
    }
}

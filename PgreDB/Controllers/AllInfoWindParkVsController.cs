using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PgreDB.Models;

namespace PgreDB.Controllers
{
    public class AllInfoWindParkVsController : Controller
    {
        private readonly ewiv2coreContext _context;

        public AllInfoWindParkVsController(ewiv2coreContext context)
        {
            _context = context;
        }

        // GET: AllInfoWindParkVs
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewBag.PowerPlantIdSortParm = String.IsNullOrEmpty(sortOrder) ? "PowerPlantId_desc" : "";
            ViewBag.EwiserAzonositoSortParm = sortOrder == "EwiserAzonosito" ? "EwiserAzonosito_desc" : "EwiserAzonosito";
            ViewBag.EromuNeveSortParm = sortOrder == "EromuNeve" ? "EromuNeve_desc" : "EromuNeve";
            ViewBag.LocationCitySortParm = sortOrder == "LocationCity" ? "LocationCity_desc" : "LocationCity";
            ViewBag.LocationParcelNumberSortParm = sortOrder == "LocationParcelNumber" ? "LocationParcelNumber_desc" : "LocationParcelNumber";
            ViewBag.MeteringPointIdentificationSortParm = sortOrder == "MeteringPointIdentification" ? "MeteringPointIdentification_desc" : "MeteringPointIdentification";
            ViewBag.MkpSyncedSortParm = sortOrder == "MkpSynced" ? "MkpSynced_desc" : "MkpSynced";
            ViewBag.HivatalosTulajCegnevSortParm = sortOrder == "HivatalosTulajCegnev" ? "HivatalosTulajCegnev_desc" : "HivatalosTulajCegnev";
            ViewBag.SzamalazasCegnevSortParm = sortOrder == "SzamalazasCegnev" ? "SzamalazasCegnev_desc" : "SzamalazasCegnev";
            ViewBag.UzemeltetoCegnevSortParm = sortOrder == "UzemeltetoCegnev" ? "UzemeltetoCegnev_desc" : "UzemeltetoCegnev";
            ViewBag.KozvetitoCegnevSortParm = sortOrder == "KozvetitoCegnev" ? "KozvetitoCegnev_desc" : "KozvetitoCegnev";
            ViewBag.UserekSortParm = sortOrder == "Userek" ? "Userek_desc" : "Userek";
            ViewBag.LatitudeSortParm = sortOrder == "Latitude" ? "Latitude_desc" : "Latitude";
            ViewBag.LongitudeSortParm = sortOrder == "Longitude" ? "Longitude_desc" : "Longitude";
            ViewBag.RealProductionStartDateSortParm = sortOrder == "RealProductionStartDate" ? "RealProductionStartDate_desc" : "RealProductionStartDate";
            ViewBag.RegistrationDateSortParm = sortOrder == "RegistrationDate" ? "RegistrationDate_desc" : "RegistrationDate";
            ViewBag.KatContractStartDateSortParm = sortOrder == "KatContractStartDate" ? "KatContractStartDate_desc" : "KatContractStartDate";
            ViewBag.PowerOutputWattSortParm = sortOrder == "PowerOutputWatt" ? "PowerOutputWatt_desc" : "PowerOutputWatt";
            ViewBag.MekhIdSortParm = sortOrder == "MekhId" ? "MekhId_desc" : "MekhId";
            ViewBag.ScheduleIdentificationGroupIdSortParm = sortOrder == "ScheduleIdentificationGroupId" ? "ScheduleIdentificationGroupId_desc" : "ScheduleIdentificationGroupId";
            ViewBag.ScheduleIdentificationGroupPrevIdSortParm = sortOrder == "ScheduleIdentificationGroupPrevId" ? "ScheduleIdentificationGroupPrevId_desc" : "ScheduleIdentificationGroupPrevId";
            ViewBag.ScheduleIdentificationGroupPrevDateSortParm = sortOrder == "ScheduleIdentificationGroupPrevDate" ? "ScheduleIdentificationGroupPrevDate_desc" : "ScheduleIdentificationGroupPrevDate";
            ViewBag.MekSendersTimeSeriesIdentificationSortParm = sortOrder == "MekSendersTimeSeriesIdentification" ? "MekSendersTimeSeriesIdentification_desc" : "MekSendersTimeSeriesIdentification";
            ViewBag.MekSendersTimeSeriesSequentialIdentificationSortParm = sortOrder == "MekSendersTimeSeriesSequentialIdentification" ? "MekSendersTimeSeriesSequentialIdentification_desc" : "MekSendersTimeSeriesSequentialIdentification";
            ViewBag.ElozoCsoportFelhnevSortParm = sortOrder == "ElozoCsoportFelhnev" ? "ElozoCsoportFelhnev_desc" : "ElozoCsoportFelhnev";
            ViewBag.ScheduleDestinationSortParm = sortOrder == "ScheduleDestination" ? "ScheduleDestination_desc" : "ScheduleDestination";
            ViewBag.CsoportFelhnevSortParm = sortOrder == "CsoportFelhnev" ? "CsoportFelhnev_desc" : "CsoportFelhnev";
            ViewBag.MekLastPasswordRenewingDateSortParm = sortOrder == "MekLastPasswordRenewingDate" ? "MekLastPasswordRenewingDate_desc" : "MekLastPasswordRenewingDate";
            ViewBag.ActivePredictionSortParm = sortOrder == "ActivePrediction" ? "ActivePrediction_desc" : "ActivePrediction";
            ViewBag.ActiveInverterMonitoringSortParm = sortOrder == "ActiveInverterMonitoring" ? "ActiveInverterMonitoring_desc" : "ActiveInverterMonitoring";
            ViewBag.ActiveMekhSortParm = sortOrder == "ActiveMekh" ? "ActiveMekh_desc" : "ActiveMekh";
            ViewBag.ActiveBillingSortParm = sortOrder == "ActiveBilling" ? "ActiveBilling_desc" : "ActiveBilling";
            ViewBag.TotalBaseFeeSortParm = sortOrder == "TotalBaseFee" ? "TotalBaseFee_desc" : "TotalBaseFee";
            ViewBag.TotalFeedInTariffFixFeeSortParm = sortOrder == "TotalFeedInTariffFixFee" ? "TotalFeedInTariffFixFee_desc" : "TotalFeedInTariffFixFee";
            ViewBag.TotalSuccessFeeSortParm = sortOrder == "TotalSuccessFee" ? "TotalSuccessFee_desc" : "TotalSuccessFee";
            var AllInfoWindParkV = from s in _context.AllInfoWindParkVs select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                AllInfoWindParkV = AllInfoWindParkV.Where(s => s.PowerPlantId.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.EwiserAzonosito.ToUpper().Contains(searchString.ToUpper())
                || s.EromuNeve.ToUpper().Contains(searchString.ToUpper())
                || s.LocationCity.ToUpper().Contains(searchString.ToUpper())
                || s.LocationParcelNumber.ToUpper().Contains(searchString.ToUpper())
                || s.MeteringPointIdentification.ToUpper().Contains(searchString.ToUpper())
                || s.MkpSynced.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.HivatalosTulajCegnev.ToUpper().Contains(searchString.ToUpper())
                || s.SzamalazasCegnev.ToUpper().Contains(searchString.ToUpper())
                || s.UzemeltetoCegnev.ToUpper().Contains(searchString.ToUpper())
                || s.KozvetitoCegnev.ToUpper().Contains(searchString.ToUpper())
                || s.Userek.ToUpper().Contains(searchString.ToUpper())
                || s.Latitude.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.Longitude.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.RealProductionStartDate.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.RegistrationDate.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.KatContractStartDate.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.PowerOutputWatt.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.MekhId.ToUpper().Contains(searchString.ToUpper())
                || s.ScheduleIdentificationGroupId.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.ScheduleIdentificationGroupPrevId.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.ScheduleIdentificationGroupPrevDate.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.MekSendersTimeSeriesIdentification.ToUpper().Contains(searchString.ToUpper())
                || s.MekSendersTimeSeriesSequentialIdentification.ToUpper().Contains(searchString.ToUpper())
                || s.ElozoCsoportFelhnev.ToUpper().Contains(searchString.ToUpper())
                || s.ScheduleDestination.ToUpper().Contains(searchString.ToUpper())
                || s.CsoportFelhnev.ToUpper().Contains(searchString.ToUpper())
                || s.MekLastPasswordRenewingDate.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.ActivePrediction.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.ActiveInverterMonitoring.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.ActiveMekh.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.ActiveBilling.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.TotalBaseFee.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.TotalFeedInTariffFixFee.ToString().ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "PowerPlantId_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.PowerPlantId);
                    break;
                case "EwiserAzonosito":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.EwiserAzonosito);
                    break;
                case "EwiserAzonosito_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.EwiserAzonosito);
                    break;
                case "EromuNeve":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.EromuNeve);
                    break;
                case "EromuNeve_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.EromuNeve);
                    break;
                case "LocationCity":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.LocationCity);
                    break;
                case "LocationCity_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.LocationCity);
                    break;
                case "LocationParcelNumber":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.LocationParcelNumber);
                    break;
                case "LocationParcelNumber_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.LocationParcelNumber);
                    break;
                case "MeteringPointIdentification":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.MeteringPointIdentification);
                    break;
                case "MeteringPointIdentification_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.MeteringPointIdentification);
                    break;
                case "MkpSynced":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.MkpSynced);
                    break;
                case "MkpSynced_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.MkpSynced);
                    break;
                case "HivatalosTulajCegnev":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.HivatalosTulajCegnev);
                    break;
                case "HivatalosTulajCegnev_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.HivatalosTulajCegnev);
                    break;
                case "SzamalazasCegnev":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.SzamalazasCegnev);
                    break;
                case "SzamalazasCegnev_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.SzamalazasCegnev);
                    break;
                case "UzemeltetoCegnev":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.UzemeltetoCegnev);
                    break;
                case "UzemeltetoCegnev_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.UzemeltetoCegnev);
                    break;
                case "KozvetitoCegnev":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.KozvetitoCegnev);
                    break;
                case "KozvetitoCegnev_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.KozvetitoCegnev);
                    break;
                case "Userek":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.Userek);
                    break;
                case "Userek_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.Userek);
                    break;
                case "Latitude":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.Latitude);
                    break;
                case "Latitude_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.Latitude);
                    break;
                case "Longitude":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.Longitude);
                    break;
                case "Longitude_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.Longitude);
                    break;
                case "RealProductionStartDate":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.RealProductionStartDate);
                    break;
                case "RealProductionStartDate_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.RealProductionStartDate);
                    break;
                case "RegistrationDate":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.RegistrationDate);
                    break;
                case "RegistrationDate_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.RegistrationDate);
                    break;
                case "KatContractStartDate":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.KatContractStartDate);
                    break;
                case "KatContractStartDate_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.KatContractStartDate);
                    break;
                case "PowerOutputWatt":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.PowerOutputWatt);
                    break;
                case "PowerOutputWatt_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.PowerOutputWatt);
                    break;
                case "MekhId":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.MekhId);
                    break;
                case "MekhId_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.MekhId);
                    break;
                case "ScheduleIdentificationGroupId":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.ScheduleIdentificationGroupId);
                    break;
                case "ScheduleIdentificationGroupId_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.ScheduleIdentificationGroupId);
                    break;
                case "ScheduleIdentificationGroupPrevId":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.ScheduleIdentificationGroupPrevId);
                    break;
                case "ScheduleIdentificationGroupPrevId_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.ScheduleIdentificationGroupPrevId);
                    break;
                case "ScheduleIdentificationGroupPrevDate":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.ScheduleIdentificationGroupPrevDate);
                    break;
                case "ScheduleIdentificationGroupPrevDate_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.ScheduleIdentificationGroupPrevDate);
                    break;
                case "MekSendersTimeSeriesIdentification":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.MekSendersTimeSeriesIdentification);
                    break;
                case "MekSendersTimeSeriesIdentification_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.MekSendersTimeSeriesIdentification);
                    break;
                case "MekSendersTimeSeriesSequentialIdentification":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.MekSendersTimeSeriesSequentialIdentification);
                    break;
                case "MekSendersTimeSeriesSequentialIdentification_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.MekSendersTimeSeriesSequentialIdentification);
                    break;
                case "ElozoCsoportFelhnev":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.ElozoCsoportFelhnev);
                    break;
                case "ElozoCsoportFelhnev_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.ElozoCsoportFelhnev);
                    break;
                case "ScheduleDestination":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.ScheduleDestination);
                    break;
                case "ScheduleDestination_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.ScheduleDestination);
                    break;
                case "CsoportFelhnev":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.CsoportFelhnev);
                    break;
                case "CsoportFelhnev_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.CsoportFelhnev);
                    break;
                case "MekLastPasswordRenewingDate":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.MekLastPasswordRenewingDate);
                    break;
                case "MekLastPasswordRenewingDate_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.MekLastPasswordRenewingDate);
                    break;
                case "ActivePrediction":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.ActivePrediction);
                    break;
                case "ActivePrediction_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.ActivePrediction);
                    break;
                case "ActiveInverterMonitoring":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.ActiveInverterMonitoring);
                    break;
                case "ActiveInverterMonitoring_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.ActiveInverterMonitoring);
                    break;
                case "ActiveMekh":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.ActiveMekh);
                    break;
                case "ActiveMekh_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.ActiveMekh);
                    break;
                case "ActiveBilling":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.ActiveBilling);
                    break;
                case "ActiveBilling_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.ActiveBilling);
                    break;
                case "TotalBaseFee":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.TotalBaseFee);
                    break;
                case "TotalBaseFee_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.TotalBaseFee);
                    break;
                case "TotalFeedInTariffFixFee":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.TotalFeedInTariffFixFee);
                    break;
                case "TotalFeedInTariffFixFee_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.TotalFeedInTariffFixFee);
                    break;
                case "TotalSuccessFee":
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.TotalSuccessFee);
                    break;
                case "TotalSuccessFee_desc":
                    AllInfoWindParkV = AllInfoWindParkV.OrderByDescending(s => s.TotalSuccessFee);
                    break;
                default:
                    AllInfoWindParkV = AllInfoWindParkV.OrderBy(s => s.PowerPlantId);
                    break;
            }

            return View(await AllInfoWindParkV.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Edit(List<AllInfoWindParkV> Model)
        {
            foreach (AllInfoWindParkV item in Model)
            {
                _context.Update(item);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}

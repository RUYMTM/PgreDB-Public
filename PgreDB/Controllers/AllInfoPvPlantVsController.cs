using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PgreDB.Models;

namespace PgreDB.Controllers
{
    public class AllInfoPvPlantVsController : Controller
    {
        private readonly ewiv2coreContext _context;

        public AllInfoPvPlantVsController(ewiv2coreContext context)
        {
            _context = context;
        }

        // GET: AllInfoPvPlantVs
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewBag.PowerPlantIdSortParm = String.IsNullOrEmpty(sortOrder) ? "PowerPlantId_desc" : "";
            ViewBag.EwiserAzonositoSortParm = sortOrder == "EwiserAzonosito" ? "EwiserAzonosito_desc" : "EwiserAzonosito";
            ViewBag.EromuNeveSortParm = sortOrder == "EromuNeve" ? "EromuNeve_desc" : "EromuNeve";
            ViewBag.LocationCitySortParm = sortOrder == "LocationCity" ? "LocationCity_desc" : "LocationCity";
            ViewBag.LocationParcelNumberSortParm = sortOrder == "LocationParcelNumber" ? "LocationParcelNumber_desc" : "LocationParcelNumber";
            ViewBag.MeteringPointIdentificationSortParm = sortOrder == "MeteringPointIdentification" ? "MeteringPointIdentification_desc" : "MeteringPointIdentification";
            ViewBag.MkpSyncedSortParm = sortOrder == "MkpSynced" ? "MkpSynced_desc" : "MkpSynced";
            ViewBag.DocumentSzSortParm = sortOrder == "DocumentSz" ? "DocumentSz_desc" : "DocumentSz";
            ViewBag.DocumentCsSortParm = sortOrder == "DocumentCs" ? "DocumentCs_desc" : "DocumentCs";
            ViewBag.DocumentESortParm = sortOrder == "DocumentE" ? "DocumentE_desc" : "DocumentE";
            ViewBag.HivatalosTulajCegnevSortParm = sortOrder == "HivatalosTulajCegnev" ? "HivatalosTulajCegnev_desc" : "HivatalosTulajCegnev";
            ViewBag.SzamalazasCegnevSortParm = sortOrder == "SzamalazasCegnev" ? "SzamalazasCegnev_desc" : "SzamalazasCegnev";
            ViewBag.UzemeltetoCegnevSortParm = sortOrder == "UzemeltetoCegnev" ? "UzemeltetoCegnev_desc" : "UzemeltetoCegnev";
            ViewBag.KozvetitoCegnevSortParm = sortOrder == "KozvetitoCegnev" ? "KozvetitoCegnev_desc" : "KozvetitoCegnev";
            ViewBag.UserekSortParm = sortOrder == "Userek" ? "Userek_desc" : "Userek";
            ViewBag.LatitudeSortParm = sortOrder == "Latitude" ? "Latitude_desc" : "Latitude";
            ViewBag.LongitudeSortParm = sortOrder == "Longitude" ? "Longitude_desc" : "Longitude";
            ViewBag.KatContractStartDateSortParm = sortOrder == "KatContractStartDate" ? "KatContractStartDate_desc" : "KatContractStartDate";
            ViewBag.RealProductionStartDateSortParm = sortOrder == "RealProductionStartDate" ? "RealProductionStartDate_desc" : "RealProductionStartDate";
            ViewBag.RegistrationDateSortParm = sortOrder == "RegistrationDate" ? "RegistrationDate_desc" : "RegistrationDate";
            ViewBag.PvModuleNumberSortParm = sortOrder == "PvModuleNumber" ? "PvModuleNumber_desc" : "PvModuleNumber";
            ViewBag.PvModulePowerSortParm = sortOrder == "PvModulePower" ? "PvModulePower_desc" : "PvModulePower";
            ViewBag.TotalInverterPowerWattSortParm = sortOrder == "TotalInverterPowerWatt" ? "TotalInverterPowerWatt_desc" : "TotalInverterPowerWatt";
            ViewBag.InverterMaxEfficiencySortParm = sortOrder == "InverterMaxEfficiency" ? "InverterMaxEfficiency_desc" : "InverterMaxEfficiency";
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

            var AllInfoPvPlantV = from s in _context.AllInfoPvPlantVs select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                AllInfoPvPlantV = AllInfoPvPlantV.Where(s => s.PowerPlantId.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.EwiserAzonosito.ToUpper().Contains(searchString.ToUpper())
                || s.EromuNeve.ToUpper().Contains(searchString.ToUpper())
                || s.LocationCity.ToUpper().Contains(searchString.ToUpper())
                || s.LocationParcelNumber.ToUpper().Contains(searchString.ToUpper())
                || s.MeteringPointIdentification.ToUpper().Contains(searchString.ToUpper())
                || s.MkpSynced.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.DocumentSz.ToUpper().Contains(searchString.ToUpper())
                || s.DocumentCs.ToUpper().Contains(searchString.ToUpper())
                || s.DocumentE.ToUpper().Contains(searchString.ToUpper())
                || s.HivatalosTulajCegnev.ToUpper().Contains(searchString.ToUpper())
                || s.SzamalazasCegnev.ToUpper().Contains(searchString.ToUpper())
                || s.UzemeltetoCegnev.ToUpper().Contains(searchString.ToUpper())
                || s.KozvetitoCegnev.ToUpper().Contains(searchString.ToUpper())
                || s.Userek.ToUpper().Contains(searchString.ToUpper())
                || s.Latitude.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.Longitude.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.KatContractStartDate.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.RealProductionStartDate.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.RegistrationDate.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.PvModuleNumber.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.PvModulePower.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.TotalInverterPowerWatt.ToString().ToUpper().Contains(searchString.ToUpper())
                || s.InverterMaxEfficiency.ToString().ToUpper().Contains(searchString.ToUpper())
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
                || s.TotalFeedInTariffFixFee.ToString().ToUpper().Contains(searchString.ToUpper())
);
            }

            switch (sortOrder)
            {
                case "PowerPlantId_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.PowerPlantId);
                    break;
                case "EwiserAzonosito":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.EwiserAzonosito);
                    break;
                case "EwiserAzonosito_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.EwiserAzonosito);
                    break;
                case "EromuNeve":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.EromuNeve);
                    break;
                case "EromuNeve_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.EromuNeve);
                    break;
                case "LocationCity":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.LocationCity);
                    break;
                case "LocationCity_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.LocationCity);
                    break;
                case "LocationParcelNumber":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.LocationParcelNumber);
                    break;
                case "LocationParcelNumber_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.LocationParcelNumber);
                    break;
                case "MeteringPointIdentification":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.MeteringPointIdentification);
                    break;
                case "MeteringPointIdentification_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.MeteringPointIdentification);
                    break;
                case "MkpSynced":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.MkpSynced);
                    break;
                case "MkpSynced_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.MkpSynced);
                    break;
                case "DocumentSz":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.DocumentSz);
                    break;
                case "DocumentSz_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.DocumentSz);
                    break;
                case "DocumentCs":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.DocumentCs);
                    break;
                case "DocumentCs_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.DocumentCs);
                    break;
                case "DocumentE":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.DocumentE);
                    break;
                case "DocumentE_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.DocumentE);
                    break;
                case "HivatalosTulajCegnev":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.HivatalosTulajCegnev);
                    break;
                case "HivatalosTulajCegnev_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.HivatalosTulajCegnev);
                    break;
                case "SzamalazasCegnev":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.SzamalazasCegnev);
                    break;
                case "SzamalazasCegnev_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.SzamalazasCegnev);
                    break;
                case "UzemeltetoCegnev":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.UzemeltetoCegnev);
                    break;
                case "UzemeltetoCegnev_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.UzemeltetoCegnev);
                    break;
                case "KozvetitoCegnev":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.KozvetitoCegnev);
                    break;
                case "KozvetitoCegnev_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.KozvetitoCegnev);
                    break;
                case "Userek":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.Userek);
                    break;
                case "Userek_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.Userek);
                    break;
                case "Latitude":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.Latitude);
                    break;
                case "Latitude_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.Latitude);
                    break;
                case "Longitude":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.Longitude);
                    break;
                case "Longitude_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.Longitude);
                    break;
                case "KatContractStartDate":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.KatContractStartDate);
                    break;
                case "KatContractStartDate_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.KatContractStartDate);
                    break;
                case "RealProductionStartDate":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.RealProductionStartDate);
                    break;
                case "RealProductionStartDate_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.RealProductionStartDate);
                    break;
                case "RegistrationDate":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.RegistrationDate);
                    break;
                case "RegistrationDate_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.RegistrationDate);
                    break;
                case "PvModuleNumber":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.PvModuleNumber);
                    break;
                case "PvModuleNumber_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.PvModuleNumber);
                    break;
                case "PvModulePower":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.PvModulePower);
                    break;
                case "PvModulePower_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.PvModulePower);
                    break;
                case "TotalInverterPowerWatt":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.TotalInverterPowerWatt);
                    break;
                case "TotalInverterPowerWatt_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.TotalInverterPowerWatt);
                    break;
                case "InverterMaxEfficiency":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.InverterMaxEfficiency);
                    break;
                case "InverterMaxEfficiency_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.InverterMaxEfficiency);
                    break;
                case "MekhId":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.MekhId);
                    break;
                case "MekhId_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.MekhId);
                    break;
                case "ScheduleIdentificationGroupId":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.ScheduleIdentificationGroupId);
                    break;
                case "ScheduleIdentificationGroupId_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.ScheduleIdentificationGroupId);
                    break;
                case "ScheduleIdentificationGroupPrevId":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.ScheduleIdentificationGroupPrevId);
                    break;
                case "ScheduleIdentificationGroupPrevId_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.ScheduleIdentificationGroupPrevId);
                    break;
                case "ScheduleIdentificationGroupPrevDate":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.ScheduleIdentificationGroupPrevDate);
                    break;
                case "ScheduleIdentificationGroupPrevDate_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.ScheduleIdentificationGroupPrevDate);
                    break;
                case "MekSendersTimeSeriesIdentification":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.MekSendersTimeSeriesIdentification);
                    break;
                case "MekSendersTimeSeriesIdentification_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.MekSendersTimeSeriesIdentification);
                    break;
                case "MekSendersTimeSeriesSequentialIdentification":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.MekSendersTimeSeriesSequentialIdentification);
                    break;
                case "MekSendersTimeSeriesSequentialIdentification_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.MekSendersTimeSeriesSequentialIdentification);
                    break;
                case "ElozoCsoportFelhnev":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.ElozoCsoportFelhnev);
                    break;
                case "ElozoCsoportFelhnev_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.ElozoCsoportFelhnev);
                    break;
                case "ScheduleDestination":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.ScheduleDestination);
                    break;
                case "ScheduleDestination_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.ScheduleDestination);
                    break;
                case "CsoportFelhnev":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.CsoportFelhnev);
                    break;
                case "CsoportFelhnev_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.CsoportFelhnev);
                    break;
                case "MekLastPasswordRenewingDate":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.MekLastPasswordRenewingDate);
                    break;
                case "MekLastPasswordRenewingDate_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.MekLastPasswordRenewingDate);
                    break;
                case "ActivePrediction":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.ActivePrediction);
                    break;
                case "ActivePrediction_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.ActivePrediction);
                    break;
                case "ActiveInverterMonitoring":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.ActiveInverterMonitoring);
                    break;
                case "ActiveInverterMonitoring_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.ActiveInverterMonitoring);
                    break;
                case "ActiveMekh":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.ActiveMekh);
                    break;
                case "ActiveMekh_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.ActiveMekh);
                    break;
                case "ActiveBilling":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.ActiveBilling);
                    break;
                case "ActiveBilling_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.ActiveBilling);
                    break;
                case "TotalBaseFee":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.TotalBaseFee);
                    break;
                case "TotalBaseFee_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.TotalBaseFee);
                    break;
                case "TotalFeedInTariffFixFee":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.TotalFeedInTariffFixFee);
                    break;
                case "TotalFeedInTariffFixFee_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.TotalFeedInTariffFixFee);
                    break;
                case "TotalSuccessFee":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.TotalSuccessFee);
                    break;
                case "TotalSuccessFee_desc":
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderByDescending(s => s.TotalSuccessFee);
                    break;
                default:
                    AllInfoPvPlantV = AllInfoPvPlantV.OrderBy(s => s.PowerPlantId);
                    break;
            }


            return View(await AllInfoPvPlantV.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Edit(List<PgreDB.Models.AllInfoPvPlantV> Model)
        {
            if (ModelState.IsValid)
            {
                if (Model.Count != 0)
                {
                    foreach (AllInfoPvPlantV item in Model)
                    {

                        PowerPlant tmpPP = _context.PowerPlants.Find(item.PowerPlantId);
                        tmpPP.Name = item.EromuNeve;
                        tmpPP.LocationCity = item.LocationCity;
                        if (item.LocationParcelNumber != null)
                        {
                            tmpPP.LocationParcelNumber = item.LocationParcelNumber;
                        }
                        else
                        {
                            tmpPP.LocationParcelNumber = "";
                        }

                        tmpPP.LocationParcelNumber = item.LocationParcelNumber;
                        PvPlantPhysical tmpPPP = _context.PvPlantPhysicals
                         .Where(b => b.PowerPlantId == item.PowerPlantId)
                         .FirstOrDefault();
                        _context.Update(tmpPP);
                        _context.Update(tmpPPP);

                    }

                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToAction("Index");
            
        }
    }
}

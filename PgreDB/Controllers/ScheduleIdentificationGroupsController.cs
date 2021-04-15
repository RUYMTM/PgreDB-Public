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
    public class ScheduleIdentificationGroupsController : Controller
    {
        private readonly ewiv2coreContext _context;

        public ScheduleIdentificationGroupsController(ewiv2coreContext context)
        {
            _context = context;
        }

        // GET: ScheduleIdentificationGroups
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {

            ViewBag.IdSortParm = String.IsNullOrEmpty(sortOrder) ? "ScheduleIdentificationGroupId_desc" : "";
            ViewBag.MSISortParm = sortOrder == "MekSenderIdentification" ? "MekSenderIdentification_desc" : "MekSenderIdentification";
            ViewBag.MUSortParm = sortOrder == "MekUsername" ? "MekUsername_desc" : "MekUsername";
            ViewBag.MPSortParm = sortOrder == "MekPassword" ? "MekPassword_desc" : "MekPassword";
            ViewBag.MLPRDSortParm = sortOrder == "MekLastPasswordRenewingDate" ? "MekLastPasswordRenewingDate_desc" : "MekLastPasswordRenewingDate";

            var ScheduleIdentificationGroups = from s in _context.ScheduleIdentificationGroups select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                ScheduleIdentificationGroups = ScheduleIdentificationGroups.Where(s => s.ScheduleIdentificationGroupId.ToString().ToUpper().Contains(searchString.ToUpper())
                                       || s.MekSenderIdentification.ToUpper().Contains(searchString.ToUpper()) || s.MekUsername.ToUpper().Contains(searchString.ToUpper()) 
                                       || s.MekPassword.ToUpper().Contains(searchString.ToUpper())
                                       || s.MekLastPasswordRenewingDate.ToString().ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "ScheduleIdentificationGroupId_desc":
                    ScheduleIdentificationGroups = ScheduleIdentificationGroups.OrderByDescending(s => s.ScheduleIdentificationGroupId);
                    break;
                case "MekSenderIdentification":
                    ScheduleIdentificationGroups = ScheduleIdentificationGroups.OrderBy(s => s.MekSenderIdentification);
                    break;
                case "MekSenderIdentification_desc":
                    ScheduleIdentificationGroups = ScheduleIdentificationGroups.OrderByDescending(s => s.MekSenderIdentification);
                    break;
                case "MekUsername":
                    ScheduleIdentificationGroups = ScheduleIdentificationGroups.OrderBy(s => s.MekUsername);
                    break;
                case "MekUsername_desc":
                    ScheduleIdentificationGroups = ScheduleIdentificationGroups.OrderByDescending(s => s.MekUsername);
                    break;
                case "MekPassword":
                    ScheduleIdentificationGroups = ScheduleIdentificationGroups.OrderBy(s => s.MekPassword);
                    break;
                case "MekPassword_desc":
                    ScheduleIdentificationGroups = ScheduleIdentificationGroups.OrderByDescending(s => s.MekPassword);
                    break;
                case "MekLastPasswordRenewingDate":
                    ScheduleIdentificationGroups = ScheduleIdentificationGroups.OrderBy(s => s.MekLastPasswordRenewingDate);
                    break;
                case "MekLastPasswordRenewingDate_desc":
                    ScheduleIdentificationGroups = ScheduleIdentificationGroups.OrderByDescending(s => s.MekLastPasswordRenewingDate);
                    break;
                default:
                    ScheduleIdentificationGroups = ScheduleIdentificationGroups.OrderBy(s => s.ScheduleIdentificationGroupId);
                    break;
            }

            return View(await ScheduleIdentificationGroups.ToListAsync());
        }

   
    }
}

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
    
    public class TesttablasController : Controller
    {
        private readonly ewiv2coreContext _context;

        public TesttablasController(ewiv2coreContext context)
        {
            _context = context;
        }

        // GET: Testtablas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Testtablas.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Edit(List<PgreDB.Models.Testtabla> Model)
        {
           if (Model.Count != 0)
            {
                foreach (Testtabla item in Model)
                {
                    _context.Update(item);
                }

                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}

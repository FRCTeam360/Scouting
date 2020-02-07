using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Scouting_v2.Data;
using Scouting_v2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Scouting_v2.Controllers
{
    public class DemoController : Controller

    {
        private readonly StatsContext _context;
        public DemoController(StatsContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            List<AvgMax> categorylist = new List<AvgMax>();
               categorylist = (from Team in _context.AvgMax select Team).ToList();
            return View(categorylist);
        }
    }
}

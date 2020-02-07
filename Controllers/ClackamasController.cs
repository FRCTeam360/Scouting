using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Scouting_v2.Data;
using Scouting_v2.Models;

namespace Scouting_v2.Controllers
{
    public class ClackamasController : Controller
    {
        private readonly StatsContext _context;

        public ClackamasController(StatsContext context)
        {
            _context = context;
        }

        // GET: Clackamas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clackamas.ToListAsync());
        }

        // GET: Clackamas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clackamas = await _context.Clackamas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (clackamas == null)
            {
                return NotFound();
            }

            return View(clackamas);
        }

        // GET: Clackamas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clackamas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Team,Baseline,AutoBalls_LVL_1_A,AutoBalls_LVL_1_M,AutoBalls_LVL_2_A,AutoBalls_LVL_2_M,AutoBalls_LVL_3_A,AutoBalls_LVL_3_M,TeleopBalls_LVL_1_A,TeleopBalls_LVL_1_M,TeleopBalls_LVL_2_A,TeleopBalls_LVL_2_M,TeleopBalls_LVL_3_A,TeleopBalls_LVL_3_M,Spinner_Number_A,Spinner_Colour_A,Climbed_A,Climb_HI_S,Climb_MI_S,Climb_LO_S,Balanced_A")] Clackamas clackamas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clackamas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clackamas);
        }

        // GET: Clackamas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clackamas = await _context.Clackamas.FindAsync(id);
            if (clackamas == null)
            {
                return NotFound();
            }
            return View(clackamas);
        }

        // POST: Clackamas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Team,Baseline,AutoBalls_LVL_1_A,AutoBalls_LVL_1_M,AutoBalls_LVL_2_A,AutoBalls_LVL_2_M,AutoBalls_LVL_3_A,AutoBalls_LVL_3_M,TeleopBalls_LVL_1_A,TeleopBalls_LVL_1_M,TeleopBalls_LVL_2_A,TeleopBalls_LVL_2_M,TeleopBalls_LVL_3_A,TeleopBalls_LVL_3_M,Spinner_Number_A,Spinner_Colour_A,Climbed_A,Climb_HI_S,Climb_MI_S,Climb_LO_S,Balanced_A")] Clackamas clackamas)
        {
            if (id != clackamas.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clackamas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClackamasExists(clackamas.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(clackamas);
        }

        // GET: Clackamas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clackamas = await _context.Clackamas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (clackamas == null)
            {
                return NotFound();
            }

            return View(clackamas);
        }

        // POST: Clackamas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clackamas = await _context.Clackamas.FindAsync(id);
            _context.Clackamas.Remove(clackamas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClackamasExists(int id)
        {
            return _context.Clackamas.Any(e => e.ID == id);
        }
    }
}

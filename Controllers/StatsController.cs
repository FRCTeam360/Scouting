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
    public class StatsController : Controller
    {
        private readonly StatsContext _context;

        public StatsController(StatsContext context)
        {
            _context = context;
        }

        // GET: Stats
        public async Task<IActionResult> Index(string searchString)
        {
            var Stats = from s in _context.Stats
                         select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                Stats = Stats.Where(s => s.CompetitionId.Contains(searchString));
            }


            return View(await Stats.ToListAsync());
        }

        // GET: Stats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stats = await _context.Stats
                .FirstOrDefaultAsync(m => m.ID == id);
            if (stats == null)
            {
                return NotFound();
            }

            return View(stats);
        }

        // GET: Stats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Stats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CompetitionId,Match,Team,Baseline,AutoBalls_LVL_1,AutoBalls_LVL_2,AutoBalls_LVL_3,TeleopBalls_LVL_1,TeleopBalls_LVL_2,TeleopBalls_LVL_3,Spinner_Number,Spinner_Colour,Climbed,Climb_HI,Climb_MI,Climb_LO,Balanced")] Stats stats)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stats);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stats);
        }

        // GET: Stats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stats = await _context.Stats.FindAsync(id);
            if (stats == null)
            {
                return NotFound();
            }
            return View(stats);
        }

        // POST: Stats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CompetitionId,Match,Team,Baseline,AutoBalls_LVL_1,AutoBalls_LVL_2,AutoBalls_LVL_3,TeleopBalls_LVL_1,TeleopBalls_LVL_2,TeleopBalls_LVL_3,Spinner_Number,Spinner_Colour,Climbed,Climb_HI,Climb_MI,Climb_LO,Balanced")] Stats stats)
        {
            if (id != stats.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stats);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StatsExists(stats.ID))
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
            return View(stats);
        }

        // GET: Stats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stats = await _context.Stats
                .FirstOrDefaultAsync(m => m.ID == id);
            if (stats == null)
            {
                return NotFound();
            }

            return View(stats);
        }

        // POST: Stats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stats = await _context.Stats.FindAsync(id);
            _context.Stats.Remove(stats);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StatsExists(int id)
        {
            return _context.Stats.Any(e => e.ID == id);
        }
    }
}

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
    public class AvgMaxesController : Controller
    {
        private readonly StatsContext _context;

        public AvgMaxesController(StatsContext context)
        {
            _context = context;
        }

        // GET: AvgMaxes
        public async Task<IActionResult> Index()
        {
            return View(await _context.AvgMax.ToListAsync());
        }

        // GET: AvgMaxes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avgMax = await _context.AvgMax
                .FirstOrDefaultAsync(m => m.ID == id);
            if (avgMax == null)
            {
                return NotFound();
            }

            return View(avgMax);
        }

        // GET: AvgMaxes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AvgMaxes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Team,Baseline,AutoBalls_LVL_1_A,AutoBalls_LVL_1_M,AutoBalls_LVL_2_A,AutoBalls_LVL_2_M,AutoBalls_LVL_3_A,AutoBalls_LVL_3_M,TeleopBalls_LVL_1_A,TeleopBalls_LVL_1_M,TeleopBalls_LVL_2_A,TeleopBalls_LVL_2_M,TeleopBalls_LVL_3_A,TeleopBalls_LVL_3_M,Spinner_Number_A,Spinner_Colour_A,Climbed_A,Climb_HI_S,Climb_MI_S,Climb_LO_S,Balanced_A")] AvgMax avgMax)
        {
            if (ModelState.IsValid)
            {
                _context.Add(avgMax);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(avgMax);
        }

        // GET: AvgMaxes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avgMax = await _context.AvgMax.FindAsync(id);
            if (avgMax == null)
            {
                return NotFound();
            }
            return View(avgMax);
        }

        // POST: AvgMaxes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Team,Baseline,AutoBalls_LVL_1_A,AutoBalls_LVL_1_M,AutoBalls_LVL_2_A,AutoBalls_LVL_2_M,AutoBalls_LVL_3_A,AutoBalls_LVL_3_M,TeleopBalls_LVL_1_A,TeleopBalls_LVL_1_M,TeleopBalls_LVL_2_A,TeleopBalls_LVL_2_M,TeleopBalls_LVL_3_A,TeleopBalls_LVL_3_M,Spinner_Number_A,Spinner_Colour_A,Climbed_A,Climb_HI_S,Climb_MI_S,Climb_LO_S,Balanced_A")] AvgMax avgMax)
        {
            if (id != avgMax.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(avgMax);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AvgMaxExists(avgMax.ID))
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
            return View(avgMax);
        }

        // GET: AvgMaxes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avgMax = await _context.AvgMax
                .FirstOrDefaultAsync(m => m.ID == id);
            if (avgMax == null)
            {
                return NotFound();
            }

            return View(avgMax);
        }

        // POST: AvgMaxes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var avgMax = await _context.AvgMax.FindAsync(id);
            _context.AvgMax.Remove(avgMax);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AvgMaxExists(int id)
        {
            return _context.AvgMax.Any(e => e.ID == id);
        }
    }
}

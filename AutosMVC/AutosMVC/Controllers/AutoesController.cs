using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AutosMVC.Data;
using AutosMVC.Models;

namespace AutosMVC.Controllers
{
    public class AutoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AutoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Autoes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Autos.Include(a => a.Bank);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Autoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auto = await _context.Autos
                .Include(a => a.Bank)
                .FirstOrDefaultAsync(m => m.VIN == id);
            if (auto == null)
            {
                return NotFound();
            }

            return View(auto);
        }

        // GET: Autoes/Create
        public IActionResult Create()
        {
            ViewData["RoutingNum"] = new SelectList(_context.Banks, "RoutingNum", "RoutingNum");
            return View();
        }

        // POST: Autoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VIN,Make,Model,Year,Cost,RoutingNum")] Auto auto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(auto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoutingNum"] = new SelectList(_context.Banks, "RoutingNum", "RoutingNum", auto.RoutingNum);
            return View(auto);
        }

        // GET: Autoes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auto = await _context.Autos.FindAsync(id);
            if (auto == null)
            {
                return NotFound();
            }
            ViewData["RoutingNum"] = new SelectList(_context.Banks, "RoutingNum", "RoutingNum", auto.RoutingNum);
            return View(auto);
        }

        // POST: Autoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("VIN,Make,Model,Year,Cost,RoutingNum")] Auto auto)
        {
            if (id != auto.VIN)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(auto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutoExists(auto.VIN))
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
            ViewData["RoutingNum"] = new SelectList(_context.Banks, "RoutingNum", "RoutingNum", auto.RoutingNum);
            return View(auto);
        }

        // GET: Autoes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auto = await _context.Autos
                .Include(a => a.Bank)
                .FirstOrDefaultAsync(m => m.VIN == id);
            if (auto == null)
            {
                return NotFound();
            }

            return View(auto);
        }

        // POST: Autoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var auto = await _context.Autos.FindAsync(id);
            if (auto != null)
            {
                _context.Autos.Remove(auto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutoExists(string id)
        {
            return _context.Autos.Any(e => e.VIN == id);
        }
    }
}

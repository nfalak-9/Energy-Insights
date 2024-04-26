using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Energy_Insights.Data;
using Energy_Insights.Models;

namespace Energy_Insights.Controllers
{
    public class EnergyGenerationModelsController : Controller
    {
        private readonly Energy_InsightsContext _context;

        public EnergyGenerationModelsController(Energy_InsightsContext context)
        {
            _context = context;
        }

        // GET: EnergyGenerationModels
        public async Task<IActionResult> Index()
        {
            var energy_InsightsContext = _context.EnergyGenerationModel.Include(e => e.Country).Include(e => e.EnergyType);
            return View(await energy_InsightsContext.ToListAsync());
        }

        // GET: EnergyGenerationModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var energyGenerationModel = await _context.EnergyGenerationModel
                .Include(e => e.Country)
                .Include(e => e.EnergyType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (energyGenerationModel == null)
            {
                return NotFound();
            }

            return View(energyGenerationModel);
        }

        // GET: EnergyGenerationModels/Create
        public IActionResult Create()
        {
            ViewData["CountryId"] = new SelectList(_context.Set<CountryModel>(), "Id", "Id");
            ViewData["EnergyTypeId"] = new SelectList(_context.Set<EnergyTypeModel>(), "Id", "Id");
            return View();
        }

        // POST: EnergyGenerationModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CountryId,EnergyTypeId,Amount")] EnergyGenerationModel energyGenerationModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(energyGenerationModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryId"] = new SelectList(_context.Set<CountryModel>(), "Id", "Id", energyGenerationModel.CountryId);
            ViewData["EnergyTypeId"] = new SelectList(_context.Set<EnergyTypeModel>(), "Id", "Id", energyGenerationModel.EnergyTypeId);
            return View(energyGenerationModel);
        }

        // GET: EnergyGenerationModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var energyGenerationModel = await _context.EnergyGenerationModel.FindAsync(id);
            if (energyGenerationModel == null)
            {
                return NotFound();
            }
            ViewData["CountryId"] = new SelectList(_context.Set<CountryModel>(), "Id", "Id", energyGenerationModel.CountryId);
            ViewData["EnergyTypeId"] = new SelectList(_context.Set<EnergyTypeModel>(), "Id", "Id", energyGenerationModel.EnergyTypeId);
            return View(energyGenerationModel);
        }

        // POST: EnergyGenerationModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CountryId,EnergyTypeId,Amount")] EnergyGenerationModel energyGenerationModel)
        {
            if (id != energyGenerationModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(energyGenerationModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnergyGenerationModelExists(energyGenerationModel.Id))
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
            ViewData["CountryId"] = new SelectList(_context.Set<CountryModel>(), "Id", "Id", energyGenerationModel.CountryId);
            ViewData["EnergyTypeId"] = new SelectList(_context.Set<EnergyTypeModel>(), "Id", "Id", energyGenerationModel.EnergyTypeId);
            return View(energyGenerationModel);
        }

        // GET: EnergyGenerationModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var energyGenerationModel = await _context.EnergyGenerationModel
                .Include(e => e.Country)
                .Include(e => e.EnergyType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (energyGenerationModel == null)
            {
                return NotFound();
            }

            return View(energyGenerationModel);
        }

        // POST: EnergyGenerationModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var energyGenerationModel = await _context.EnergyGenerationModel.FindAsync(id);
            if (energyGenerationModel != null)
            {
                _context.EnergyGenerationModel.Remove(energyGenerationModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnergyGenerationModelExists(int id)
        {
            return _context.EnergyGenerationModel.Any(e => e.Id == id);
        }
    }
}

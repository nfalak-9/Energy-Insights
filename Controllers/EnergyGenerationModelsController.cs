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
            ViewData["CountryList"] = new SelectList(_context.Set<CountryModel>(), "Id", "Name");
            var energyTypes = _context.Set<EnergyTypeModel>().Select(et => new { et.Id, CategoryAndName = $"{et.Category} - {et.Name}" });

            // Pass the concatenated category and name to the view
            ViewData["EnergyTypeList"] = new SelectList(energyTypes, "Id", "CategoryAndName");
          
            return View();
           
        }

        // POST: EnergyGenerationModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CountryId,EnergyTypeId,Amount")] EnergyGenerationModel energyGenerationModel)
        {

            var country = await _context.Set<CountryModel>().FindAsync(energyGenerationModel.CountryId);
            var energyType = await _context.Set<EnergyTypeModel>().FindAsync(energyGenerationModel.EnergyTypeId);

            // Assign the retrieved models to the energyGenerationModel properties
            if(country == null || energyType == null) { return NotFound(); }
            energyGenerationModel.Country = country;
            energyGenerationModel.EnergyType = energyType;
            if(true)
            {

                _context.Add(energyGenerationModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["CountryId"] = new SelectList(_context.Set<CountryModel>(), "Id", "Id", energyGenerationModel.CountryId);
            ViewData["EnergyTypeId"] = new SelectList(_context.Set<EnergyTypeModel>(), "Id", "Id", energyGenerationModel.EnergyTypeId);
           
            ViewData["CountryList"] = new SelectList(_context.Set<CountryModel>(), "Id", "Name", energyGenerationModel.CountryId );
            ViewData["EnergyTypeList"] = new SelectList(_context.Set<EnergyTypeModel>().Select(et => new { Id = et.Id, Name = $"{et.Category} - {et.Name}" }), "Id", "Name", energyGenerationModel.EnergyTypeId);

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
            ViewData["CountryList"] = new SelectList(_context.Set<CountryModel>(), "Id", "Name", energyGenerationModel.CountryId);
            ViewData["EnergyTypeList"] = new SelectList(_context.Set<EnergyTypeModel>().Select(et => new { Id = et.Id, Name = $"{et.Category} - {et.Name}" }), "Id", "Name", energyGenerationModel.EnergyTypeId);
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

            if (true)
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
            ViewData["CountryList"] = new SelectList(_context.Set<CountryModel>(), "Id", "Name", energyGenerationModel.CountryId);
            ViewData["EnergyTypeList"] = new SelectList(_context.Set<EnergyTypeModel>().Select(et => new { Id = et.Id, Name = $"{et.Category} - {et.Name}" }), "Id", "Name", energyGenerationModel.EnergyTypeId);
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

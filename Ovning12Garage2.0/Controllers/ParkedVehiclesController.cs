using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ovning12Garage2._0.Data;
using Ovning12Garage2._0.Models;

namespace Ovning12Garage2._0.Controllers
{
    public class ParkedVehiclesController : Controller
    {
        private readonly Ovning12Garage2_0Context _context;

        public ParkedVehiclesController(Ovning12Garage2_0Context context)
        {
            _context = context;
        }

        // GET: ParkedVehicles
        public async Task<IActionResult> Index()
        {
              return _context.ParkedVehicle != null ? 
                          View(await _context.ParkedVehicle.ToListAsync()) :
                          Problem("Entity set 'Ovning12Garage2_0Context.ParkedVehicle'  is null.");
        }

        // GET: ParkedVehicles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ParkedVehicle == null)
            {
                return NotFound();
            }

            var parkedVehicle = await _context.ParkedVehicle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parkedVehicle == null)
            {
                return NotFound();
            }

            return View(parkedVehicle);
        }


        // GET: ParkedVehicles/Create
		public IActionResult Create()
		{
			return View();
		}

        public IActionResult SearchVehicle()
        {
            return View();
        }

        public async Task<IActionResult> SearchByReg(string LicenseNumber)
        {
            if (LicenseNumber == null || _context.ParkedVehicle == null)
            {
                return NotFound();
            }
            var parkedVehicle = await _context.ParkedVehicle
                .FirstOrDefaultAsync(m => m.LicenseNumber.Equals(LicenseNumber));
            return View("Delete", parkedVehicle);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VehicleType,Color,LicenseNumber,NumberOfWheels,TimeOfArrival,Brand,Model")] ParkedVehicle parkedVehicle)
        {
            if (ModelState.IsValid)
            {
				if (_context.ParkedVehicle?.FirstOrDefault(v => v.LicenseNumber == parkedVehicle.LicenseNumber.ToUpper()) != null)
				{
					ViewBag.LicenseNumberExists = true;
					return View(parkedVehicle);
				}
				else if (parkedVehicle.LicenseNumber.Length < 6)
				{
					ModelState.AddModelError("LicensNumberTooShortError", "The specified license number must be at least 6 characters long.");
					return View(parkedVehicle);
				}
				else
				{
					parkedVehicle.TimeOfArrival = DateTime.Now;
					parkedVehicle.LicenseNumber = parkedVehicle.LicenseNumber.ToUpper();
					_context.Add(parkedVehicle);
					await _context.SaveChangesAsync();
					return RedirectToAction(nameof(Index));
				}
            }
            return View(parkedVehicle);
        }



		// POST: ParkedVehicles/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		/*[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VehicleType,Color,LicenseNumber,NumberOfWheels,TimeOfArrival,Brand,Model")] ParkedVehicle parkedVehicle)
        {
            if (ModelState.IsValid)
            {
				if (_context.ParkedVehicle?.FirstOrDefault(v => v.LicenseNumber == parkedVehicle.LicenseNumber.ToUpper()) != null)
				{
					ViewBag.LicenseNumberExists = true;
					return View(parkedVehicle);
				}
				else if (parkedVehicle.LicenseNumber.Length < 6)
				{
					ViewBag.LicenseNumberTooShort = true;
					return View(parkedVehicle);
				}
				else
				{
					parkedVehicle.LicenseNumber = parkedVehicle.LicenseNumber.ToUpper();
					parkedVehicle.TimeOfArrival = DateTime.Now;
					_context.Add(parkedVehicle);
					await _context.SaveChangesAsync();
					TempData["Message"] = "The vehicle has been parked.";
					return RedirectToAction(nameof(Index));
				}
            }
            return View(parkedVehicle);
        }*/

		// GET: ParkedVehicles/Edit/5
		public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ParkedVehicle == null)
            {
                return NotFound();
            }

            var parkedVehicle = await _context.ParkedVehicle.FindAsync(id);
            if (parkedVehicle == null)
            {
                return NotFound();
            }
            return View(parkedVehicle);
        }

        // POST: ParkedVehicles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,VehicleType,Color,LicenseNumber,NumberOfWheels,TimeOfArrival,Brand,Model")] ParkedVehicle parkedVehicle)
        {
            if (id != parkedVehicle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                try
                {
                    _context.Update(parkedVehicle);
                    await _context.SaveChangesAsync();
					TempData["Message"] = "The vehicle specifications have been updated.";
				}
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParkedVehicleExists(parkedVehicle.Id))
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
            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/Delete/5
        public async Task<IActionResult> Unpark(int? id)
        {
            if (id == null || _context.ParkedVehicle == null)
            {
                return NotFound();
            }

            var parkedVehicle = await _context.ParkedVehicle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parkedVehicle == null)
            {
                return NotFound();
            }

            return View(parkedVehicle);
        }

        // POST: ParkedVehicles/Unpark/5
        [HttpPost, ActionName("Unpark")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ParkedVehicle == null)
            {
                return Problem("Entity set 'Ovning12Garage2_0Context.ParkedVehicle'  is null.");
            }
            var parkedVehicle = await _context.ParkedVehicle.FindAsync(id);
            if (parkedVehicle != null)
            {
                _context.ParkedVehicle.Remove(parkedVehicle);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParkedVehicleExists(int id)
        {
          return (_context.ParkedVehicle?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

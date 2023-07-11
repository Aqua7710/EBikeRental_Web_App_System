using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EBikeRental_Web_App_System.Areas.Identity.Data;
using EBikeRental_Web_App_System.Models;
using Microsoft.AspNetCore.Authorization;

namespace EBikeRental_Web_App_System.Controllers
{
    [Authorize]
    public class RentalsController : Controller
    {
        private readonly IdentityContext _context;

        public RentalsController(IdentityContext context)
        {
            _context = context;
        }

        // GET: Rentals
        public async Task<IActionResult> Index(string searchString)
        {   
            if (_context.Rental == null)
            {
                return Problem("Entity set 'IdentityContext.Rentals' is null.");
            }

            IQueryable<Rental>rentals = _context.Rental; // Use IQueryable instead of var for explicit typing

            if (!String.IsNullOrEmpty(searchString)) // search for staffs or customers last name that contain search value
            {
                rentals = rentals.Where(r => r.Customer.LastName.Contains(searchString) || r.Staff.LastName.Contains(searchString));
            }

            // Include bike, customer, and staff navigation property
            rentals = rentals.Include(r => r.Bike);
            rentals = rentals.Include(r => r.Customer);
            rentals = rentals.Include(r => r.Staff);

            var rentalList = await rentals.ToListAsync();
            return View(rentalList);
        }

        // GET: Rentals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Rental == null)
            {
                return NotFound();
            }

            var rental = await _context.Rental
                .Include(r => r.Bike)
                .Include(r => r.Customer)
                .Include(r => r.Staff)
                .FirstOrDefaultAsync(m => m.RentalId == id);
            if (rental == null)
            {
                return NotFound();
            }

            return View(rental);
        }

        // GET: Rentals/Create
        public IActionResult Create()
        {
            ViewData["BikeId"] = new SelectList(_context.Bike, "BikeId", "BikeModel"); // display bike model instead of bike id
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "FullName"); // display customer full name instead of customer id
			ViewData["StaffId"] = new SelectList(_context.Set<Staff>(), "StaffId", "FullName"); // display staff full name instead of staff id
            return View();
        }

        // POST: Rentals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RentalId,CustomerId,BikeId,BorrowDuration,StaffId,CollectionTime,ReturnTime")] Rental rental)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(rental);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BikeId"] = new SelectList(_context.Bike, "BikeId", "BikeId", rental.BikeId);
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId", rental.CustomerId);
            ViewData["StaffId"] = new SelectList(_context.Set<Staff>(), "StaffId", "StaffId", rental.StaffId);
            return View(rental);
        }

        // GET: Rentals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Rental == null)
            {
                return NotFound();
            }

            var rental = await _context.Rental.FindAsync(id);
            if (rental == null)
            {
                return NotFound();
            }
            ViewData["BikeId"] = new SelectList(_context.Bike, "BikeId", "BikeModel", rental.BikeId);
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "FullName", rental.CustomerId);
            ViewData["StaffId"] = new SelectList(_context.Set<Staff>(), "StaffId", "FullName", rental.StaffId);
            return View(rental);
        }

        // POST: Rentals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RentalId,CustomerId,BikeId,BorrowDuration,StaffId,CollectionTime,ReturnTime")] Rental rental)
        {
            if (id != rental.RentalId)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(rental);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentalExists(rental.RentalId))
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
            ViewData["BikeId"] = new SelectList(_context.Bike, "BikeId", "BikeId", rental.BikeId);
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId", rental.CustomerId);
            ViewData["StaffId"] = new SelectList(_context.Set<Staff>(), "StaffId", "StaffId", rental.StaffId);
            return View(rental);
        }

        // GET: Rentals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Rental == null)
            {
                return NotFound();
            }

            var rental = await _context.Rental
                .Include(r => r.Bike)
                .Include(r => r.Customer)
                .Include(r => r.Staff)
                .FirstOrDefaultAsync(m => m.RentalId == id);
            if (rental == null)
            {
                return NotFound();
            }

            return View(rental);
        }

        // POST: Rentals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Rental == null)
            {
                return Problem("Entity set 'IdentityContext.Rental'  is null.");
            }
            var rental = await _context.Rental.FindAsync(id);
            if (rental != null)
            {
                _context.Rental.Remove(rental);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentalExists(int id)
        {
          return (_context.Rental?.Any(e => e.RentalId == id)).GetValueOrDefault();
        }
    }
}

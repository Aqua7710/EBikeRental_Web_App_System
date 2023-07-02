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
    public class PaymentsTypesController : Controller
    {
        private readonly IdentityContext _context;

        public PaymentsTypesController(IdentityContext context)
        {
            _context = context;
        }

        // GET: PaymentsTypes
        public async Task<IActionResult> Index()
        {
              return _context.PaymentsType != null ? 
                          View(await _context.PaymentsType.ToListAsync()) :
                          Problem("Entity set 'IdentityContext.PaymentsType'  is null.");
        }

        // GET: PaymentsTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PaymentsType == null)
            {
                return NotFound();
            }

            var paymentsType = await _context.PaymentsType
                .FirstOrDefaultAsync(m => m.PaymentsTypeId == id);
            if (paymentsType == null)
            {
                return NotFound();
            }

            return View(paymentsType);
        }

        // GET: PaymentsTypes/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: PaymentsTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PaymentsTypeId,PaymentType")] PaymentsType paymentsType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paymentsType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(paymentsType);
        }

        // GET: PaymentsTypes/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PaymentsType == null)
            {
                return NotFound();
            }

            var paymentsType = await _context.PaymentsType.FindAsync(id);
            if (paymentsType == null)
            {
                return NotFound();
            }
            return View(paymentsType);
        }

        // POST: PaymentsTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PaymentsTypeId,PaymentType")] PaymentsType paymentsType)
        {
            if (id != paymentsType.PaymentsTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paymentsType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaymentsTypeExists(paymentsType.PaymentsTypeId))
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
            return View(paymentsType);
        }

        // GET: PaymentsTypes/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PaymentsType == null)
            {
                return NotFound();
            }

            var paymentsType = await _context.PaymentsType
                .FirstOrDefaultAsync(m => m.PaymentsTypeId == id);
            if (paymentsType == null)
            {
                return NotFound();
            }

            return View(paymentsType);
        }

        // POST: PaymentsTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PaymentsType == null)
            {
                return Problem("Entity set 'IdentityContext.PaymentsType'  is null.");
            }
            var paymentsType = await _context.PaymentsType.FindAsync(id);
            if (paymentsType != null)
            {
                _context.PaymentsType.Remove(paymentsType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentsTypeExists(int id)
        {
          return (_context.PaymentsType?.Any(e => e.PaymentsTypeId == id)).GetValueOrDefault();
        }
    }
}

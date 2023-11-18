using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ABD_CRM.Models;

namespace ABD_CRM.Controllers
{
    public class TblCompaniesController : Controller
    {
        private readonly ABDContext _context;

        public TblCompaniesController(ABDContext context)
        {
            _context = context;
        }

        // GET: TblCompanies
        public async Task<IActionResult> Index()
        {
              return View(await _context.TblCompanies.ToListAsync());
        }

        // GET: TblCompanies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TblCompanies == null)
            {
                return NotFound();
            }

            var tblCompany = await _context.TblCompanies
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (tblCompany == null)
            {
                return NotFound();
            }

            return View(tblCompany);
        }

        // GET: TblCompanies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TblCompanies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CreatedById,CreateDate,LastUpdated,CompanyId,CompanyName,CompanyAddress,PhoneNum,DpName")] TblCompany tblCompany)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblCompany);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblCompany);
        }

        // GET: TblCompanies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TblCompanies == null)
            {
                return NotFound();
            }

            var tblCompany = await _context.TblCompanies.FindAsync(id);
            if (tblCompany == null)
            {
                return NotFound();
            }
            return View(tblCompany);
        }

        // POST: TblCompanies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CreatedById,CreateDate,LastUpdated,CompanyId,CompanyName,CompanyAddress,PhoneNum,DpName")] TblCompany tblCompany)
        {
            if (id != tblCompany.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblCompany);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblCompanyExists(tblCompany.CompanyId))
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
            return View(tblCompany);
        }

        // GET: TblCompanies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TblCompanies == null)
            {
                return NotFound();
            }

            var tblCompany = await _context.TblCompanies
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (tblCompany == null)
            {
                return NotFound();
            }

            return View(tblCompany);
        }

        // POST: TblCompanies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TblCompanies == null)
            {
                return Problem("Entity set 'ABDContext.TblCompanies'  is null.");
            }
            var tblCompany = await _context.TblCompanies.FindAsync(id);
            if (tblCompany != null)
            {
                _context.TblCompanies.Remove(tblCompany);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblCompanyExists(int id)
        {
          return _context.TblCompanies.Any(e => e.CompanyId == id);
        }
    }
}

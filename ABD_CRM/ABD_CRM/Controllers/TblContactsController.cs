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
    public class TblContactsController : Controller
    {
        private readonly ABDContext _context;

        public TblContactsController(ABDContext context)
        {
            _context = context;
        }

        // GET: TblContacts
        public async Task<IActionResult> Index()
        {
            var aBDContext = _context.TblContacts.Include(t => t.Company);
            return View(await aBDContext.ToListAsync());
        }

        // GET: TblContacts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TblContacts == null)
            {
                return NotFound();
            }

            var tblContact = await _context.TblContacts
                .Include(t => t.Company)
                .FirstOrDefaultAsync(m => m.ContactId == id);
            if (tblContact == null)
            {
                return NotFound();
            }

            return View(tblContact);
        }

        // GET: TblContacts/Create
        public IActionResult Create()
        {
            ViewData["CompanyId"] = new SelectList(_context.TblCompanies, "CompanyId", "CompanyId");
            return View();
        }

        // POST: TblContacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CreatedBy,CreateDate,LastUpdated,ContactId,ContactName,Position,CompanyId")] TblContact tblContact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblContact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyId"] = new SelectList(_context.TblCompanies, "CompanyId", "CompanyId", tblContact.CompanyId);
            return View(tblContact);
        }

        // GET: TblContacts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TblContacts == null)
            {
                return NotFound();
            }

            var tblContact = await _context.TblContacts.FindAsync(id);
            if (tblContact == null)
            {
                return NotFound();
            }
            ViewData["CompanyId"] = new SelectList(_context.TblCompanies, "CompanyId", "CompanyId", tblContact.CompanyId);
            return View(tblContact);
        }

        // POST: TblContacts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CreatedBy,CreateDate,LastUpdated,ContactId,ContactName,Position,CompanyId")] TblContact tblContact)
        {
            if (id != tblContact.ContactId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblContact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblContactExists(tblContact.ContactId))
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
            ViewData["CompanyId"] = new SelectList(_context.TblCompanies, "CompanyId", "CompanyId", tblContact.CompanyId);
            return View(tblContact);
        }

        // GET: TblContacts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TblContacts == null)
            {
                return NotFound();
            }

            var tblContact = await _context.TblContacts
                .Include(t => t.Company)
                .FirstOrDefaultAsync(m => m.ContactId == id);
            if (tblContact == null)
            {
                return NotFound();
            }

            return View(tblContact);
        }

        // POST: TblContacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TblContacts == null)
            {
                return Problem("Entity set 'ABDContext.TblContacts'  is null.");
            }
            var tblContact = await _context.TblContacts.FindAsync(id);
            if (tblContact != null)
            {
                _context.TblContacts.Remove(tblContact);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblContactExists(int id)
        {
          return _context.TblContacts.Any(e => e.ContactId == id);
        }
    }
}

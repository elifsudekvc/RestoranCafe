using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using restoran.Data;
using restoran.Models;

namespace restoran.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SiparisListController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SiparisListController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/SiparisList
        public async Task<IActionResult> Index()
        {
            return View(await _context.SiparisListesi.ToListAsync());
        }

        // GET: Admin/SiparisList/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var siparisList = await _context.SiparisListesi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (siparisList == null)
            {
                return NotFound();
            }

            return View(siparisList);
        }

        // GET: Admin/SiparisList/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/SiparisList/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Isim,TelNo,KisiSayisi,MasaNo,Not,Siparisler,SiparisDurum")] SiparisList siparisList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(siparisList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(siparisList);
        }

        // GET: Admin/SiparisList/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var siparisList = await _context.SiparisListesi.FindAsync(id);
            if (siparisList == null)
            {
                return NotFound();
            }
            return View(siparisList);
        }

        // POST: Admin/SiparisList/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Isim,TelNo,KisiSayisi,MasaNo,Not,Siparisler,SiparisDurum")] SiparisList siparisList)
        {
            if (id != siparisList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(siparisList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SiparisListExists(siparisList.Id))
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
            return View(siparisList);
        }

        // GET: Admin/SiparisList/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var siparisList = await _context.SiparisListesi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (siparisList == null)
            {
                return NotFound();
            }

            return View(siparisList);
        }

        // POST: Admin/SiparisList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var siparisList = await _context.SiparisListesi.FindAsync(id);
            _context.SiparisListesi.Remove(siparisList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SiparisListExists(int id)
        {
            return _context.SiparisListesi.Any(e => e.Id == id);
        }
    }
}

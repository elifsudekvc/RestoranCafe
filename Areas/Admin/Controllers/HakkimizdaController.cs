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
    public class HakkimizdaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HakkimizdaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Hakkimizda
        public async Task<IActionResult> Index()
        {
            return View(await _context.HakkimizdaListesi.ToListAsync());
        }

        // GET: Admin/Hakkimizda/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hakkimizda = await _context.HakkimizdaListesi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hakkimizda == null)
            {
                return NotFound();
            }

            return View(hakkimizda);
        }

        // GET: Admin/Hakkimizda/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Hakkimizda/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Baslik")] Hakkimizda hakkimizda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hakkimizda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hakkimizda);
        }

        // GET: Admin/Hakkimizda/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hakkimizda = await _context.HakkimizdaListesi.FindAsync(id);
            if (hakkimizda == null)
            {
                return NotFound();
            }
            return View(hakkimizda);
        }

        // POST: Admin/Hakkimizda/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Baslik")] Hakkimizda hakkimizda)
        {
            if (id != hakkimizda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hakkimizda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HakkimizdaExists(hakkimizda.Id))
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
            return View(hakkimizda);
        }

        // GET: Admin/Hakkimizda/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hakkimizda = await _context.HakkimizdaListesi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hakkimizda == null)
            {
                return NotFound();
            }

            return View(hakkimizda);
        }

        // POST: Admin/Hakkimizda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hakkimizda = await _context.HakkimizdaListesi.FindAsync(id);
            _context.HakkimizdaListesi.Remove(hakkimizda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HakkimizdaExists(int id)
        {
            return _context.HakkimizdaListesi.Any(e => e.Id == id);
        }
    }
}

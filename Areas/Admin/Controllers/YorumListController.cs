using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using restoran.Data;
using restoran.Models;

namespace restoran.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class YorumListController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _he;
        public YorumListController(ApplicationDbContext context, IWebHostEnvironment he)
        {
            _context = context;
            _he = he;
        }

        // GET: Admin/YorumList
        public async Task<IActionResult> Index()
        {
            return View(await _context.YorumListesi.ToListAsync());
        }

        // GET: Admin/YorumList/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yorumList = await _context.YorumListesi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (yorumList == null)
            {
                return NotFound();
            }

            return View(yorumList);
        }

        // GET: Admin/YorumList/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/YorumList/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(YorumList yorumList)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count > 0)
                {

                    var DosyaAdı = Guid.NewGuid().ToString();
                    var Guncellemeler = Path.Combine(_he.WebRootPath, @"Site\MenuList");
                    var ext = Path.GetExtension(files[0].FileName);
                    if (yorumList.Resim != null)
                    {
                        var ResimPath = Path.Combine(_he.WebRootPath, yorumList.Resim.TrimStart('\\'));

                        if (System.IO.File.Exists(ResimPath))
                        {
                            System.IO.File.Delete(ResimPath);

                        }
                    }
                    using (var fileStreams = new FileStream(Path.Combine(Guncellemeler, DosyaAdı + ext), FileMode.Create))
                    {
                        files[0].CopyTo(fileStreams);

                    }
                    yorumList.Resim = @"\Site\MenuList\" + DosyaAdı + ext;
                }

                _context.Add(yorumList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(yorumList);
        }

        // GET: Admin/YorumList/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yorumList = await _context.YorumListesi.FindAsync(id);
            if (yorumList == null)
            {
                return NotFound();
            }
            return View(yorumList);
        }

        // POST: Admin/YorumList/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Baslik,Isim,TelNo,Resim,Onay,Mesaj,Tarih")] YorumList yorumList)
        {
            if (id != yorumList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(yorumList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!YorumListExists(yorumList.Id))
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
            return View(yorumList);
        }

        // GET: Admin/YorumList/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yorumList = await _context.YorumListesi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (yorumList == null)
            {
                return NotFound();
            }

            return View(yorumList);
        }

        // POST: Admin/YorumList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var yorumList = await _context.YorumListesi.FindAsync(id);
            _context.YorumListesi.Remove(yorumList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool YorumListExists(int id)
        {
            return _context.YorumListesi.Any(e => e.Id == id);
        }
    }
}

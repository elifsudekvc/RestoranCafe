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
    public class MenuListController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        private readonly IWebHostEnvironment _he;
        public MenuListController(ApplicationDbContext context, IWebHostEnvironment he)
        {
            _context = context;
            _he = he;
        }

        // GET: Admin/MenuList
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MenuListesi.Include(m => m.Kategori);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/MenuList/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuList = await _context.MenuListesi
                .Include(m => m.Kategori)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menuList == null)
            {
                return NotFound();
            }

            return View(menuList);
        }

        // GET: Admin/MenuList/Create
        public IActionResult Create()
        {
            ViewData["KategoriId"] = new SelectList(_context.Kategoriler, "Id", "Isim");
            return View();
        }

        // POST: Admin/MenuList/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( MenuList menuList)
        {
            if (ModelState.IsValid)
            {
                //resim ekleme kodları
                var files = HttpContext.Request.Form.Files;
                if(files.Count>0){

                    var DosyaAdı = Guid.NewGuid().ToString();
                    var Guncellemeler = Path.Combine(_he.WebRootPath, @"Site\MenuList");
                    var ext = Path.GetExtension(files[0].FileName);
                    if (menuList.Resim != null)
                    {
                        var ResimPath = Path.Combine(_he.WebRootPath, menuList.Resim.TrimStart('\\'));

                        if (System.IO.File.Exists(ResimPath))
                        {
                            System.IO.File.Delete(ResimPath);

                        }
                    }
                    using (var fileStreams=new FileStream(Path.Combine(Guncellemeler, DosyaAdı + ext), FileMode.Create))
                    {
                        files[0].CopyTo(fileStreams);

                    }
                    menuList.Resim = @"\Site\MenuList\" + DosyaAdı + ext;
                }
                _context.Add(menuList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            return View(menuList);
        }

        // GET: Admin/MenuList/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuList = await _context.MenuListesi.FindAsync(id);
            if (menuList == null)
            {
                return NotFound();
            }
            ViewData["KategoriId"] = new SelectList(_context.Kategoriler, "Id", "Isim", menuList.KategoriId);
            return View(menuList);
        }

        // POST: Admin/MenuList/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit( MenuList menuList)
        {
           

            if (ModelState.IsValid)
            {
                //resim ekleme kodları
                var files = HttpContext.Request.Form.Files;
                if(files.Count>0){

                    var DosyaAdı = Guid.NewGuid().ToString();
                    var Guncellemeler = Path.Combine(_he.WebRootPath, @"Site\MenuList");
                    var ext = Path.GetExtension(files[0].FileName);
                    if (menuList.Resim != null)
                    {
                        var ResimPath = Path.Combine(_he.WebRootPath, menuList.Resim.TrimStart('\\'));

                        if (System.IO.File.Exists(ResimPath))
                        {
                            System.IO.File.Delete(ResimPath);

                        }
                    }
                    using (var fileStreams=new FileStream(Path.Combine(Guncellemeler, DosyaAdı + ext), FileMode.Create))
                    {
                        files[0].CopyTo(fileStreams);

                    }
                    menuList.Resim = @"\Site\MenuList\" + DosyaAdı + ext;
                }
               
                    _context.Update(menuList);
                    await _context.SaveChangesAsync();
               
                
                return RedirectToAction(nameof(Index));
            }
            
            return View(menuList);
        }

        // GET: Admin/MenuList/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuList = await _context.MenuListesi
                .Include(m => m.Kategori)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menuList == null)
            {
                return NotFound();
            }

            return View(menuList);
        }

        // POST: Admin/MenuList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var menuList = await _context.MenuListesi.FindAsync(id);
            var ResimPath = Path.Combine(_he.WebRootPath, menuList.Resim.TrimStart('\\'));

            if (System.IO.File.Exists(ResimPath))
            {
                System.IO.File.Delete(ResimPath);

            }
            _context.MenuListesi.Remove(menuList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MenuListExists(int id)
        {
            return _context.MenuListesi.Any(e => e.Id == id);
        }
    }
}

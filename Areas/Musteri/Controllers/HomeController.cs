using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NToastNotify;
using restoran.Data;
using restoran.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace restoran.Areas.Musteri.Controllers
{
    [Area("Musteri")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly IToastNotification _toast;
        private readonly IWebHostEnvironment _he;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db, IToastNotification toast, IWebHostEnvironment he)
        {
            _logger = logger;
            _db = db;
            _toast = toast;
            _he = he;
        }

        public IActionResult Index()
        {

            return View();
        }

        
        public IActionResult Menu(int? id)
        {
            List<MenuList> menu = new();
            if (id!=null)
            {
                 menu = _db.MenuListesi.Where(i => i.KategoriId == id).ToList();
               
            }
            else
            {
               menu = _db.MenuListesi.ToList();
                
            }
            return View(menu);
        }

        public IActionResult SiparisList()
        {
            var menu = _db.MenuListesi.ToList();
            ViewBag.menu = menu;
            return View();
        }

        // POST: Admin/SiparisList/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SiparisList([Bind("Id,Isim,TelNo,KisiSayisi,MasaNo,Not,Siparisler,SiparisDurum")] SiparisList siparisList)
        {
            if (ModelState.IsValid)
            {
                _db.Add(siparisList);
                await _db.SaveChangesAsync();
                _toast.AddInfoToastMessage("Siparişiniz alınmıştır. Herhangi bir sorunda garsonlarımızla iletişime geçiniz.");
                return RedirectToAction(nameof(Index));
            }


            return View(siparisList);
        }



        public IActionResult Galeri()
        {
            var galeri = _db.GaleriListesi.ToList();
            return View(galeri);
        }
        public IActionResult Hakkimizda()
        {
            var hakkimizda = _db.HakkimizdaListesi.ToList();
            return View(hakkimizda);
        }

        public IActionResult YorumList()
        {
            return View();
        }

        // POST: Admin/YorumList/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> YorumList(YorumList yorumList)
        {
            if (ModelState.IsValid)
            {
                yorumList.Tarih = DateTime.Now;
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

                _db.Add(yorumList);
                await _db.SaveChangesAsync();
                _toast.AddSuccessToastMessage("Teşekkür ederiz, yorumunuz iletildi. Yorumunuz onaylandığında yorumlar sayfasından görebilirsiniz.. ");
                return RedirectToAction(nameof(Index));
            }
            return View(yorumList);
        }

        public IActionResult Iletisim()
        {
            return View();
        }

        // POST: Admin/Iletisim/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Iletisim([Bind("Id,Isim,Email,TelNo,Mesaj")] Iletisim iletisim)
        {
            if (ModelState.IsValid)
            {   
                iletisim.Tarih = DateTime.Now;
                _db.Add(iletisim);
                await _db.SaveChangesAsync();
                _toast.AddSuccessToastMessage("Teşekkür ederiz, mesajınız iletildi.");
                return RedirectToAction(nameof(Index));
            }
            return View(iletisim);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

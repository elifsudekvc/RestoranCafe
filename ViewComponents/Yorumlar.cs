using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using restoran.Data;

namespace restoran.ViewComponents
{
    public class Yorumlar: ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public Yorumlar(ApplicationDbContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            var yorum = _db.YorumListesi.Where(i=>i.Onay).ToList();
            return View(yorum);
        }
    }
}

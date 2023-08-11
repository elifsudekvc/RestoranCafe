using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using restoran.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace restoran.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }

        public DbSet<Galeri> GaleriListesi { get; set; }
        public DbSet<Hakkimizda> HakkimizdaListesi { get; set; }
        public DbSet<Iletisim> IletisimListesi { get; set; }
        public DbSet<YorumList> YorumListesi { get; set; }
        public DbSet<MenuList> MenuListesi { get; set; }

        public DbSet<SiparisList> SiparisListesi { get; set; }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace restoran.Models
{
    public class MenuList
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Baslik { get; set; }
        [Required]
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public bool Ozel { get; set; }
        public double Fiyat { get; set; }
        public int KategoriId { get; set; }
        [ForeignKey("KategoriId")]
        public Kategori Kategori { get; set; }
    }
}

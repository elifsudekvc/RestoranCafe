using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace restoran.Models
{
    public class YorumList
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Baslik { get; set; }
        [Required]
        public string Isim { get; set; }
        [Required]
        public string TelNo { get; set; }
        public string Resim { get; set; }
        public bool Onay { get; set; }
        [Required]
        public string Mesaj { get; set; }
        public DateTime Tarih { get; set; }
    }
}

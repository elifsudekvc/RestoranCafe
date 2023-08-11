using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace restoran.Models
{
    public class Iletisim
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Isim { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string TelNo { get; set; }
        [Required]
        public string Mesaj { get; set; }
        public DateTime Tarih { get; set; }
    }
}

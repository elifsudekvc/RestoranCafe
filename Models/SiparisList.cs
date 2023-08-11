using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace restoran.Models
{
    public class SiparisList
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Isim { get; set; }
        [Required]
        public string TelNo { get; set; }
        [Required]
        public int KisiSayisi { get; set; }
        [Required]
        public string MasaNo { get; set; }

        public string Not { get; set; }

        [Required]
        public string Siparisler { get; set; }

        public string SiparisDurum { get; set; }

    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace restoran.Models
{
    public class Kullanici:IdentityUser
    {
        [Required]
        public string Isim { get; set; }
        [Required]
        public string Soyisim { get; set; }
        [NotMapped]
        public string Rol { get; set; }

    }
}

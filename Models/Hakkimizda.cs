using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace restoran.Models
{
    public class Hakkimizda
    {
        [Key]
        public int Id { get; set; }
        public string Baslik { get; set; }
    }
}

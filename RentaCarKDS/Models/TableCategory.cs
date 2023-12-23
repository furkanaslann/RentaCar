﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentaCarKDS.Models
{
    [NotMapped] // İlgili sınıfı database'de göstermiyor.
    public class TableCategory
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string? Description { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentaCarKDS.Models
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string StartDate { get; set; }
        public string FinishDate { get; set; }
        [MaxLength(12)]
        public string ChassisNo { get; set; }
        [MaxLength(10)]
        public string Plate { get; set; }

        public string Type { get; set; }
        public double DatePrice { get; set; }
        public Department Department { get; set; } // navigation property
        public string DepartmentCity { get; set; }

    }
}

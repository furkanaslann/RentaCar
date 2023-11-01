using System.ComponentModel.DataAnnotations;

namespace RentaCarKDS.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string StartDate { get; set; }
        public string FinishDate { get; set; }
        public string ChassisNo { get; set; }
        public string Plate { get; set; }

        public string Type { get; set; }
        public double Price { get; set; }

    }
}

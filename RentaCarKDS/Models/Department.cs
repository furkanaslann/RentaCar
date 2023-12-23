using System.ComponentModel.DataAnnotations;

namespace RentaCarKDS.Models
{
    public class Department 
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string? Region { get; set; }
        virtual public ICollection<Car> Cars { get; set; }
    }
}

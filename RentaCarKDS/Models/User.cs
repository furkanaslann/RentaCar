using System.ComponentModel.DataAnnotations;

namespace RentaCarKDS.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required] // Zorunlu
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        [Required] 
        public string Password { get; set; }
    }
}

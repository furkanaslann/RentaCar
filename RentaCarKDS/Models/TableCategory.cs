using System.ComponentModel.DataAnnotations;

namespace RentaCarKDS.Models
{
    public class TableCategory
    {
        [Key] 
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}

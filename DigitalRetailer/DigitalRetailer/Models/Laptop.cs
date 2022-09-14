using System.ComponentModel.DataAnnotations;

namespace DigitalRetailer.Models
{
    public class Laptop
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }

        public string Description { get; set; }
        public double Price { get; set; }

        public string ImageUrl { get; set; }
    }
}

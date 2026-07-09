using System.ComponentModel.DataAnnotations;

namespace EliteTech_Ecommerce.Models
{
    public class Cart
    {
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string ImageUrl { get; set; } = string.Empty;
    }
}
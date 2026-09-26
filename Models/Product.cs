using System.ComponentModel.DataAnnotations;

namespace Task03_Web_API.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;

        [Range(1, 1000000)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(200)]
        public string Category { get; set; } = string.Empty;
    }
}
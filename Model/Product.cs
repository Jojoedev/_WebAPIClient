using System.ComponentModel.DataAnnotations;

namespace _WebAPIClient.Model
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public int Quantity { get; set; }
        [Required]
        public string? Category { get; set; }

    }
}

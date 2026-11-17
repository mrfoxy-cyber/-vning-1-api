using System.ComponentModel.DataAnnotations;

namespace StorageApi.DTOs
{
    public class ProductDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Range(0, int.MaxValue)]
        public int Price { get; set; }

        [Range(0, int.MaxValue)]
        public int Count { get; set; }

        public string? Category { get; set; }
        public int InventoryValue => Price * Count;

    }
}

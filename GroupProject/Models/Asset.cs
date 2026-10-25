using System.ComponentModel.DataAnnotations;

namespace GroupProject.Models
{
    public class Asset
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Asset Name is required")]
        [StringLength(100, MinimumLength = 2)]
        public string AssetName { get; set; } = string.Empty;

        [Required]
        public string AssignedTo { get; set; } = string.Empty;

        [Range(1, 10000)]
        public int Quantity { get; set; }

        public string? Notes { get; set; } 
    }
}
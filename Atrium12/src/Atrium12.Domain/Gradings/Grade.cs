using System.ComponentModel.DataAnnotations;

namespace Atrium12.Domain.Gradings
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int GradingStandardId { get; set; }

        [Required, MaxLength(20)]
        public string Code { get; set; } = string.Empty; // 'MS62', 'AU50', 'XF45', 'F-VF'

        [Required, MaxLength(100)]
        public string DisplayName { get; set; } = string.Empty; // "Mint State 62", "Около новой 50"

        [MaxLength(500)]
        public string? Description { get; set; } // "Full luster, minor marks"

        public int? NumericValue { get; set; } // для сортировки: MS70 = 70, AU50 = 50

        public bool IsUncirculated { get; set; } = false;
        public bool IsProof { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        public virtual GradingStandard GradingStandard { get; set; } = null!;
        public virtual ICollection<ItemCondition> ItemConditions { get; set; } = new List<ItemCondition>();
    }
}

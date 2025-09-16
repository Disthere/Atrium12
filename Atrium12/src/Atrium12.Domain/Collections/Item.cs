using Atrium12.Domain.Gradings;
using Atrium12.Domain.MarketPriceSources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atrium12.Domain.Collections
{
    public class Item
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid CollectionId { get; set; }

        [Required]
        public Guid ItemType { get; set; }  // 'Coin', 'Banknote', 'Stamp'
        public Guid ConditionId { get; set; }
        public Guid FinanceId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(8000)]
        public string? Description { get; set; }
         
        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        [Column(TypeName = "jsonb")]
        public string? Metadata { get; set; } // JSON: { "year": 1887, "mint_mark": "S", ... }

        

        // Navigation
        public virtual Collection Collection { get; set; } = null!;
        public virtual ICollection<Media> Media { get; set; } = new List<Media>();
        public virtual ItemExternalReference? ExternalReference { get; set; }

    }
}

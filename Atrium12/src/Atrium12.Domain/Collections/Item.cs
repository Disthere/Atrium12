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
        public required Guid CollectionId { get; set; }

        [Required]
        public required Guid ItemType { get; set; }  // 'Coin', 'Banknote', 'Stamp'
        public Guid ConditionId { get; set; }
        public Guid FinanceId { get; set; }

        [Required]
        [MaxLength(255)]
        public required string Name { get; set; } 

        [MaxLength(8000)]
        public string? Description { get; set; }
         
        [Required]
        public required DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        [Column(TypeName = "jsonb")]
        public string? Metadata { get; set; } // JSON: { "year": 1887, "mint_mark": "S", ... }

        

        // Navigation
        public virtual Collection? Collection { get; set; }
        public virtual ICollection<Media> Media { get; set; } = [];
        public virtual ItemExternalReference? ExternalReference { get; set; }

    }
}

using Atrium12.Domain.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atrium12.Domain.MarketPriceSources
{
    public class MarketPriceHistory
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid ItemId { get; set; }

        [Required]
        public int SourceId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required, MaxLength(3)]
        public string Currency { get; set; } = "USD";

        [Required]
        public DateTime RecordedAt { get; set; }

        [MaxLength(500)]
        public string? SourceUrl { get; set; }

        [MaxLength(50)]
        public string? Grade { get; set; } // 'MS62', 'AU50'

        public bool IsAuction { get; set; } = false;
        public bool IsRetail { get; set; } = false;

        // Navigation
        public virtual Item Item { get; set; } = null!;
        public virtual MarketPriceSource Source { get; set; } = null!;
    }
}

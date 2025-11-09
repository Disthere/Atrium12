using System.ComponentModel.DataAnnotations;

namespace Atrium12.MarketPrices.Domain
{
    public class MarketPriceSource
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty; // 'PCGS', 'NGC', 'eBay', 'Heritage'

        [MaxLength(500)]
        public string? BaseUrl { get; set; }

        [MaxLength(255)]
        public string? ApiKey { get; set; }

        public bool IsActive { get; set; } = true;

        // Navigation
        public virtual ICollection<MarketPriceHistory> PriceHistories { get; set; } = new List<MarketPriceHistory>();
    }
}

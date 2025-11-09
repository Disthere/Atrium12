using Atrium12.Domain.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atrium12.MarketPrices.Domain
{
    public class PriceForecast
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid ItemId { get; set; }

        [Required, MaxLength(100)]
        public string Model { get; set; } = string.Empty; // 'LSTM-2024', 'Prophet'

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Forecast1Year { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Forecast3Year { get; set; }

        [Column(TypeName = "decimal(3,2)")]
        public decimal? ConfidenceInterval { get; set; }

        [Required]
        public DateTime GeneratedAt { get; set; }

        [Required]
        public DateTime ValidUntil { get; set; }

        // Navigation
        public virtual Item Item { get; set; } = null!;
    }
}

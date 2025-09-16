using Atrium12.Domain.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atrium12.Domain.MarketPriceSources
{
    public class ItemFinance
    {
        [Key]
        public Guid ItemId { get; set; } // Один к одному с Item

        public DateTime? AcquiredAt { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? PurchasePrice { get; set; }

        [MaxLength(3)]
        public string? Currency { get; set; } = "USD"; // Валюта покупки

        // Navigation
        public virtual Item Item { get; set; } = null!;
        public virtual ICollection<MarketPriceHistory> PriceHistories { get; set; } = new List<MarketPriceHistory>();
        public virtual ICollection<PriceForecast> PriceForecasts { get; set; } = new List<PriceForecast>();
    }
}

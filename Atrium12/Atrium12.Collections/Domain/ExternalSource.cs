using System.ComponentModel.DataAnnotations;

namespace Atrium12.Collections.Domain
{
    public class ExternalSource
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Code { get; set; } = string.Empty; // 'PCGS', 'Numista', 'Colnect', 'Heritage'

        [Required, MaxLength(200)]
        public string Name { get; set; } = string.Empty; // "Professional Coin Grading Service", "Numista Catalog"

        [MaxLength(500)]
        public string? BaseUrl { get; set; } // "https://www.pcgs.com", "https://en.numista.com"

        [MaxLength(500)]
        public string? ApiEndpoint { get; set; } // "https://api.numista.com/api/v2/coins/{id}"

        [MaxLength(255)]
        public string? ApiKey { get; set; } // если нужен для запросов

        [MaxLength(500)]
        public string? LogoUrl { get; set; } // URL логотипа для отображения

        public bool IsActive { get; set; } = true;
        public bool SupportsVerification { get; set; } = false; // Может ли подтверждать подлинность?
        public bool AutoSyncEnabled { get; set; } = false; // Синхронизировать автоматически?

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        public virtual ICollection<ItemExternalReference> Items { get; set; } = new List<ItemExternalReference>();
    }
}

using System.ComponentModel.DataAnnotations;

namespace Atrium12.Collections.Domain
{
    public class ItemExternalReference
    {
        [Key]
        public Guid ItemId { get; set; } // 1:1 с Item

        public int? ExternalSourceId { get; set; } // Может быть null

        [Required, MaxLength(255)]
        public string ExternalId { get; set; } = string.Empty; // ID в источнике: "coin-12345", "stamp-67890"

        public bool IsVerified { get; set; } = false; // Подтверждено ли вручную или через API

        [MaxLength(1000)]
        public string? VerificationNotes { get; set; } // "Подтверждено экспертом PCGS 2024-06-01"

        public DateTime? VerifiedAt { get; set; }
        public Guid? VerifiedByUserId { get; set; } // Кто подтвердил?

        public DateTime? LastSyncedAt { get; set; } // Когда последний раз синхронизировали данные
        public string? SyncStatus { get; set; } // "Success", "Failed", "Pending"

        // Navigation
        public virtual Item Item { get; set; } = null!;
        public virtual ExternalSource? Source { get; set; }
        public virtual User? VerifiedByUser { get; set; }
    }
}

using Atrium12.Domain.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atrium12.Domain.Gradings
{
    public class ItemCondition
    {
        [Key]
        public Guid ItemId { get; set; } // 1:1 с Item

        public int? GradeId { get; set; } // Может быть null, если состояние неизвестно

        [Column(TypeName = "decimal(3,2)")]
        public decimal? Confidence { get; set; } // 0.00 to 1.00 — уверенность в оценке

        [MaxLength(500)]
        public string? Notes { get; set; } // "Небольшой скол на гурте", "Подтверждено экспертом"

        public DateTime? AssessedAt { get; set; } // Когда была произведена оценка
        public Guid? AssessedByUserId { get; set; } // Кто оценил — пользователь или система

        // Navigation
        public virtual Item Item { get; set; } = null!;
        public virtual Grade? Grade { get; set; }
        public virtual User? AssessedByUser { get; set; }
    }
}

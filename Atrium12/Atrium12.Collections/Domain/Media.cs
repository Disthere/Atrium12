using System.ComponentModel.DataAnnotations;

namespace Atrium12.Collections.Domain
{
    public class Media
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid ItemId { get; set; }

        [Required]
        [MaxLength(500)]
        public string Url { get; set; } = string.Empty; // S3/MinIO URL

        [MaxLength(500)]
        public string? ThumbnailUrl { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type { get; set; } = "PhotoFront"; // 'PhotoFront', 'PhotoBack', 'Certificate', 'Video'

        [Required]
        public DateTime UploadedAt { get; set; }

        public bool IsPrimary { get; set; } = false;

        [MaxLength(100)]
        public string? MimeType { get; set; } // 'image/jpeg', 'application/pdf'

        public long? FileSizeBytes { get; set; }

        public int? WidthPx { get; set; }

        public int? HeightPx { get; set; }

        // Navigation
        public virtual Item Item { get; set; } = null!;
    }
}

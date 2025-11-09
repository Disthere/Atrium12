using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atrium12.Collections.Domain
{
    public class Album
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty; // "Morgan Dollar 1878-1921"

        [MaxLength(8000)]
        public string? Description { get; set; }

        [MaxLength(100)]
        public string? SourceName { get; set; } // "PCGS", "Numista", "Heritage"

        [MaxLength(500)]
        public string? SourceUrl { get; set; }

        [Column(TypeName = "jsonb")]
        public string? Metadata { get; set; } // JSON: { "years": [...], "mint_marks": [...] }

        [Required]
        public DateTime CreatedAt { get; set; }

        public bool IsOfficial { get; set; } = true;

        public Guid? CreatedByUserId { get; set; }

        // Navigation
        public virtual User? CreatedByUser { get; set; }
        public virtual ICollection<CollectionAlbum> CollectionAlbums { get; set; } = new List<CollectionAlbum>();
    }
}

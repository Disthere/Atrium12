using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atrium12.Domain.Collections
{
    public class CollectionAlbum
    {
        [Key]
        [Column(Order = 1)]
        public Guid CollectionId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid AlbumId { get; set; }

        [Required]
        public DateTime AddedAt { get; set; }

        // Navigation
        public virtual Collection Collection { get; set; } = null!;
        public virtual Album Album { get; set; } = null!;
    }
}

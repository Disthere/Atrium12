using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atrium12.Domain.Collections
{
    public class Collection
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public required Guid UserId { get; set; }

        [Required]
        public required Guid CollectionTypeId { get; set; } // 'Частная', 'Открытая',

        [Required]
        [MaxLength(512)]
        public required string Name { get; set; }

        [MaxLength(8000)]
        public string? Description { get; set; }

        [Required]
        public required DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        public bool IsPublic { get; set; } = false;

        [Required]
        public Guid? CoverImageId { get; set; }

        // Navigation properties
        public virtual Media? CoverImage { get; set; }

         //public virtual ICollection<CollectionAlbum> CollectionAlbums { get; set; } = new List<CollectionAlbum>();

        public virtual ICollection<Item> Items { get; set; } = new List<Item>();
    }
}

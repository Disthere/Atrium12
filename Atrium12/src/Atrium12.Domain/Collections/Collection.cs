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
        public Guid UserId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(8000)]
        public string? Description { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        public bool IsPublic { get; set; } = false;

        [Required]
        [MaxLength(50)]
        public string Type { get; set; } = "Custom"; // 'Coins', 'Stamps', 'Banknotes', 'Custom'

        public Guid? CoverImageId { get; set; }

        // Navigation properties
        public virtual User? User { get; set; }
        public virtual Media? CoverImage { get; set; }
        public virtual ICollection<CollectionAlbum> CollectionAlbums { get; set; } = new List<CollectionAlbum>();
        public virtual ICollection<Item> Items { get; set; } = new List<Item>();
    }
}

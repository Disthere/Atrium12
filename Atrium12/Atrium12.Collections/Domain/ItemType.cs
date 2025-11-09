using System.ComponentModel.DataAnnotations;

namespace Atrium12.Collections.Domain
{
    public class ItemType
    {
        public Guid Id { get; set; }

        [Required] 
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty; // техническое имя: "SpaceRocks"

        [MaxLength(524)]
        public string? DisplayName { get; set; } // для отображения: "Космические камни"

        [MaxLength(1000)]
        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsSystem { get; set; } = false;

        // Navigation
        public virtual ICollection<Item> Items { get; set; } = new List<Item>();
    }
}

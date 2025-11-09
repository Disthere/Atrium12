using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Atrium12.Collections.Domain
{
    public class Item
    {
        public Item(
            Guid id,
            Guid collectionId,
            Guid itemTypeId,
            string name,
            string? description,
            Guid? conditionId,
            Guid? financeId,
            string? metadata)
        {
            Id = id;
            CollectionId = collectionId;
            ItemTypeId = itemTypeId;
            Name = name;
            Description = description;
            ConditionId = conditionId;
            FinanceId = financeId;
            Metadata = metadata;
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid CollectionId { get; set; }

        [Required]
        public Guid ItemTypeId { get; set; } // 'Coin', 'Banknote', 'Stamp'

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(8000)]
        public string? Description { get; set; }

        public Guid? ConditionId { get; set; }

        public Guid? FinanceId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        [Column(TypeName = "jsonb")]
        public string? Metadata { get; set; } // JSON: { "year": 1887, "mint_mark": "S", ... }

        // Navigation properties
        public virtual Collection? Collection { get; set; }

        public virtual ICollection<Media> Media { get; set; } = [];

        public virtual ItemExternalReference? ExternalReference { get; set; }
    }
}

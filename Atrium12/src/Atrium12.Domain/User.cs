using Atrium12.Domain.Collections;
using System.ComponentModel.DataAnnotations;

namespace Atrium12.Domain
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Username { get; set; } = string.Empty;

        // Другие свойства по необходимости...

        // Navigation
        public virtual ICollection<Collection> Collections { get; set; } = new List<Collection>();
        public virtual ICollection<Album> CreatedAlbums { get; set; } = new List<Album>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atrium12.Comments.Domain
{
    public class Comment
    {
        public Guid Id { get; set; }
        public required Guid UserId { get; set; }
        public required Guid EntityId { get; set; }
        public required string Content { get; set; }
        public Comment? Parent { get; set; }
        public IEnumerable<Comment> Children { get; set; } = [];
    }
}

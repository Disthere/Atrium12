using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atrium12.Domain.Tags
{
    public class Tag
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
    }
}

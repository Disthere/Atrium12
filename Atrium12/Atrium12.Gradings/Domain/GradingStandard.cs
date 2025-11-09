using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atrium12.Gradings.Domain
{
    public class GradingStandard
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Code { get; set; } = string.Empty; // 'PCGS', 'NGC', 'SCBC', 'StampWorld'

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty; // 'Professional Coin Grading Service'

        [MaxLength(500)]
        public string? Description { get; set; }

        [MaxLength(500)]
        public string? OfficialUrl { get; set; }

        public bool IsActive { get; set; } = true;

        // Navigation
        public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
    }
}

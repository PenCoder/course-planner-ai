using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoursePlanner.API.Models
{
    public class Plan
    {
        public int PlanId { get; set; }

        [Required]
        public string Semester { get; set; } = string.Empty;

        public int Year { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; } = new User();

        // Navigation property
        public ICollection<PlanEntry> PlanEntries { get; set; } = new List<PlanEntry>();
    }
}
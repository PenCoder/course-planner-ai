using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CoursePlanner.API.Models
{
    public class PlanEntry
    {
        public int PlanEntryId { get; set; }

        public string DayOfWeek { get; set; } = string.Empty;
        public string TimeSlot { get; set; } = string.Empty;

        // ForeignKey Keys
        public int PlanId { get; set; }
        public int CourseId { get; set; }

        [ForeignKey("PlanId")]
        public Plan Plan { get; set; } = new Plan();

        [ForeignKey("CourseId")]
        public Course Course { get; set; } = new Course();
    }
}
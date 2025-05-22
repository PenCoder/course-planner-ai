using System.ComponentModel.DataAnnotations;

namespace CoursePlanner.API.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Code { get; set; } = string.Empty;

        [Required]
        public string Title { get; set; } = string.Empty;
        public int Credits { get; set; }
        public string Department { get; set; } = string.Empty;
        public string Semester { get; set; } = string.Empty;
    }
}
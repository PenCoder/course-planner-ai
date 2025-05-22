using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoursePlanner.API.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation property 
        public ICollection<Plan> Plans { get; set; } = new List<Plan>();
    }
}
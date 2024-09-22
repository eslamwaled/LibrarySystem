using System;
using System.ComponentModel.DataAnnotations;
using LibrarySystem.Models.Common;

namespace LibrarySystem.Services.Src.Services.auth
{
    public record UserOutPutDTO
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }
        
        [Required]
        public UserRole Role { get; set; }
    }
}
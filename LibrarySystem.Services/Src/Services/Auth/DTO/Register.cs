using LibrarySystem.Models.Common;

namespace LibrarySystem.Services.Src.Services.auth
{
    public record RegisterDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }

    }
}


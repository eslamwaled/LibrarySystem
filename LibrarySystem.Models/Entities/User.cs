using Microsoft.AspNetCore.Identity;
using LibrarySystem.Models.Common;

namespace LibrarySystem.Models.Entities
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }

    }

}
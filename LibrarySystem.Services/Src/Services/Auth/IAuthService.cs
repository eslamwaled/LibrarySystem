using LibrarySystem.Models.Entities;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace LibrarySystem.Services.Src.Services.auth
{
    [ScopedService]

    public interface IAuthService
    {
        Task<bool> RegisterAsync(RegisterDto registerDto);
        Task<string> LoginAsync(LoginDto loginDto);
    }
}



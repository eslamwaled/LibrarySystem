using LibrarySystem.Services.Src.Services.user.DTO;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace LibrarySystem.Services.Src.Services.user
{
    [ScopedService]

    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetAllAsync();
        Task<UserDTO> GetByIdAsync(Guid id);
        Task AddAsync(UserDTO user);
        Task UpdateAsync(UserDTO user);
        Task DeleteAsync(Guid id);
        Task<UserDTO> FindByEmailAsync(string email,string password);
    }
}
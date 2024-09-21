using LibrarySystem.Services.Src.Services.author.DRO;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace LibrarySystem.Services.Src.Services.author
{
    [ScopedService]
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorDTO>> GetAllAsync();
        Task<AuthorDTO> GetByIdAsync(Guid id);
        Task AddAsync(AuthorDTO admin);
        Task UpdateAsync(AuthorDTO admin);
        Task DeleteAsync(Guid id);
    }
}
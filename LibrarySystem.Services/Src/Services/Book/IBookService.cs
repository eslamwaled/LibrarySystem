using LibrarySystem.Services.Src.Services.book.DTO;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace LibrarySystem.Services.Src.Services.book
{
    [ScopedService]

    public interface IBookService
    {
        Task<IEnumerable<BookDTO>> GetAllAsync();
        Task<BookDTO> GetByIdAsync(Guid id);
        Task AddAsync(BookDTO book);
        Task UpdateAsync(BookDTO book);
        Task DeleteAsync(Guid id);

    }
}
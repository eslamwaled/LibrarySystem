using TanvirArjel.Extensions.Microsoft.DependencyInjection;
using LibrarySystem.Models.Entities;
using LibrarySystem.Services.Src.EF.Repo.Base;

namespace LibrarySystem.Services.Src.EF.Repo.Interface
{
    [ScopedService]
    public interface IBookRepo : IBaseRepository<Book>
    {
        Task AddAsync(Book book);
    }
}
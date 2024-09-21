using TanvirArjel.Extensions.Microsoft.DependencyInjection;
using LibrarySystem.Models.Entities;
using LibrarySystem.Services.Src.EF.Repo.Base;

namespace LibrarySystem.Services.Src.EF.Repo.Interface
{
    [ScopedService]
    public interface IUserRepo : IBaseRepository<User>
    {
        Task AddAsync(User userEntity);
    }
}
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using LibrarySystem.Services.Src.EF.Repo.Base;
using LibrarySystem.Services.Src.EF.Repo.Interface;
using LibrarySystem.Models.Entities;

namespace LibrarySystem.Services.Src.EF.Repo.Imp
{

    public class AuthorRepo : BaseRepo<Author>, IAuthorRepo
    {
        private readonly DbSet<Author> _DbSet;
        private readonly IMapper _mapper;
        public AuthorRepo(DemoDBContext context, IMapper mapper) : base(context)
        {
            _DbSet = context.Set<Author>();
            _mapper = mapper;
        }
        public async Task<IEnumerable<Author>> GetAuthorsWithBoks()
        {
            return await _DbSet.Include(x => x.Books).AsNoTracking().ToListAsync();
        }
    }
}
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using LibrarySystem.Services.Src.EF.Repo.Base;
using LibrarySystem.Services.Src.EF.Repo.Interface;
using LibrarySystem.Models.Entities;

namespace LibrarySystem.Services.Src.EF.Repo.Imp
{
    public class BookRepo : BaseRepo<Book>, IBookRepo
    {
        private readonly DbSet<Book> _DbSet;
        private readonly IMapper _mapper;
        public BookRepo(DemoDBContext context, IMapper mapper) : base(context)
        {
            _DbSet = context.Set<Book>();
            _mapper = mapper;
        }
    }
} 
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using LibrarySystem.Services.Src.EF.Repo.Base;
using LibrarySystem.Services.Src.EF.Repo.Interface;
using LibrarySystem.Models.Entities;

namespace LibrarySystem.Services.Src.EF.Repo.Imp
{
    public class UserRepo : BaseRepo<User>, IUserRepo
    {
        private readonly DbSet<User> _DbSet;
        private readonly IMapper _mapper;
        public UserRepo(DemoDBContext context, IMapper mapper) : base(context)
        {
            _DbSet = context.Set<User>();
            _mapper = mapper;
        }
    }
} 
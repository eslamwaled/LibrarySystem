using AutoMapper;
using LibrarySystem.Models.Entities;
using LibrarySystem.Services.Src.EF.Repo.Interface;
using LibrarySystem.Services.Src.Services.author.DRO;

namespace LibrarySystem.Services.Src.Services.author
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepo _authorRepo;
        private readonly IMapper _mapper;

        public AuthorService(IAuthorRepo authorRepo, IMapper mapper)
        {
            _authorRepo = authorRepo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AuthorDTO>> GetAllAsync()
        {
            var Authors = await _authorRepo.GetAuthorsWithBoks();
            return _mapper.Map<IEnumerable<AuthorDTO>>(Authors);
        }

        public async Task<AuthorDTO> GetByIdAsync(Guid id)
        {
            var admin = await _authorRepo.GetByIdAsync(id);
            return _mapper.Map<AuthorDTO>(admin);
        }

        public async Task AddAsync(AuthorDTO author)
        {
            author.Id = Guid.NewGuid();
            var newAuthor = _mapper.Map<Author>(author);
            await _authorRepo.AddAsync(newAuthor);
        }

        public async Task UpdateAsync(AuthorDTO admin)
        {
            var admintoUpdate = await _authorRepo.GetByIdAsync(admin.Id);
            var newAdmin = _mapper.Map(admin,admintoUpdate);
            await _authorRepo.UpdateAsync(newAdmin);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _authorRepo.DeleteAsync(id);
        }
    }
}
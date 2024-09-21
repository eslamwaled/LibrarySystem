using AutoMapper;
using LibrarySystem.Models.Entities;
using LibrarySystem.Services.Src.EF.Repo.Interface;
using LibrarySystem.Services.Src.Services.book.DTO;

namespace LibrarySystem.Services.Src.Services.book
{
    public class BookService : IBookService
    {
        private readonly IBookRepo _bookRepo;
        private readonly IMapper _mapper;

        public BookService(IBookRepo bookRepo, IMapper mapper)
        {
            _bookRepo = bookRepo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BookDTO>> GetAllAsync()
        {
            var books = await _bookRepo.GetAllAsync();
            return _mapper.Map<IEnumerable<BookDTO>>(books);
        }

        public async Task<BookDTO> GetByIdAsync(Guid id)
        {
            var book = await _bookRepo.GetByIdAsync(id);
            return _mapper.Map<BookDTO>(book);
        }

        public async Task AddAsync(BookDTO bookDTO)
        {
            bookDTO.Id = Guid.NewGuid();
            var book = _mapper.Map<Book>(bookDTO);
            await _bookRepo.AddAsync(book);
        }

        public async Task UpdateAsync(BookDTO bookDTO)
        {
            var bookForUpdate = await _bookRepo.GetByIdAsync(bookDTO.Id);
            var updatedBook = _mapper.Map(bookDTO, bookForUpdate);
            await _bookRepo.UpdateAsync(updatedBook);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _bookRepo.DeleteAsync(id);
        }
    }
}

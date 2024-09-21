using System.ComponentModel.DataAnnotations;
using LibrarySystem.Services.Src.Services.book.DTO;

namespace LibrarySystem.Services.Src.Services.author.DRO
{
    public record AuthorDTO
    {
        public Guid Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        public List<BookDTO> Books { get; set; }
    }
}
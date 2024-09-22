using System.ComponentModel.DataAnnotations;
using LibrarySystem.Services.Src.Services.book.DTO;

namespace LibrarySystem.Services.Src.Services.author.DRO
{
    public record AuthorDTO
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 100 characters.")]
        public string Name { get; set; }

        public List<BookDTO> Books { get; set; }
    }
}
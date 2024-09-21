using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Services.Src.Services.book.DTO
{
    public record BookDTO
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Summary is required.")]
        public string? Summary { get; set; }

        [Required(ErrorMessage = "IsRecommended is required.")]
        public bool IsRecommended { get; set; }

        [Required(ErrorMessage = "FilePath is required.")]
        public string? FilePath { get; set; }

        [Required(ErrorMessage = "AdminId is required.")]
        public Guid AuthorId { get; set; }
    }
}
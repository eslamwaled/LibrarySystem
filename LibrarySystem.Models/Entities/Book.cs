namespace LibrarySystem.Models.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Summary { get; set; }
        public bool IsRecommended { get; set; }
        public string? FilePath { get; set; }
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
    }

}

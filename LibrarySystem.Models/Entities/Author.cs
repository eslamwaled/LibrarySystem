namespace LibrarySystem.Models.Entities
{
    public class Author
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; } 
    }
}
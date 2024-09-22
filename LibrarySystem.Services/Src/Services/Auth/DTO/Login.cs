namespace LibrarySystem.Services.Src.Services.auth
{
    public record LoginDto
    {
        public string Email { get; set; } 
        public string Password { get; set; }

    }
}

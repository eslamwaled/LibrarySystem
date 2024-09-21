using LibrarySystem.Services.Src.Services.author;
using LibrarySystem.Services.Src.Services.author.DRO;
using Microsoft.AspNetCore.Mvc;
[Route("api/[controller]")]
[ApiController]
public class AuthorController : ControllerBase
{
    private readonly IAuthorService _authorervice;

    public AuthorController(IAuthorService authorervice)
    {
        _authorervice = authorervice;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAuthors()
    {
        return Ok(await _authorervice.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAuthorById(Guid id)
    {
        
        return Ok(await _authorervice.GetByIdAsync(id));

    }

    [HttpPost]
    public async Task<IActionResult> AddAuthor(AuthorDTO author)
    {
        await _authorervice.AddAsync(author);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAuthor(AuthorDTO author)
    {
        await _authorervice.UpdateAsync(author);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAuthor(Guid id)
    {
        await _authorervice.DeleteAsync(id);
        return Ok();
    }
}
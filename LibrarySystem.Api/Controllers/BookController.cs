using LibrarySystem.Services.Src.Services.book;
using LibrarySystem.Services.Src.Services.book.DTO;
using Microsoft.AspNetCore.Mvc;
[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllBooks()
    {
        return Ok(await _bookService.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        return Ok(await _bookService.GetByIdAsync(id));
    }

    [HttpPost]
    public async Task<IActionResult> AddBook(BookDTO bookDTO)
    {
        await _bookService.AddAsync(bookDTO);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateBook(BookDTO bookDTO)
    {
        await _bookService.UpdateAsync(bookDTO);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBook(Guid id)
    {
        await _bookService.DeleteAsync(id);
        return Ok();
    }
}
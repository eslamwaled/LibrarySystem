using LibrarySystem.Services.Src.Services.auth;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto registerDto)
    {
        var result = await _authService.RegisterAsync(registerDto);
        if (result)
        {
            return Ok("Registration successful");
        }

        return BadRequest("Registration failed");
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto loginDto)
    {
        try
        {
            var result = await _authService.LoginAsync(loginDto);
            if (result != null)
            {
                return Ok(result);
            }

            return Unauthorized("Invalid credentials");
        }
        catch (Exception ex)
        {
            // Log the exception (ex) here if needed
            return StatusCode(500, "An error occurred while processing your request.");
        }
    }
}

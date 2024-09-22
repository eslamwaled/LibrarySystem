namespace LibrarySystem.Services.Src.Services.auth
{
    using global::AutoMapper;
    using LibrarySystem.Models.Entities;
    using LibrarySystem.Services.Src.Services.user;
    using LibrarySystem.Services.Src.Services.user.DTO;
    using Microsoft.AspNetCore.Identity;
    using System.Threading.Tasks;

    public class AuthService : IAuthService
    {
        private readonly IUserService userService;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public AuthService(IUserService _userService, IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            userService = _userService;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<bool> RegisterAsync(RegisterDto registerDto)
        {
            var user = new User
            {
                NormalizedEmail = registerDto.Email,
                UserName = registerDto.Email,
                Name = registerDto.Name,
                Email = registerDto.Email,
                Password = registerDto.Password,
                Role = registerDto.Role,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, registerDto.Password);
            return result.Succeeded;
        }

        public async Task<string> LoginAsync(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);

            if (user == null)
            {
                return "User not found";
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
            if (result.Succeeded)
            {
                return "Login successful";
            }

            return "Invalid credentials";
        }


    }

}
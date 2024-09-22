namespace LibrarySystem.Services.Src.Services.auth
{
    using global::AutoMapper;
    using LibrarySystem.Services.Src.Services.user;
    using LibrarySystem.Services.Src.Services.user.DTO;
    using System.Threading.Tasks;

    public class AuthService : IAuthService
    {
        private readonly IUserService userService;
        private readonly IMapper _mapper;
        public AuthService(IUserService _userService, IMapper mapper)
        {
            userService = _userService;
            _mapper = mapper;
        }

        public async Task<bool> RegisterAsync(RegisterDto registerDto)
        {

            var user = _mapper.Map<UserDTO>(registerDto);
            user.Id = Guid.NewGuid();
            try
            {
                await userService.AddAsync(user);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<UserOutPutDTO> LoginAsync(LoginDto loginDto)
        {
            var user = await userService.FindByEmailAsync(loginDto.Email, loginDto.Password);
            var userOutPut = user == null ? null : _mapper.Map<UserOutPutDTO>(user);
            return userOutPut;
        }
    }

}
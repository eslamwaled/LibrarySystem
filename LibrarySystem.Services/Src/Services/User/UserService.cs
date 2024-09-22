using AutoMapper;
using LibrarySystem.Models.Entities;
using LibrarySystem.Services.Src.EF.Repo.Interface;
using LibrarySystem.Services.Src.Services.user.DTO;


namespace LibrarySystem.Services.Src.Services.user
{
    public class UserService:IUserService
    {
        private readonly IUserRepo _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepo userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDTO>> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<UserDTO>>(users);
        }

        public async Task<UserDTO> GetByIdAsync(Guid id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return _mapper.Map<UserDTO>(user);
        }

        public async Task AddAsync(UserDTO user)
        {
            user.Id = Guid.NewGuid();
            var userEntity = _mapper.Map<User>(user);
            await _userRepository.AddAsync(userEntity);
        }

        public async Task UpdateAsync(UserDTO user)
        {
            var UserForUpdate = await _userRepository.GetByIdAsync(user.Id);
            var userEntity = _mapper.Map(user,UserForUpdate);
            await _userRepository.UpdateAsync(userEntity);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _userRepository.DeleteAsync(id);
        }
        public async Task<UserDTO> FindByEmailAsync(string email, string password)
        {
            var user = await _userRepository.GetUserForLogin(email, password);
            return _mapper.Map<UserDTO>(user);
        }
    }

}